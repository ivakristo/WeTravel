using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WeTravel
{
    public partial class FormaNoviRacun : Form
    {
        public FormaNoviRacun()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda za prikaz putnika u datagridview.
        /// </summary>
        private void PrikaziPutnike()
        {
            BindingList<putnik> listaPutnika = null;
            using (var bp = new EntitiesWeTravel())
            {
                listaPutnika = new BindingList<putnik>(bp.putnik.ToList());
            }
            putnikBindingSource1.DataSource = listaPutnika;
        }
        /// <summary>
        /// Metoda za prikaz rezervacije u datagridview.
        /// </summary>
        /// <param name="putni"></param>                
        private void PrikaziRezervacije(putnik putni)
        {
            BindingList<rezervacija> listaRezervacija = null;
            using (var bp = new EntitiesWeTravel())
            {
                bp.putnik.Attach(putni);
                listaRezervacija = new BindingList<rezervacija>(putni.rezervacija.ToList());
            }
            rezervacijaBindingSource.DataSource = listaRezervacija;
            putnikBindingSource.DataSource = putni;
        }
        /// <summary>
        /// Metoda za prikaz računa i njegovih stvaki u reportviewer.
        /// </summary>
        /// <param name="rez"></param>
        private void PrikaziRacun(rezervacija rez)
        {
            BindingList<racun> listaracuna = null;
            using (var bp = new EntitiesWeTravel())
            {
                bp.rezervacija.Attach(rez);
                listaracuna = new BindingList<racun>(rez.racun.ToList());
                foreach (var item in listaracuna)
                {
                    var zaposlenik = (from zaposleni in bp.zaposlenik
                                      where zaposleni.zaposlenik_id == item.zaposlenik_FK
                                      select new
                                      {
                                          ime = zaposleni.ime,
                                          prezime = zaposleni.prezime
                                      }).ToList();
                    zaposlenikBindingSource.DataSource = zaposlenik;
                }

                var listaPutovanja = (from reze in bp.rezervacija
                                      join put in bp.putovanje on reze.putovanje_FK equals put.putovanje_id
                                      where rez.putovanje_FK == put.putovanje_id && rez.rezervacija_id == reze.rezervacija_id
                                      select new
                                      {
                                          datumvrijeme_polaska = put.datumvrijeme_polaska,
                                          datumvrijeme_povratka = put.datumvrijeme_povratka,
                                          cijena = put.cijena,
                                          naziv = put.naziv
                                      }).ToList();
                putovanjeBindingSource1.DataSource = listaPutovanja;
                BindingList<dodatna_aktivnost> listaDodatneAktivnosti = new BindingList<dodatna_aktivnost>(rez.dodatna_aktivnost.ToList());
                dodatnaaktivnostBindingSource.DataSource = listaDodatneAktivnosti;
            }
            racunBindingSource.DataSource = listaracuna;
        }
        /// <summary>
        /// Metoda za izračun ukupne cijene računa prilikom izdavanja novog računa.
        /// </summary>
        /// <param name="rezervacijaUkupnaCijena"></param>
        /// <returns></returns>
        private double UkupnaCijenaRacuna(rezervacija rezervacijaUkupnaCijena)
        {
            using (var bp = new EntitiesWeTravel())
            {
                bp.rezervacija.Attach(rezervacijaUkupnaCijena);
                var putovanjeCijena = (from put in bp.putovanje
                                       join reze in bp.rezervacija on put.putovanje_id equals reze.putovanje_FK
                                       join putni in bp.putnik on reze.putnik_FK equals putni.putnik_id
                                       where put.putovanje_id == rezervacijaUkupnaCijena.putovanje_FK && putni.putnik_id == rezervacijaUkupnaCijena.putnik_FK
                                       select put.cijena);
                BindingList<dodatna_aktivnost> listaDodatneAktivnosti = new BindingList<dodatna_aktivnost>(rezervacijaUkupnaCijena.dodatna_aktivnost.ToList());
                List<double> listaCijenaDodatnih = new List<double>();
                foreach (var item in listaDodatneAktivnosti)
                {
                    listaCijenaDodatnih.Add(item.cijena);
                }

                double ukupnaCijena = 0;
                foreach (var item in putovanjeCijena)
                {
                    ukupnaCijena += item;
                }
                foreach (var item in listaCijenaDodatnih)
                {
                    ukupnaCijena += item;
                }
                return ukupnaCijena;
            }
        }

        private void FormaNoviRacun_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            PrikaziPutnike();
            PrikaziRezervacije(putnikBindingSource1.Current as putnik);
            PrikaziRacun(rezervacijaBindingSource.Current as rezervacija);
            this.reportViewer1.RefreshReport();
        }

        private void dataGridViewPutnik_SelectionChanged(object sender, EventArgs e)
        {
            putnik selektiraniPutnik = putnikBindingSource1.Current as putnik;
            if (selektiraniPutnik != null)
            {
                PrikaziRezervacije(selektiraniPutnik);
                this.reportViewer1.RefreshReport();
            }
        }

        private void dataGridViewRezervacijePutovanja_SelectionChanged(object sender, EventArgs e)
        {
            rezervacija selektiranaRezervacija = rezervacijaBindingSource.Current as rezervacija;
            if (selektiranaRezervacija != null)
            {
                PrikaziRacun(selektiranaRezervacija);
                this.reportViewer1.RefreshReport();
            }
        }
        /// <summary>
        /// Izdavanje novog računa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonIzdavanjeRacuna_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewRezervacijePutovanja.CurrentRow.Index;
            using (var bp = new EntitiesWeTravel())
            {
                var noviRacun = new racun
                {
                    zaposlenik_FK = Sesija.ZaposlenikId,
                    datumvrijeme_izdavanja = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")),
                    ukupna_cijena = UkupnaCijenaRacuna(rezervacijaBindingSource.Current as rezervacija),
                    rezervacija_FK = int.Parse(dataGridViewRezervacijePutovanja.Rows[rowindex].Cells[0].Value.ToString())
                };
                try
                {
                    bp.racun.Add(noviRacun);
                    bp.SaveChanges();
                    PrikaziPutnike();
                    this.reportViewer1.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Račun je već izdan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Pretraživanje putnika po imenu prilikom pritiska tipke.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void textBoxPretrazivanjePutnika_KeyDown(object sender, KeyEventArgs e)
        {
            string pretrazivanjeIme = textBoxPretrazivanjePutnika.Text;
            if (string.IsNullOrEmpty(pretrazivanjeIme))
            {
                PrikaziPutnike();
            }
            else
            {
                using (var bp = new EntitiesWeTravel())
                {
                    var pretrazivanje = (from putni in bp.putnik
                                         where putni.ime.Contains(pretrazivanjeIme)
                                         select new
                                         {
                                             putnik_id = putni.putnik_id,
                                             ime = putni.ime,
                                             prezime = putni.prezime,
                                             email = putni.email,
                                             kontakt = putni.kontakt
                                         }).ToList();
                    putnikBindingSource1.DataSource = pretrazivanje;
                    this.dataGridViewPutnik.Refresh();
                }
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            reportViewer1.PrintDialog();
        }

        private void FormaNoviRacun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm", HelpNavigator.Topic, "Izdavanje_racuna.htm");
            }
        }
    }
}
