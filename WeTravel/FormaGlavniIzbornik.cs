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

        private void FormaGlavniIzbornik_Load(object sender, EventArgs e)
        {
            int razina = Sesija.RazinaPrava;
            if (razina != 1)
            {
                buttonKreirajKorisnickiRacun.Hide();
            }
            if(razina > 2)
            {
                buttonStatistika.Hide();
                button1.Hide();
            }
        }

        private void buttonOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaPrijava formaPrijava = new FormaPrijava();
            formaPrijava.ShowDialog();
            this.Close();
        }

        private void buttonKreirajKorisnickiRacun_Click(object sender, EventArgs e)
        {
            FormaAdministracijaRacuna formaAdminiRacun = new FormaAdministracijaRacuna();
            formaAdminiRacun.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaNoviRacun formaRacun = new FormaNoviRacun();
            formaRacun.ShowDialog();
        }

        private void buttonStatistika_Click(object sender, EventArgs e)
        {
            FormaStatistika formaStatistika = new FormaStatistika();
            formaStatistika.ShowDialog();
        }
    }
}
