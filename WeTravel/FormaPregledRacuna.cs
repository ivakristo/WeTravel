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
    public partial class FormaPregledRacuna : Form
    {
        public FormaPregledRacuna()
        {
            InitializeComponent();
        }
        private void PrikaziRacune()
        {
            BindingList<racun> listaRacuna = null;
            using (var bp = new EntitiesWeTravel())
            {
                listaRacuna = new BindingList<racun>(bp.racun.ToList());
                var listaRacunaDetalji = (from rac in bp.racun
                                      join zap in bp.zaposlenik on rac.zaposlenik_FK equals zap.zaposlenik_id
                                      where rac.zaposlenik_FK == zap.zaposlenik_id
                                      select new
                                      {
                                          racun_id = rac.racun_id,
                                          zaposlenik_FK= zap.ime + " " + zap.prezime,
                                          datumvrijeme_izdavanja=rac.datumvrijeme_izdavanja,
                                          ukupna_cijena=rac.ukupna_cijena,
                                          rezervacija_FK=rac.rezervacija_FK
                                      });
                dataGridViewIzdaniRacuni.DataSource = listaRacunaDetalji.ToList();

            }
            racunBindingSource.DataSource = listaRacuna;
        }
        private void FormaPregledRacuna_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            PrikaziRacune();
        }

        private void buttonPregledRacuna_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewIzdaniRacuni.CurrentRow.Index;
            int rezervacijaID = int.Parse(dataGridViewIzdaniRacuni.Rows[rowindex].Cells[4].Value.ToString());
            using (var bp = new EntitiesWeTravel())
            {
                var putovanjeNaziv = (from put in bp.putovanje
                                      join rez in bp.rezervacija on put.putovanje_id equals rez.putovanje_FK
                                      where put.putovanje_id == rez.putovanje_FK && rez.rezervacija_id == rezervacijaID
                                      select put);
                string nazivPutovanja = "";
                foreach (var item in putovanjeNaziv)
                {
                    nazivPutovanja = item.naziv;
                }
                FormaRacun formaRacun = new FormaRacun(rezervacijaID, nazivPutovanja);
                formaRacun.ShowDialog();
            }
        }

        private void FormaPregledRacuna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm", HelpNavigator.Topic, "Pregled_izdanih_racuna.htm");
            }
        }
    }
}
