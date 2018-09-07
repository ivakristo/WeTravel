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
    public partial class FormaRacun : Form
    {
        private int RezervacijaID = 0;
        private string NazivPutovanja = null;
        public FormaRacun(int rezervacijaID, string nazivPutovanja)
        {
            InitializeComponent();
            RezervacijaID = rezervacijaID;
            NazivPutovanja = nazivPutovanja;
        }

        private void PrikaziRacun()
        {

            using (var bp = new EntitiesWeTravel())
            {

                var listaRacuna = (from rac in bp.racun where rac.rezervacija_FK == RezervacijaID select rac);
                racunBindingSource.DataSource = listaRacuna.ToList();
                foreach (var item in listaRacuna)
                {
                    var zaposlenik = (from zaposleni in bp.zaposlenik
                                      where zaposleni.zaposlenik_id == item.zaposlenik_FK
                                      select new
                                      {
                                          ime = zaposleni.ime,
                                          prezime = zaposleni.prezime
                                      }).ToList();
                    var listaPutovanja = (from put in bp.putovanje
                                          where NazivPutovanja == put.naziv && item.rezervacija_FK == RezervacijaID
                                          select new
                                          {
                                              datumvrijeme_polaska = put.datumvrijeme_polaska,
                                              datumvrijeme_povratka = put.datumvrijeme_povratka,
                                              cijena = put.cijena,
                                              naziv = put.naziv
                                          }).ToList();
                    var putnik = (from putni in bp.putnik
                                  join reze in bp.rezervacija on putni.putnik_id equals reze.putnik_FK
                                  where RezervacijaID == reze.rezervacija_id && putni.putnik_id == reze.putnik_FK
                                  select new
                                  {
                                      ime = putni.ime,
                                      prezime = putni.prezime,
                                      kontakt = putni.kontakt
                                  }).ToList();
                    putnikBindingSource.DataSource = putnik;
                    zaposlenikBindingSource.DataSource = zaposlenik.ToList();
                    putovanjeBindingSource.DataSource = listaPutovanja.ToList();
                }
                var listaDodatnihAktivnosti = (from dodatne in bp.dodatna_aktivnost
                                               join pogled in bp.PogledRezervacijaDodatnihAktivnosti on dodatne.dodatna_aktivnost_id equals pogled.dodatne_aktivnosti_id
                                               where pogled.rezervacija_id == RezervacijaID
                                               select dodatne).ToList();
                dodatnaaktivnostBindingSource.DataSource = listaDodatnihAktivnosti.ToList();
            }
        }

        private void FormaRacun_Load(object sender, EventArgs e)
        {

            PrikaziRacun();
            this.reportRacun.RefreshReport();
        }
    }
}
