using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using DB;
using Prijava;

namespace WeTravel
{
    public partial class FormNoviKorisnickiRacun : Form
    {

        private zaposlenik zaposlenikZaIzmjenu;
        public FormNoviKorisnickiRacun(zaposlenik zaposleni)
        {
            InitializeComponent();
            zaposlenikZaIzmjenu = zaposleni;
        }
        private void FormNoviKorisnickiRacun_Load(object sender, EventArgs e)
        {
            if (zaposlenikZaIzmjenu != null)
            {
                textBoxImeZaposlenika.Text = zaposlenikZaIzmjenu.ime;
                textBoxPrezimeZaposlenika.Text = zaposlenikZaIzmjenu.prezime;
                textBoxKorisnickoImeZaposlenik.Text = zaposlenikZaIzmjenu.korisnicko_ime;
                textBoxLozinkaZaposlenika.Text = zaposlenikZaIzmjenu.lozinka;
                textBoxRazinaPrava.Text = zaposlenikZaIzmjenu.razina_prava_FK.ToString();
                buttonSpremiUrediKorisnickiRacun.Text = "Uredi";
            }
        }

        private void buttonSpremiUrediKorisnickiRacun_Click(object sender, EventArgs e)
        {
            using(var bp=new EntitiesWeTravel())
            {
                if (zaposlenikZaIzmjenu == null)
                {
                    zaposlenik tmpZaposlenik = new zaposlenik
                    {
                        ime = textBoxImeZaposlenika.Text,
                        prezime = textBoxPrezimeZaposlenika.Text,
                        korisnicko_ime = textBoxKorisnickoImeZaposlenik.Text,
                        lozinka = textBoxLozinkaZaposlenika.Text,
                        kriptirana_lozinka = KriptiranjeLozinke.HashString(textBoxLozinkaZaposlenika.Text),
                        razina_prava_FK = int.Parse(textBoxRazinaPrava.Text)
                    };
                    bp.zaposlenik.Add(tmpZaposlenik);
                    bp.SaveChanges();
                }
                else
                {
                    bp.zaposlenik.Attach(zaposlenikZaIzmjenu);
                    zaposlenikZaIzmjenu.ime= textBoxImeZaposlenika.Text;
                    zaposlenikZaIzmjenu.prezime= textBoxPrezimeZaposlenika.Text;
                     zaposlenikZaIzmjenu.korisnicko_ime= textBoxKorisnickoImeZaposlenik.Text;
                    zaposlenikZaIzmjenu.lozinka= textBoxLozinkaZaposlenika.Text;
                    zaposlenikZaIzmjenu.razina_prava_FK=int.Parse(textBoxRazinaPrava.Text);
                    bp.SaveChanges();
                }
            }
            Close();
        }
    }
}
