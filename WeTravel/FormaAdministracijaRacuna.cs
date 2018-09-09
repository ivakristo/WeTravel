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
using System.IO;

namespace WeTravel
{
    public partial class FormaAdministracijaRacuna : Form
    {
        public FormaAdministracijaRacuna()
        {
            InitializeComponent();
        }

        private void PrikaziZaposlenike()
        {
            BindingList<zaposlenik> listaZaposlenika = null;
            using (var bp = new EntitiesWeTravel())
            {
                listaZaposlenika = new BindingList<zaposlenik>(bp.zaposlenik.ToList());
            }
            zaposlenikBindingSource.DataSource = listaZaposlenika;
        }
        private void FormaAdministracijaRacuna_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            PrikaziZaposlenike();
        }

        private void buttonPromjenaStatusa_Click(object sender, EventArgs e)
        {
            zaposlenik selektiraniZaposlenik = zaposlenikBindingSource.Current as zaposlenik;
            if (selektiraniZaposlenik != null)
            {

                using (var bp = new EntitiesWeTravel())
                {
                    if (selektiraniZaposlenik.status == 1)
                    {
                        bp.zaposlenik.Attach(selektiraniZaposlenik);
                        selektiraniZaposlenik.status = 0;
                        MessageBox.Show("Korisnički račun blokiran!", "Korisnički račun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bp.SaveChanges();
                    }
                    else
                    {
                        bp.zaposlenik.Attach(selektiraniZaposlenik);
                        selektiraniZaposlenik.status = 1;
                        MessageBox.Show("Korisnički račun aktivan!", "Korisnički račun", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        bp.SaveChanges();
                    }

                }
            }
            PrikaziZaposlenike();
        }

        private void buttonNoviKorisnickiRacun_Click(object sender, EventArgs e)
        {
            zaposlenik selektiraniZaposlenik = null;
            FormaNoviKorisnickiRacun formaNoviKorRac = new FormaNoviKorisnickiRacun(selektiraniZaposlenik);
            formaNoviKorRac.ShowDialog();
            PrikaziZaposlenike();
            textBoxPretrazivanjeZaposlenika.Clear();
        }

        private void buttonUrediKorisnickiRacun_Click(object sender, EventArgs e)
        {
            zaposlenik selektiraniZaposlenik = zaposlenikBindingSource.Current as zaposlenik;
            if (selektiraniZaposlenik != null)
            {
                FormaNoviKorisnickiRacun formaNoviKorRac = new FormaNoviKorisnickiRacun(selektiraniZaposlenik);
                formaNoviKorRac.ShowDialog();
                PrikaziZaposlenike();
            }
            textBoxPretrazivanjeZaposlenika.Clear();
        }

        private void FormaAdministracijaRacuna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm", HelpNavigator.Topic, "Administracija_korisnika.htm");
            }
        }

        private void textBoxPretrazivanjeZaposlenika_TextChanged(object sender, EventArgs e)
        {
            string pretrazivanjeIme = textBoxPretrazivanjeZaposlenika.Text;
            if (string.IsNullOrEmpty(pretrazivanjeIme))
            {
                PrikaziZaposlenike();
            }
            else
            {
                BindingList<zaposlenik> listaZaposlenika = null;
                using (var bp = new EntitiesWeTravel())
                {
                    listaZaposlenika = new BindingList<zaposlenik>(bp.zaposlenik.Where(imeZaposlenika => imeZaposlenika.ime.Contains(pretrazivanjeIme)).ToList());
                }
                zaposlenikBindingSource.DataSource = listaZaposlenika;
            }
        }
    }
}
