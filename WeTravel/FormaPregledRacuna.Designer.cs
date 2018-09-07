namespace WeTravel
{
    partial class FormaPregledRacuna
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
            this.buttonPregledRacuna = new System.Windows.Forms.Button();
            this.dataGridViewIzdaniRacuni = new System.Windows.Forms.DataGridView();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIzdaniRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPregledRacuna
            // 
            this.buttonPregledRacuna.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPregledRacuna.Location = new System.Drawing.Point(8, 206);
            this.buttonPregledRacuna.Name = "buttonPregledRacuna";
            this.buttonPregledRacuna.Size = new System.Drawing.Size(100, 28);
            this.buttonPregledRacuna.TabIndex = 3;
            this.buttonPregledRacuna.Text = "Pregled računa";
            this.buttonPregledRacuna.UseVisualStyleBackColor = false;
            this.buttonPregledRacuna.Click += new System.EventHandler(this.buttonPregledRacuna_Click);
            // 
            // dataGridViewIzdaniRacuni
            // 
            this.dataGridViewIzdaniRacuni.AutoGenerateColumns = false;
            this.dataGridViewIzdaniRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIzdaniRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.racunidDataGridViewTextBoxColumn,
            this.zaposlenikFKDataGridViewTextBoxColumn,
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn,
            this.ukupnacijenaDataGridViewTextBoxColumn,
            this.rezervacijaFKDataGridViewTextBoxColumn,
            this.rezervacijaDataGridViewTextBoxColumn});
            this.dataGridViewIzdaniRacuni.DataSource = this.racunBindingSource;
            this.dataGridViewIzdaniRacuni.Location = new System.Drawing.Point(8, 18);
            this.dataGridViewIzdaniRacuni.Name = "dataGridViewIzdaniRacuni";
            this.dataGridViewIzdaniRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIzdaniRacuni.Size = new System.Drawing.Size(600, 171);
            this.dataGridViewIzdaniRacuni.TabIndex = 2;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataSource = typeof(DB.racun);
            // 
            // racunidDataGridViewTextBoxColumn
            // 
            this.racunidDataGridViewTextBoxColumn.DataPropertyName = "racun_id";
            this.racunidDataGridViewTextBoxColumn.HeaderText = "Racun ID";
            this.racunidDataGridViewTextBoxColumn.Name = "racunidDataGridViewTextBoxColumn";
            // 
            // zaposlenikFKDataGridViewTextBoxColumn
            // 
            this.zaposlenikFKDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_FK";
            this.zaposlenikFKDataGridViewTextBoxColumn.HeaderText = "Zaposlenik ID";
            this.zaposlenikFKDataGridViewTextBoxColumn.Name = "zaposlenikFKDataGridViewTextBoxColumn";
            // 
            // datumvrijemeizdavanjaDataGridViewTextBoxColumn
            // 
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn.DataPropertyName = "datumvrijeme_izdavanja";
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn.HeaderText = "Datum i virjeme izdavanja";
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn.Name = "datumvrijemeizdavanjaDataGridViewTextBoxColumn";
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn.Width = 139;
            // 
            // ukupnacijenaDataGridViewTextBoxColumn
            // 
            this.ukupnacijenaDataGridViewTextBoxColumn.DataPropertyName = "ukupna_cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.Name = "ukupnacijenaDataGridViewTextBoxColumn";
            // 
            // rezervacijaFKDataGridViewTextBoxColumn
            // 
            this.rezervacijaFKDataGridViewTextBoxColumn.DataPropertyName = "rezervacija_FK";
            this.rezervacijaFKDataGridViewTextBoxColumn.HeaderText = "Rezervacija ID";
            this.rezervacijaFKDataGridViewTextBoxColumn.Name = "rezervacijaFKDataGridViewTextBoxColumn";
            // 
            // rezervacijaDataGridViewTextBoxColumn
            // 
            this.rezervacijaDataGridViewTextBoxColumn.DataPropertyName = "rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.HeaderText = "rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.Name = "rezervacijaDataGridViewTextBoxColumn";
            this.rezervacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormaPregledRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 253);
            this.Controls.Add(this.buttonPregledRacuna);
            this.Controls.Add(this.dataGridViewIzdaniRacuni);
            this.Name = "FormaPregledRacuna";
            this.Text = "Pregled izdanih računa";
            this.Load += new System.EventHandler(this.FormaPregledRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIzdaniRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPregledRacuna;
        private System.Windows.Forms.DataGridView dataGridViewIzdaniRacuni;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemeizdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaDataGridViewTextBoxColumn;
    }
}