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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaNoviRacun));
            this.putovanjeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodatnaaktivnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewPutnik = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewRezervacijePutovanja = new System.Windows.Forms.DataGridView();
            this.rezervacijaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putovanjeFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putnikFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonIzdavanjeRacuna = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBoxPretrazivanjePutnika = new System.Windows.Forms.TextBox();
            this.labelPretrazivanjePutnika = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.putovanjeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaaktivnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPutnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacijePutovanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // putovanjeBindingSource1
            // 
            this.putovanjeBindingSource1.DataSource = typeof(DB.putovanje);
            // 
            // dodatnaaktivnostBindingSource
            // 
            this.dodatnaaktivnostBindingSource.DataSource = typeof(DB.dodatna_aktivnost);
            // 
            // putnikBindingSource
            // 
            this.putnikBindingSource.DataSource = typeof(DB.putnik);
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(DB.zaposlenik);
            // 
            // dataGridViewPutnik
            // 
            this.dataGridViewPutnik.AllowUserToAddRows = false;
            this.dataGridViewPutnik.AllowUserToDeleteRows = false;
            this.dataGridViewPutnik.AutoGenerateColumns = false;
            this.dataGridViewPutnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPutnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.rezervacijaDataGridViewTextBoxColumn});
            this.dataGridViewPutnik.DataSource = this.putnikBindingSource1;
            this.dataGridViewPutnik.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewPutnik.Name = "dataGridViewPutnik";
            this.dataGridViewPutnik.ReadOnly = true;
            this.dataGridViewPutnik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPutnik.Size = new System.Drawing.Size(543, 120);
            this.dataGridViewPutnik.TabIndex = 5;
            this.dataGridViewPutnik.SelectionChanged += new System.EventHandler(this.dataGridViewPutnik_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "putnik_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Putnik ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prezime";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "kontakt";
            this.dataGridViewTextBoxColumn7.HeaderText = "Kontakt";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // rezervacijaDataGridViewTextBoxColumn
            // 
            this.rezervacijaDataGridViewTextBoxColumn.DataPropertyName = "rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.HeaderText = "Rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.Name = "rezervacijaDataGridViewTextBoxColumn";
            this.rezervacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // putnikBindingSource1
            // 
            this.putnikBindingSource1.DataSource = typeof(DB.putnik);
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
            this.putnikFKDataGridViewTextBoxColumn});
            this.dataGridViewRezervacijePutovanja.DataSource = this.rezervacijaBindingSource;
            this.dataGridViewRezervacijePutovanja.Location = new System.Drawing.Point(12, 190);
            this.dataGridViewRezervacijePutovanja.Name = "dataGridViewRezervacijePutovanja";
            this.dataGridViewRezervacijePutovanja.ReadOnly = true;
            this.dataGridViewRezervacijePutovanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRezervacijePutovanja.Size = new System.Drawing.Size(343, 131);
            this.dataGridViewRezervacijePutovanja.TabIndex = 6;
            this.dataGridViewRezervacijePutovanja.SelectionChanged += new System.EventHandler(this.dataGridViewRezervacijePutovanja_SelectionChanged);
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
            this.putovanjeFKDataGridViewTextBoxColumn.DataPropertyName = "putovanje_FK";
            this.putovanjeFKDataGridViewTextBoxColumn.HeaderText = "Putovanje ID";
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
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataSource = typeof(DB.rezervacija);
            // 
            // buttonIzdavanjeRacuna
            // 
            this.buttonIzdavanjeRacuna.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonIzdavanjeRacuna.Location = new System.Drawing.Point(535, 290);
            this.buttonIzdavanjeRacuna.Name = "buttonIzdavanjeRacuna";
            this.buttonIzdavanjeRacuna.Size = new System.Drawing.Size(99, 31);
            this.buttonIzdavanjeRacuna.TabIndex = 7;
            this.buttonIzdavanjeRacuna.Text = "Novi račun";
            this.buttonIzdavanjeRacuna.UseVisualStyleBackColor = false;
            this.buttonIzdavanjeRacuna.Click += new System.EventHandler(this.buttonIzdavanjeRacuna_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPutovanje";
            reportDataSource1.Value = this.putovanjeBindingSource1;
            reportDataSource2.Name = "DataSetRacun";
            reportDataSource2.Value = this.racunBindingSource;
            reportDataSource3.Name = "DataSetDodatneAktivnosti";
            reportDataSource3.Value = this.dodatnaaktivnostBindingSource;
            reportDataSource4.Name = "DataSetPutnik";
            reportDataSource4.Value = this.putnikBindingSource;
            reportDataSource5.Name = "DataSetZaposlenik";
            reportDataSource5.Value = this.zaposlenikBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WeTravel.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 327);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(727, 451);
            this.reportViewer1.TabIndex = 8;
            // 
            // textBoxPretrazivanjePutnika
            // 
            this.textBoxPretrazivanjePutnika.Location = new System.Drawing.Point(12, 29);
            this.textBoxPretrazivanjePutnika.Name = "textBoxPretrazivanjePutnika";
            this.textBoxPretrazivanjePutnika.Size = new System.Drawing.Size(100, 20);
            this.textBoxPretrazivanjePutnika.TabIndex = 9;
            this.textBoxPretrazivanjePutnika.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPretrazivanjePutnika_KeyDown);
            // 
            // labelPretrazivanjePutnika
            // 
            this.labelPretrazivanjePutnika.AutoSize = true;
            this.labelPretrazivanjePutnika.Location = new System.Drawing.Point(9, 9);
            this.labelPretrazivanjePutnika.Name = "labelPretrazivanjePutnika";
            this.labelPretrazivanjePutnika.Size = new System.Drawing.Size(62, 13);
            this.labelPretrazivanjePutnika.TabIndex = 10;
            this.labelPretrazivanjePutnika.Text = "Ime putnika";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPrint.Location = new System.Drawing.Point(640, 290);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(99, 31);
            this.buttonPrint.TabIndex = 11;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // FormaNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 790);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelPretrazivanjePutnika);
            this.Controls.Add(this.textBoxPretrazivanjePutnika);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.buttonIzdavanjeRacuna);
            this.Controls.Add(this.dataGridViewRezervacijePutovanja);
            this.Controls.Add(this.dataGridViewPutnik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaNoviRacun";
            this.Text = "Izdavanje računa";
            this.Load += new System.EventHandler(this.FormaNoviRacun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormaNoviRacun_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.putovanjeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaaktivnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPutnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacijePutovanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPutnik;

        private System.Windows.Forms.DataGridView dataGridViewRezervacijePutovanja;
        private System.Windows.Forms.Button buttonIzdavanjeRacuna;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private System.Windows.Forms.BindingSource putnikBindingSource1;
        private System.Windows.Forms.BindingSource dodatnaaktivnostBindingSource;
        private System.Windows.Forms.BindingSource putovanjeBindingSource1;
        private System.Windows.Forms.BindingSource putnikBindingSource;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.TextBox textBoxPretrazivanjePutnika;
        private System.Windows.Forms.Label labelPretrazivanjePutnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn putovanjeFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn putnikFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonPrint;
    }
}