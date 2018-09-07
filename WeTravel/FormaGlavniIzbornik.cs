using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeTravel
{
    public partial class FormaGlavniIzbornik : Form
    {
        public FormaGlavniIzbornik()
        {
            InitializeComponent();
        }

        private void buttonOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaPrijava formaPrijava = new FormaPrijava();
            formaPrijava.ShowDialog();
            this.Close();
        }

        private void buttonPregledRacuna_Click(object sender, EventArgs e)
        {

        }

        private void buttonStatistika_Click(object sender, EventArgs e)
        {

        }

        private void buttonIzdavanjeRacuna_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdministracijaRacuna_Click(object sender, EventArgs e)
        {
            FormaAdministracijaRacuna formaAdminiRacun = new FormaAdministracijaRacuna();
            formaAdminiRacun.ShowDialog();
        }

        private void FormaGlavniIzbornik_Load(object sender, EventArgs e)
        {
            int razina = Sesija.RazinaPrava;
            if (razina != 1)
            {
                buttonAdministracijaRacuna.Hide();
            }
            if (razina > 2)
            {
                buttonStatistika.Hide();
                buttonIzdavanjeRacuna.Hide();
            }
        }
    }
}
