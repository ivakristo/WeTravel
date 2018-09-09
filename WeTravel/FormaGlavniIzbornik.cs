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
            FormaPregledRacuna formaPregledRacuna = new FormaPregledRacuna();
            formaPregledRacuna.ShowDialog();
        }

        private void buttonStatistika_Click(object sender, EventArgs e)
        {
            FormaStatistika formaStatistika = new FormaStatistika();
            formaStatistika.ShowDialog();
        }

        private void buttonIzdavanjeRacuna_Click(object sender, EventArgs e)
        {
            FormaNoviRacun formaRacun = new FormaNoviRacun();
            formaRacun.ShowDialog();
        }

        private void buttonAdministracijaRacuna_Click(object sender, EventArgs e)
        {
            FormaAdministracijaRacuna formaAdminiRacun = new FormaAdministracijaRacuna();
            formaAdminiRacun.ShowDialog();
        }

        private void FormaGlavniIzbornik_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            int razina = Sesija.RazinaPrava;
            if (razina != 1)
            {
                buttonAdministracijaRacuna.Hide();
            }
            if (razina > 2)
            {
                buttonStatistika.Hide();
                buttonIzdavanjeRacuna.Hide();
                buttonPregledRacuna.Hide();
            }
        }

        private void FormaGlavniIzbornik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm", HelpNavigator.Topic, "Glavni_izbornik.htm");
            }
        }
    }
}
