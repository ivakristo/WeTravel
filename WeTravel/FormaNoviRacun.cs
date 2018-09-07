using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

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
            putnikBindingSource.DataSource = listaPutnika;
        }
        /// <summary>
        /// Metoda za prikaz rezervacije po putniku u datagridview.
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
            foreach (var item in listaRezervacija)
            {
                using (var bp = new EntitiesWeTravel())
                {
                    var rezervacijaDetalji = (from put in bp.putovanje
                                              join rez in bp.rezervacija on put.putovanje_id equals rez.putovanje_FK
                                              join putn in bp.putnik on rez.putnik_FK equals putn.putnik_id
                                              where rez.putnik_FK == putni.putnik_id
                                              select new
                                              {
                                                  rezervacija_id = rez.rezervacija_id,
                                                  putovanje_FK = put.naziv,
                                                  putnik_FK = putn.putnik_id
                                              });
                    dataGridViewRezervacijePutovanja.DataSource = rezervacijaDetalji.ToList();
                }
            }

            rezervacijaBindingSource.DataSource = listaRezervacija;
        }

        /// <summary>
        /// Metoda za izračun ukupne cijene računa prilikom izdavanja novog računa.
        /// </summary>
        /// <param name="rezervacijaUkupnaCijena"></param>
        /// <returns></returns>
        private double UkupnaCijenaRacuna()
        {
            int rowindex = dataGridViewRezervacijePutovanja.CurrentRow.Index;
            int rezervacijaID = int.Parse(dataGridViewRezervacijePutovanja.Rows[rowindex].Cells[0].Value.ToString());
            string nazivPutovanja = dataGridViewRezervacijePutovanja.Rows[rowindex].Cells[1].Value.ToString();
            int putnikID = int.Parse(dataGridViewRezervacijePutovanja.Rows[rowindex].Cells[2].Value.ToString());
            using (var bp = new EntitiesWeTravel())
            {
                var putovanjeCijena = (from put in bp.putovanje
                                       join reze in bp.rezervacija on put.putovanje_id equals reze.putovanje_FK
                                       join putni in bp.putnik on reze.putnik_FK equals putni.putnik_id
                                       where put.naziv == nazivPutovanja && putni.putnik_id == putnikID
                                       select put.cijena);
                var listaDodatnihAktivnosti = (from dodatne in bp.dodatna_aktivnost
                                               join pogled in bp.PogledRezervacijaDodatnihAktivnosti on dodatne.dodatna_aktivnost_id equals pogled.dodatne_aktivnosti_id
                                               where pogled.rezervacija_id == rezervacijaID
                                               select dodatne).ToList();

                List<double> listaCijenaDodatnih = new List<double>();
                foreach (var item in listaDodatnihAktivnosti)
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
            PrikaziRezervacije(putnikBindingSource.Current as putnik);

        }

        private void dataGridViewPutnik_SelectionChanged(object sender, EventArgs e)
        {
            putnik selektiraniPutnik = putnikBindingSource.Current as putnik;
            if (selektiraniPutnik != null)
            {
                PrikaziRezervacije(selektiraniPutnik);
                this.dataGridViewRezervacijePutovanja.Refresh();
            }
        }

        private void textBoxPretrazivanjePutnika_TextChanged(object sender, EventArgs e)
        {
            string pretrazivanjeIme = textBoxPretrazivanjePutnika.Text;
            if (string.IsNullOrEmpty(pretrazivanjeIme))
            {
                PrikaziPutnike();
            }
            else
            {
                BindingList<putnik> listaPutnika = null;
                using (var bp = new EntitiesWeTravel())
                {
                    listaPutnika = new BindingList<putnik>(bp.putnik.Where(imePutnika => imePutnika.ime.Contains(pretrazivanjeIme)).ToList());                  
                }
                putnikBindingSource.DataSource = listaPutnika;
            }
        }

        private void buttonIzdavanjeRacuna_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewRezervacijePutovanja.CurrentRow.Index;
            int rezervacijaID = int.Parse(dataGridViewRezervacijePutovanja.Rows[rowindex].Cells[0].Value.ToString());
            string nazivPutovanja = dataGridViewRezervacijePutovanja.Rows[rowindex].Cells[1].Value.ToString();
            int putnikID = int.Parse(dataGridViewRezervacijePutovanja.Rows[rowindex].Cells[2].Value.ToString());
            using (var bp = new EntitiesWeTravel())
            {
                var noviRacun = new racun
                {
                    zaposlenik_FK = Sesija.ZaposlenikId,
                    datumvrijeme_izdavanja = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")),
                    ukupna_cijena = UkupnaCijenaRacuna(),
                    rezervacija_FK = int.Parse(dataGridViewRezervacijePutovanja.Rows[rowindex].Cells[0].Value.ToString())
                };
                try
                {
                    bp.racun.Add(noviRacun);
                    bp.SaveChanges();
                    PrikaziPutnike();
                    FormaRacun formaRacun = new FormaRacun(rezervacijaID, nazivPutovanja);
                    formaRacun.ShowDialog();
                }
                catch (Exception)
                {
                    FormaRacun formaRacun = new FormaRacun(rezervacijaID, nazivPutovanja);
                    formaRacun.ShowDialog();
                }
            }
        }
    }
}
