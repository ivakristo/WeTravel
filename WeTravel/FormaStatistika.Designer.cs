namespace WeTravel
{
    partial class FormaStatistika
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaStatistika));
            this.dataGridViewStatistika = new System.Windows.Forms.DataGridView();
            this.putovanjeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemepolaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemepovratkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojosobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijevoznopoduzeceFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinacijaFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatnaaktivnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijevoznopoduzeceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putovanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartStatistika = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putovanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistika)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStatistika
            // 
            this.dataGridViewStatistika.AllowUserToAddRows = false;
            this.dataGridViewStatistika.AllowUserToDeleteRows = false;
            this.dataGridViewStatistika.AutoGenerateColumns = false;
            this.dataGridViewStatistika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.putovanjeidDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.datumvrijemepolaskaDataGridViewTextBoxColumn,
            this.datumvrijemepovratkaDataGridViewTextBoxColumn,
            this.brojosobaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.zaposlenikFKDataGridViewTextBoxColumn,
            this.prijevoznopoduzeceFKDataGridViewTextBoxColumn,
            this.destinacijaFKDataGridViewTextBoxColumn,
            this.destinacijaDataGridViewTextBoxColumn,
            this.dodatnaaktivnostDataGridViewTextBoxColumn,
            this.prijevoznopoduzeceDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.rezervacijaDataGridViewTextBoxColumn});
            this.dataGridViewStatistika.DataSource = this.putovanjeBindingSource;
            this.dataGridViewStatistika.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStatistika.Name = "dataGridViewStatistika";
            this.dataGridViewStatistika.ReadOnly = true;
            this.dataGridViewStatistika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStatistika.Size = new System.Drawing.Size(711, 144);
            this.dataGridViewStatistika.TabIndex = 1;
            this.dataGridViewStatistika.SelectionChanged += new System.EventHandler(this.dataGridViewStatistika_SelectionChanged);
            // 
            // putovanjeidDataGridViewTextBoxColumn
            // 
            this.putovanjeidDataGridViewTextBoxColumn.DataPropertyName = "putovanje_id";
            this.putovanjeidDataGridViewTextBoxColumn.HeaderText = "Putovanje ID";
            this.putovanjeidDataGridViewTextBoxColumn.Name = "putovanjeidDataGridViewTextBoxColumn";
            this.putovanjeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumvrijemepolaskaDataGridViewTextBoxColumn
            // 
            this.datumvrijemepolaskaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datumvrijemepolaskaDataGridViewTextBoxColumn.DataPropertyName = "datumvrijeme_polaska";
            this.datumvrijemepolaskaDataGridViewTextBoxColumn.HeaderText = "Datum i vrijeme polaska";
            this.datumvrijemepolaskaDataGridViewTextBoxColumn.Name = "datumvrijemepolaskaDataGridViewTextBoxColumn";
            this.datumvrijemepolaskaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumvrijemepolaskaDataGridViewTextBoxColumn.Width = 132;
            // 
            // datumvrijemepovratkaDataGridViewTextBoxColumn
            // 
            this.datumvrijemepovratkaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datumvrijemepovratkaDataGridViewTextBoxColumn.DataPropertyName = "datumvrijeme_povratka";
            this.datumvrijemepovratkaDataGridViewTextBoxColumn.HeaderText = "Datum i vrijeme povratka";
            this.datumvrijemepovratkaDataGridViewTextBoxColumn.Name = "datumvrijemepovratkaDataGridViewTextBoxColumn";
            this.datumvrijemepovratkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumvrijemepovratkaDataGridViewTextBoxColumn.Width = 136;
            // 
            // brojosobaDataGridViewTextBoxColumn
            // 
            this.brojosobaDataGridViewTextBoxColumn.DataPropertyName = "broj_osoba";
            this.brojosobaDataGridViewTextBoxColumn.HeaderText = "Broj osoba";
            this.brojosobaDataGridViewTextBoxColumn.Name = "brojosobaDataGridViewTextBoxColumn";
            this.brojosobaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaposlenikFKDataGridViewTextBoxColumn
            // 
            this.zaposlenikFKDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_FK";
            this.zaposlenikFKDataGridViewTextBoxColumn.HeaderText = "zaposlenik_FK";
            this.zaposlenikFKDataGridViewTextBoxColumn.Name = "zaposlenikFKDataGridViewTextBoxColumn";
            this.zaposlenikFKDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikFKDataGridViewTextBoxColumn.Visible = false;
            // 
            // prijevoznopoduzeceFKDataGridViewTextBoxColumn
            // 
            this.prijevoznopoduzeceFKDataGridViewTextBoxColumn.DataPropertyName = "prijevozno_poduzece_FK";
            this.prijevoznopoduzeceFKDataGridViewTextBoxColumn.HeaderText = "prijevozno_poduzece_FK";
            this.prijevoznopoduzeceFKDataGridViewTextBoxColumn.Name = "prijevoznopoduzeceFKDataGridViewTextBoxColumn";
            this.prijevoznopoduzeceFKDataGridViewTextBoxColumn.ReadOnly = true;
            this.prijevoznopoduzeceFKDataGridViewTextBoxColumn.Visible = false;
            // 
            // destinacijaFKDataGridViewTextBoxColumn
            // 
            this.destinacijaFKDataGridViewTextBoxColumn.DataPropertyName = "destinacija_FK";
            this.destinacijaFKDataGridViewTextBoxColumn.HeaderText = "destinacija_FK";
            this.destinacijaFKDataGridViewTextBoxColumn.Name = "destinacijaFKDataGridViewTextBoxColumn";
            this.destinacijaFKDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinacijaFKDataGridViewTextBoxColumn.Visible = false;
            // 
            // destinacijaDataGridViewTextBoxColumn
            // 
            this.destinacijaDataGridViewTextBoxColumn.DataPropertyName = "destinacija";
            this.destinacijaDataGridViewTextBoxColumn.HeaderText = "destinacija";
            this.destinacijaDataGridViewTextBoxColumn.Name = "destinacijaDataGridViewTextBoxColumn";
            this.destinacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dodatnaaktivnostDataGridViewTextBoxColumn
            // 
            this.dodatnaaktivnostDataGridViewTextBoxColumn.DataPropertyName = "dodatna_aktivnost";
            this.dodatnaaktivnostDataGridViewTextBoxColumn.HeaderText = "dodatna_aktivnost";
            this.dodatnaaktivnostDataGridViewTextBoxColumn.Name = "dodatnaaktivnostDataGridViewTextBoxColumn";
            this.dodatnaaktivnostDataGridViewTextBoxColumn.ReadOnly = true;
            this.dodatnaaktivnostDataGridViewTextBoxColumn.Visible = false;
            // 
            // prijevoznopoduzeceDataGridViewTextBoxColumn
            // 
            this.prijevoznopoduzeceDataGridViewTextBoxColumn.DataPropertyName = "prijevozno_poduzece";
            this.prijevoznopoduzeceDataGridViewTextBoxColumn.HeaderText = "prijevozno_poduzece";
            this.prijevoznopoduzeceDataGridViewTextBoxColumn.Name = "prijevoznopoduzeceDataGridViewTextBoxColumn";
            this.prijevoznopoduzeceDataGridViewTextBoxColumn.ReadOnly = true;
            this.prijevoznopoduzeceDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // rezervacijaDataGridViewTextBoxColumn
            // 
            this.rezervacijaDataGridViewTextBoxColumn.DataPropertyName = "rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.HeaderText = "rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.Name = "rezervacijaDataGridViewTextBoxColumn";
            this.rezervacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // putovanjeBindingSource
            // 
            this.putovanjeBindingSource.DataSource = typeof(DB.putovanje);
            // 
            // chartStatistika
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistika.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistika.Legends.Add(legend1);
            this.chartStatistika.Location = new System.Drawing.Point(31, 206);
            this.chartStatistika.Name = "chartStatistika";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Putovanje";
            this.chartStatistika.Series.Add(series1);
            this.chartStatistika.Size = new System.Drawing.Size(445, 302);
            this.chartStatistika.TabIndex = 1;
            this.chartStatistika.Text = "chart1";
            // 
            // FormaStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 559);
            this.Controls.Add(this.chartStatistika);
            this.Controls.Add(this.dataGridViewStatistika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaStatistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.FormaStatistika_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormaStatistika_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putovanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatistika;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistika;
        private System.Windows.Forms.BindingSource putovanjeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn putovanjeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemepolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemepovratkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojosobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijevoznopoduzeceFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinacijaFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatnaaktivnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijevoznopoduzeceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaDataGridViewTextBoxColumn;
    }
}