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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportRacun = new Microsoft.Reporting.WinForms.ReportViewer();
            this.putovanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodatnaaktivnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.putovanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaaktivnostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportRacun
            // 
            reportDataSource6.Name = "DataSetPutovanje";
            reportDataSource6.Value = this.putovanjeBindingSource;
            reportDataSource7.Name = "DataSetRacun";
            reportDataSource7.Value = this.racunBindingSource;
            reportDataSource8.Name = "DataSetDodatneAktivnosti";
            reportDataSource8.Value = this.dodatnaaktivnostBindingSource;
            reportDataSource9.Name = "DataSetPutnik";
            reportDataSource9.Value = this.putnikBindingSource;
            reportDataSource10.Name = "DataSetZaposlenik";
            reportDataSource10.Value = this.zaposlenikBindingSource;
            this.reportRacun.LocalReport.DataSources.Add(reportDataSource6);
            this.reportRacun.LocalReport.DataSources.Add(reportDataSource7);
            this.reportRacun.LocalReport.DataSources.Add(reportDataSource8);
            this.reportRacun.LocalReport.DataSources.Add(reportDataSource9);
            this.reportRacun.LocalReport.DataSources.Add(reportDataSource10);
            this.reportRacun.LocalReport.ReportEmbeddedResource = "WeTravel.Report1.rdlc";
            this.reportRacun.Location = new System.Drawing.Point(12, 12);
            this.reportRacun.Name = "reportRacun";
            this.reportRacun.ServerReport.BearerToken = null;
            this.reportRacun.Size = new System.Drawing.Size(716, 568);
            this.reportRacun.TabIndex = 0;
            // 
            // putovanjeBindingSource
            // 
            this.putovanjeBindingSource.DataSource = typeof(DB.putovanje);
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataSource = typeof(DB.racun);
            // 
            // putnikBindingSource
            // 
            this.putnikBindingSource.DataSource = typeof(DB.putnik);
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(DB.zaposlenik);
            // 
            // dodatnaaktivnostBindingSource
            // 
            this.dodatnaaktivnostBindingSource.DataSource = typeof(DB.dodatna_aktivnost);
            // 
            // FormaRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 592);
            this.Controls.Add(this.reportRacun);
            this.Name = "FormaRacun";
            this.Text = "Racun";
            this.Load += new System.EventHandler(this.FormaRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.putovanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnaaktivnostBindingSource)).EndInit();
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