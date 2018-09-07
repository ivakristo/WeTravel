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
    public partial class FormaStatistika : Form
    {
        public FormaStatistika()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda za prikaz putovanja koja su završena.
        /// </summary>
        private void PrikaziPutovanja()
        {
            BindingList<putovanje> listaPutovanja = null;
            BindingList<putovanje> listaZavrsenihPutovanja = new BindingList<putovanje>();
            using (var bp = new EntitiesWeTravel())
            {
                listaPutovanja = new BindingList<putovanje>(bp.putovanje.ToList());
                foreach (putovanje item in listaPutovanja)
                {
                    int rezultat = DateTime.Compare(item.datumvrijeme_povratka, DateTime.Now);
                    if (rezultat < 0)
                    {
                        listaZavrsenihPutovanja.Add(item);
                    }
                }
            }
            putovanjeBindingSource.DataSource = listaZavrsenihPutovanja;
        }
        /// <summary>
        /// Metoda koja vraća listu podataka koji su potrebni za prikaz statistike.
        /// </summary>
        /// <param name="put"></param>
        /// <returns></returns>
        private List<string> PrikaziStatistiku(putovanje put)
        {
            BindingList<rezervacija> listaRezervacija = null;
            BindingList<dodatna_aktivnost> listaDodatnihAktivnosti = null;
            using (var bp = new EntitiesWeTravel())
            {
                bp.putovanje.Attach(put);
                listaRezervacija = new BindingList<rezervacija>(put.rezervacija.ToList());
                listaDodatnihAktivnosti = new BindingList<dodatna_aktivnost>(put.dodatna_aktivnost.ToList());
            }
            List<string> listaStatistika = new List<string>();
            int brojRezervacija = listaRezervacija.Count();
            string brojOsoba = (brojRezervacija * put.broj_osoba).ToString();
            listaStatistika.Add(brojOsoba);
            foreach (var item in listaDodatnihAktivnosti)
            {
                listaStatistika.Add(item.naziv);
            }
            return listaStatistika;
        }
        private void FormaStatistika_Load(object sender, EventArgs e)
        {
            PrikaziPutovanja();
            this.KeyPreview = true;
        }

        private void dataGridViewStatistika_SelectionChanged(object sender, EventArgs e)
        {
            foreach (var series in chartStatistika.Series)
            {
                series.Points.Clear();
            }
            putovanje selektiranoPutovanje = putovanjeBindingSource.Current as putovanje;
            if (selektiranoPutovanje != null)
            {
                int brojac = 0;
                List<string> lista = PrikaziStatistiku(selektiranoPutovanje);
                chartStatistika.Series[0].LegendText = selektiranoPutovanje.naziv;
                foreach (var item in lista)
                {
                    if (brojac == 0)
                    {
                        chartStatistika.Series["Putovanje"].Points.AddXY("Broj osoba", item);
                    }
                    else
                    {
                        using (var bp = new EntitiesWeTravel())
                        {
                            int brojDodatnih = (from rezervacijaDodatne in bp.PogledRezervacijaDodatnihAktivnosti join dodatne in bp.dodatna_aktivnost on rezervacijaDodatne.dodatne_aktivnosti_id equals dodatne.dodatna_aktivnost_id where dodatne.naziv == item select rezervacijaDodatne.dodatne_aktivnosti_id).Count();
                            chartStatistika.Series["Putovanje"].Points.AddXY(item, brojDodatnih * selektiranoPutovanje.broj_osoba);
                        }
                    }
                    brojac++;
                }
                chartStatistika.DataSource = putovanjeBindingSource;
            }
        }
    }
}
