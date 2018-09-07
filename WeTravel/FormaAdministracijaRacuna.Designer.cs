namespace WeTravel
{
    partial class FormaAdministracijaRacuna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewPrikazZaposlenika = new System.Windows.Forms.DataGridView();
            this.zaposlenikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kriptiranalozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razinapravaFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putovanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razinapravaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPromjenaStatusa = new System.Windows.Forms.Button();
            this.buttonUrediKorisnickiRacun = new System.Windows.Forms.Button();
            this.buttonNoviKorisnickiRacun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikazZaposlenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrikazZaposlenika
            // 
            this.dataGridViewPrikazZaposlenika.AllowUserToAddRows = false;
            this.dataGridViewPrikazZaposlenika.AllowUserToDeleteRows = false;
            this.dataGridViewPrikazZaposlenika.AutoGenerateColumns = false;
            this.dataGridViewPrikazZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrikazZaposlenika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zaposlenikidDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.kriptiranalozinkaDataGridViewTextBoxColumn,
            this.razinapravaFKDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.prijavaDataGridViewTextBoxColumn,
            this.putovanjeDataGridViewTextBoxColumn,
            this.razinapravaDataGridViewTextBoxColumn});
            this.dataGridViewPrikazZaposlenika.DataSource = this.zaposlenikBindingSource;
            this.dataGridViewPrikazZaposlenika.Location = new System.Drawing.Point(27, 93);
            this.dataGridViewPrikazZaposlenika.Name = "dataGridViewPrikazZaposlenika";
            this.dataGridViewPrikazZaposlenika.ReadOnly = true;
            this.dataGridViewPrikazZaposlenika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrikazZaposlenika.Size = new System.Drawing.Size(763, 231);
            this.dataGridViewPrikazZaposlenika.TabIndex = 8;
            // 
            // zaposlenikidDataGridViewTextBoxColumn
            // 
            this.zaposlenikidDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.HeaderText = "Zaposlenik ID";
            this.zaposlenikidDataGridViewTextBoxColumn.Name = "zaposlenikidDataGridViewTextBoxColumn";
            this.zaposlenikidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            this.korisnickoimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lozinkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // kriptiranalozinkaDataGridViewTextBoxColumn
            // 
            this.kriptiranalozinkaDataGridViewTextBoxColumn.DataPropertyName = "kriptirana_lozinka";
            this.kriptiranalozinkaDataGridViewTextBoxColumn.HeaderText = "Kriptirana lozinka";
            this.kriptiranalozinkaDataGridViewTextBoxColumn.Name = "kriptiranalozinkaDataGridViewTextBoxColumn";
            this.kriptiranalozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razinapravaFKDataGridViewTextBoxColumn
            // 
            this.razinapravaFKDataGridViewTextBoxColumn.DataPropertyName = "razina_prava_FK";
            this.razinapravaFKDataGridViewTextBoxColumn.HeaderText = "Razina prava";
            this.razinapravaFKDataGridViewTextBoxColumn.Name = "razinapravaFKDataGridViewTextBoxColumn";
            this.razinapravaFKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prijavaDataGridViewTextBoxColumn
            // 
            this.prijavaDataGridViewTextBoxColumn.DataPropertyName = "prijava";
            this.prijavaDataGridViewTextBoxColumn.HeaderText = "prijava";
            this.prijavaDataGridViewTextBoxColumn.Name = "prijavaDataGridViewTextBoxColumn";
            this.prijavaDataGridViewTextBoxColumn.ReadOnly = true;
            this.prijavaDataGridViewTextBoxColumn.Visible = false;
            // 
            // putovanjeDataGridViewTextBoxColumn
            // 
            this.putovanjeDataGridViewTextBoxColumn.DataPropertyName = "putovanje";
            this.putovanjeDataGridViewTextBoxColumn.HeaderText = "putovanje";
            this.putovanjeDataGridViewTextBoxColumn.Name = "putovanjeDataGridViewTextBoxColumn";
            this.putovanjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.putovanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // razinapravaDataGridViewTextBoxColumn
            // 
            this.razinapravaDataGridViewTextBoxColumn.DataPropertyName = "razina_prava";
            this.razinapravaDataGridViewTextBoxColumn.HeaderText = "razina_prava";
            this.razinapravaDataGridViewTextBoxColumn.Name = "razinapravaDataGridViewTextBoxColumn";
            this.razinapravaDataGridViewTextBoxColumn.ReadOnly = true;
            this.razinapravaDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(DB.zaposlenik);
            // 
            // buttonPromjenaStatusa
            // 
            this.buttonPromjenaStatusa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPromjenaStatusa.Location = new System.Drawing.Point(221, 25);
            this.buttonPromjenaStatusa.Name = "buttonPromjenaStatusa";
            this.buttonPromjenaStatusa.Size = new System.Drawing.Size(109, 44);
            this.buttonPromjenaStatusa.TabIndex = 7;
            this.buttonPromjenaStatusa.Text = "Promijeni status korisničkog računa";
            this.buttonPromjenaStatusa.UseVisualStyleBackColor = false;
            this.buttonPromjenaStatusa.Click += new System.EventHandler(this.buttonPromjenaStatusa_Click);
            // 
            // buttonUrediKorisnickiRacun
            // 
            this.buttonUrediKorisnickiRacun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonUrediKorisnickiRacun.Location = new System.Drawing.Point(124, 25);
            this.buttonUrediKorisnickiRacun.Name = "buttonUrediKorisnickiRacun";
            this.buttonUrediKorisnickiRacun.Size = new System.Drawing.Size(91, 44);
            this.buttonUrediKorisnickiRacun.TabIndex = 6;
            this.buttonUrediKorisnickiRacun.Text = "Uredi korisnički račun";
            this.buttonUrediKorisnickiRacun.UseVisualStyleBackColor = false;
            this.buttonUrediKorisnickiRacun.Click += new System.EventHandler(this.buttonUrediKorisnickiRacun_Click);
            // 
            // buttonNoviKorisnickiRacun
            // 
            this.buttonNoviKorisnickiRacun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNoviKorisnickiRacun.Location = new System.Drawing.Point(27, 25);
            this.buttonNoviKorisnickiRacun.Name = "buttonNoviKorisnickiRacun";
            this.buttonNoviKorisnickiRacun.Size = new System.Drawing.Size(91, 44);
            this.buttonNoviKorisnickiRacun.TabIndex = 5;
            this.buttonNoviKorisnickiRacun.Text = "Novi korisnički račun";
            this.buttonNoviKorisnickiRacun.UseVisualStyleBackColor = false;
            this.buttonNoviKorisnickiRacun.Click += new System.EventHandler(this.buttonNoviKorisnickiRacun_Click);
            // 
            // FormaAdministracijaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 348);
            this.Controls.Add(this.dataGridViewPrikazZaposlenika);
            this.Controls.Add(this.buttonPromjenaStatusa);
            this.Controls.Add(this.buttonUrediKorisnickiRacun);
            this.Controls.Add(this.buttonNoviKorisnickiRacun);
            this.Name = "FormaAdministracijaRacuna";
            this.Text = "Administracija korisničkih računa";
            this.Load += new System.EventHandler(this.FormaAdministracijaRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikazZaposlenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrikazZaposlenika;
        private System.Windows.Forms.Button buttonPromjenaStatusa;
        private System.Windows.Forms.Button buttonUrediKorisnickiRacun;
        private System.Windows.Forms.Button buttonNoviKorisnickiRacun;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kriptiranalozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razinapravaFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn putovanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razinapravaDataGridViewTextBoxColumn;
    }
}