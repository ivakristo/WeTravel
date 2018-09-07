namespace WeTravel
{
    partial class FormaRacun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaRacun));
            this.putovanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodatnaaktivnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportRacun = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.putovanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaaktivnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // putovanjeBindingSource
            // 
            this.putovanjeBindingSource.DataSource = typeof(DB.putovanje);
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataSource = typeof(DB.racun);
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
            // reportRacun
            // 
            reportDataSource1.Name = "DataSetPutovanje";
            reportDataSource1.Value = this.putovanjeBindingSource;
            reportDataSource2.Name = "DataSetRacun";
            reportDataSource2.Value = this.racunBindingSource;
            reportDataSource3.Name = "DataSetDodatneAktivnosti";
            reportDataSource3.Value = this.dodatnaaktivnostBindingSource;
            reportDataSource4.Name = "DataSetPutnik";
            reportDataSource4.Value = this.putnikBindingSource;
            reportDataSource5.Name = "DataSetZaposlenik";
            reportDataSource5.Value = this.zaposlenikBindingSource;
            this.reportRacun.LocalReport.DataSources.Add(reportDataSource1);
            this.reportRacun.LocalReport.DataSources.Add(reportDataSource2);
            this.reportRacun.LocalReport.DataSources.Add(reportDataSource3);
            this.reportRacun.LocalReport.DataSources.Add(reportDataSource4);
            this.reportRacun.LocalReport.DataSources.Add(reportDataSource5);
            this.reportRacun.LocalReport.ReportEmbeddedResource = "WeTravel.Report1.rdlc";
            this.reportRacun.Location = new System.Drawing.Point(12, 12);
            this.reportRacun.Name = "reportRacun";
            this.reportRacun.ServerReport.BearerToken = null;
            this.reportRacun.Size = new System.Drawing.Size(716, 568);
            this.reportRacun.TabIndex = 0;
            // 
            // FormaRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 592);
            this.Controls.Add(this.reportRacun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaRacun";
            this.Text = "Racun";
            this.Load += new System.EventHandler(this.FormaRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.putovanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaaktivnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportRacun;
        private System.Windows.Forms.BindingSource putovanjeBindingSource;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.BindingSource putnikBindingSource;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.BindingSource dodatnaaktivnostBindingSource;
    }
}