using DB;
using Kriptiranje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeTravel
{
    public partial class FormaPrijava : Form
    {
        public FormaPrijava()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Validacija korisničkog unosa za prijavu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            string kriptiranaLozinka = KriptiranjeLozinke.HashString(textBoxLozinka.Text);
            BindingList<zaposlenik> listaZaposlenik = null;
            int brojac = 0;
            using (var bp = new EntitiesWeTravel())
            {
                listaZaposlenik = new BindingList<zaposlenik>(bp.zaposlenik.ToList());
            }
            foreach (var zaposlenik in listaZaposlenik)
            {

                if (kriptiranaLozinka == zaposlenik.kriptirana_lozinka && textBoxKorisnickoIme.Text == zaposlenik.korisnicko_ime && zaposlenik.status > 0)
                {
                    Sesija tmpSesija = new Sesija(zaposlenik.korisnicko_ime, zaposlenik.razina_prava_FK, zaposlenik.zaposlenik_id);
                    brojac++;
                }

            }
            if (brojac == 1)
            {
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Neispravno korisničko ime ili lozinka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormaPrijava_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        /// <summary>
        /// Otvaranje "Pomoći" pritiskom na tipku F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormaPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm", HelpNavigator.Topic, "Prijava.htm");
            }
        }
        /// <summary>
        /// Pritisak gumba buttonPrijava na pritisak tipke Enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonPrijava_Click(this, new EventArgs());
            }
        }

        private void textBoxLozinka_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
