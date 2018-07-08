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
        /// <summary>
        /// Metoda za prikaz svih zaposlenika (korisničkih računa)
        /// </summary>
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

        private void buttonUrediKorisnickiRacun_Click(object sender, EventArgs e)
        {
            zaposlenik selektiraniZaposlenik = zaposlenikBindingSource.Current as zaposlenik;
            if (selektiraniZaposlenik != null)
            {
                FormNoviKorisnickiRacun formaNoviKorRac = new FormNoviKorisnickiRacun(selektiraniZaposlenik);
                formaNoviKorRac.ShowDialog();
                PrikaziZaposlenike();
            }
        }

        private void buttonNoviKorisnickiRacun_Click(object sender, EventArgs e)
        {
            zaposlenik selektiraniZaposlenik = null;
            FormNoviKorisnickiRacun formaNoviKorRac = new FormNoviKorisnickiRacun(selektiraniZaposlenik);
            formaNoviKorRac.ShowDialog();
            PrikaziZaposlenike();
        }
        /// <summary>
        /// Metoda za brisanje korisničkog računa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonObrisiKorisnickiRacun_Click(object sender, EventArgs e)
        {
            zaposlenik selektiraniZaposlenik = zaposlenikBindingSource.Current as zaposlenik;
            if (selektiraniZaposlenik != null)
            {
                DialogResult odabirBrisanje = MessageBox.Show("Jeste li sigurni da želite izbrisati korisnički račun?", "Korisnički račun", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (odabirBrisanje == DialogResult.Yes)
                {
                    using (var bp = new EntitiesWeTravel())
                    {
                        bp.zaposlenik.Attach(selektiraniZaposlenik);
                        bp.zaposlenik.Remove(selektiraniZaposlenik);
                        bp.SaveChanges();
                        MessageBox.Show("Korisnički račun obrisan!", "Korisnički račun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            PrikaziZaposlenike();
        }

        private void FormaAdministracijaRacuna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm", HelpNavigator.Topic, "Administracija_korisnika.htm");
            }
        }
    }
}
