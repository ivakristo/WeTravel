namespace WeTravel
{
    partial class FormaNoviRacun
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
            this.labelPretrazivanjePutnika = new System.Windows.Forms.Label();
            this.textBoxPretrazivanjePutnika = new System.Windows.Forms.TextBox();
            this.buttonIzdavanjeRacuna = new System.Windows.Forms.Button();
            this.dataGridViewRezervacijePutovanja = new System.Windows.Forms.DataGridView();
            this.dataGridViewPutnik = new System.Windows.Forms.DataGridView();
            this.putnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putovanjeFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putnikFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putovanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatnaaktivnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacijePutovanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPutnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPretrazivanjePutnika
            // 
            this.labelPretrazivanjePutnika.AutoSize = true;
            this.labelPretrazivanjePutnika.Location = new System.Drawing.Point(9, 17);
            this.labelPretrazivanjePutnika.Name = "labelPretrazivanjePutnika";
            this.labelPretrazivanjePutnika.Size = new System.Drawing.Size(62, 13);
            this.labelPretrazivanjePutnika.TabIndex = 15;
            this.labelPretrazivanjePutnika.Text = "Ime putnika";
            // 
            // textBoxPretrazivanjePutnika
            // 
            this.textBoxPretrazivanjePutnika.Location = new System.Drawing.Point(12, 37);
            this.textBoxPretrazivanjePutnika.Name = "textBoxPretrazivanjePutnika";
            this.textBoxPretrazivanjePutnika.Size = new System.Drawing.Size(108, 20);
            this.textBoxPretrazivanjePutnika.TabIndex = 14;
            this.textBoxPretrazivanjePutnika.TextChanged += new System.EventHandler(this.textBoxPretrazivanjePutnika_TextChanged);
            // 
            // buttonIzdavanjeRacuna
            // 
            this.buttonIzdavanjeRacuna.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonIzdavanjeRacuna.Location = new System.Drawing.Point(456, 331);
            this.buttonIzdavanjeRacuna.Name = "buttonIzdavanjeRacuna";
            this.buttonIzdavanjeRacuna.Size = new System.Drawing.Size(99, 31);
            this.buttonIzdavanjeRacuna.TabIndex = 13;
            this.buttonIzdavanjeRacuna.Text = "Račun";
            this.buttonIzdavanjeRacuna.UseVisualStyleBackColor = false;
            this.buttonIzdavanjeRacuna.Click += new System.EventHandler(this.buttonIzdavanjeRacuna_Click);
            // 
            // dataGridViewRezervacijePutovanja
            // 
            this.dataGridViewRezervacijePutovanja.AllowUserToAddRows = false;
            this.dataGridViewRezervacijePutovanja.AllowUserToDeleteRows = false;
            this.dataGridViewRezervacijePutovanja.AutoGenerateColumns = false;
            this.dataGridViewRezervacijePutovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervacijePutovanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervacijaidDataGridViewTextBoxColumn,
            this.putovanjeFKDataGridViewTextBoxColumn,
            this.putnikFKDataGridViewTextBoxColumn,
            this.putnikDataGridViewTextBoxColumn,
            this.putovanjeDataGridViewTextBoxColumn,
            this.racunDataGridViewTextBoxColumn,
            this.dodatnaaktivnostDataGridViewTextBoxColumn});
            this.dataGridViewRezervacijePutovanja.DataSource = this.rezervacijaBindingSource;
            this.dataGridViewRezervacijePutovanja.Location = new System.Drawing.Point(12, 231);
            this.dataGridViewRezervacijePutovanja.Name = "dataGridViewRezervacijePutovanja";
            this.dataGridViewRezervacijePutovanja.ReadOnly = true;
            this.dataGridViewRezervacijePutovanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRezervacijePutovanja.Size = new System.Drawing.Size(422, 131);
            this.dataGridViewRezervacijePutovanja.TabIndex = 12;
            // 
            // dataGridViewPutnik
            // 
            this.dataGridViewPutnik.AllowUserToAddRows = false;
            this.dataGridViewPutnik.AllowUserToDeleteRows = false;
            this.dataGridViewPutnik.AutoGenerateColumns = false;
            this.dataGridViewPutnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPutnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.putnikidDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn,
            this.rezervacijaDataGridViewTextBoxColumn});
            this.dataGridViewPutnik.DataSource = this.putnikBindingSource;
            this.dataGridViewPutnik.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewPutnik.Name = "dataGridViewPutnik";
            this.dataGridViewPutnik.ReadOnly = true;
            this.dataGridViewPutnik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPutnik.Size = new System.Drawing.Size(543, 162);
            this.dataGridViewPutnik.TabIndex = 11;
            this.dataGridViewPutnik.SelectionChanged += new System.EventHandler(this.dataGridViewPutnik_SelectionChanged);
            // 
            // putnikBindingSource
            // 
            this.putnikBindingSource.DataSource = typeof(DB.putnik);
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataSource = typeof(DB.rezervacija);
            // 
            // putnikidDataGridViewTextBoxColumn
            // 
            this.putnikidDataGridViewTextBoxColumn.DataPropertyName = "putnik_id";
            this.putnikidDataGridViewTextBoxColumn.HeaderText = "Putnik ID";
            this.putnikidDataGridViewTextBoxColumn.Name = "putnikidDataGridViewTextBoxColumn";
            this.putnikidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            this.kontaktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezervacijaDataGridViewTextBoxColumn
            // 
            this.rezervacijaDataGridViewTextBoxColumn.DataPropertyName = "rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.HeaderText = "rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.Name = "rezervacijaDataGridViewTextBoxColumn";
            this.rezervacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // rezervacijaidDataGridViewTextBoxColumn
            // 
            this.rezervacijaidDataGridViewTextBoxColumn.DataPropertyName = "rezervacija_id";
            this.rezervacijaidDataGridViewTextBoxColumn.HeaderText = "Rezervacija ID";
            this.rezervacijaidDataGridViewTextBoxColumn.Name = "rezervacijaidDataGridViewTextBoxColumn";
            this.rezervacijaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // putovanjeFKDataGridViewTextBoxColumn
            // 
            this.putovanjeFKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.putovanjeFKDataGridViewTextBoxColumn.DataPropertyName = "putovanje_FK";
            this.putovanjeFKDataGridViewTextBoxColumn.HeaderText = "Naziv putovanja";
            this.putovanjeFKDataGridViewTextBoxColumn.Name = "putovanjeFKDataGridViewTextBoxColumn";
            this.putovanjeFKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // putnikFKDataGridViewTextBoxColumn
            // 
            this.putnikFKDataGridViewTextBoxColumn.DataPropertyName = "putnik_FK";
            this.putnikFKDataGridViewTextBoxColumn.HeaderText = "Putnik ID";
            this.putnikFKDataGridViewTextBoxColumn.Name = "putnikFKDataGridViewTextBoxColumn";
            this.putnikFKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // putnikDataGridViewTextBoxColumn
            // 
            this.putnikDataGridViewTextBoxColumn.DataPropertyName = "putnik";
            this.putnikDataGridViewTextBoxColumn.HeaderText = "putnik";
            this.putnikDataGridViewTextBoxColumn.Name = "putnikDataGridViewTextBoxColumn";
            this.putnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.putnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // putovanjeDataGridViewTextBoxColumn
            // 
            this.putovanjeDataGridViewTextBoxColumn.DataPropertyName = "putovanje";
            this.putovanjeDataGridViewTextBoxColumn.HeaderText = "putovanje";
            this.putovanjeDataGridViewTextBoxColumn.Name = "putovanjeDataGridViewTextBoxColumn";
            this.putovanjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.putovanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // racunDataGridViewTextBoxColumn
            // 
            this.racunDataGridViewTextBoxColumn.DataPropertyName = "racun";
            this.racunDataGridViewTextBoxColumn.HeaderText = "racun";
            this.racunDataGridViewTextBoxColumn.Name = "racunDataGridViewTextBoxColumn";
            this.racunDataGridViewTextBoxColumn.ReadOnly = true;
            this.racunDataGridViewTextBoxColumn.Visible = false;
            // 
            // dodatnaaktivnostDataGridViewTextBoxColumn
            // 
            this.dodatnaaktivnostDataGridViewTextBoxColumn.DataPropertyName = "dodatna_aktivnost";
            this.dodatnaaktivnostDataGridViewTextBoxColumn.HeaderText = "dodatna_aktivnost";
            this.dodatnaaktivnostDataGridViewTextBoxColumn.Name = "dodatnaaktivnostDataGridViewTextBoxColumn";
            this.dodatnaaktivnostDataGridViewTextBoxColumn.ReadOnly = true;
            this.dodatnaaktivnostDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormaNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 375);
            this.Controls.Add(this.labelPretrazivanjePutnika);
            this.Controls.Add(this.textBoxPretrazivanjePutnika);
            this.Controls.Add(this.buttonIzdavanjeRacuna);
            this.Controls.Add(this.dataGridViewRezervacijePutovanja);
            this.Controls.Add(this.dataGridViewPutnik);
            this.Name = "FormaNoviRacun";
            this.Text = "Izdavanje računa";
            this.Load += new System.EventHandler(this.FormaNoviRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacijePutovanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPutnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPretrazivanjePutnika;
        private System.Windows.Forms.TextBox textBoxPretrazivanjePutnika;
        private System.Windows.Forms.Button buttonIzdavanjeRacuna;
        private System.Windows.Forms.DataGridView dataGridViewRezervacijePutovanja;
        private System.Windows.Forms.DataGridView dataGridViewPutnik;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn putnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource putnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn putovanjeFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn putnikFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn putnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn putovanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatnaaktivnostDataGridViewTextBoxColumn;
    }
}