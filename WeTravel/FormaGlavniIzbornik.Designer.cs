namespace WeTravel
{
    partial class FormaGlavniIzbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaGlavniIzbornik));
            this.buttonKreirajKorisnickiRacun = new System.Windows.Forms.Button();
            this.buttonOdjava = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonStatistika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKreirajKorisnickiRacun
            // 
            this.buttonKreirajKorisnickiRacun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonKreirajKorisnickiRacun.Location = new System.Drawing.Point(22, 27);
            this.buttonKreirajKorisnickiRacun.Name = "buttonKreirajKorisnickiRacun";
            this.buttonKreirajKorisnickiRacun.Size = new System.Drawing.Size(149, 51);
            this.buttonKreirajKorisnickiRacun.TabIndex = 0;
            this.buttonKreirajKorisnickiRacun.Text = "Administracija korisničkih računa";
            this.buttonKreirajKorisnickiRacun.UseVisualStyleBackColor = false;
            this.buttonKreirajKorisnickiRacun.Click += new System.EventHandler(this.buttonKreirajKorisnickiRacun_Click);
            // 
            // buttonOdjava
            // 
            this.buttonOdjava.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonOdjava.Location = new System.Drawing.Point(297, 27);
            this.buttonOdjava.Name = "buttonOdjava";
            this.buttonOdjava.Size = new System.Drawing.Size(90, 40);
            this.buttonOdjava.TabIndex = 1;
            this.buttonOdjava.Text = "Odjava";
            this.buttonOdjava.UseVisualStyleBackColor = false;
            this.buttonOdjava.Click += new System.EventHandler(this.buttonOdjava_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(22, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Izdavanje računa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStatistika
            // 
            this.buttonStatistika.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonStatistika.Location = new System.Drawing.Point(22, 171);
            this.buttonStatistika.Name = "buttonStatistika";
            this.buttonStatistika.Size = new System.Drawing.Size(149, 46);
            this.buttonStatistika.TabIndex = 3;
            this.buttonStatistika.Text = "Statistika";
            this.buttonStatistika.UseVisualStyleBackColor = false;
            this.buttonStatistika.Click += new System.EventHandler(this.buttonStatistika_Click);
            // 
            // FormaGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 248);
            this.Controls.Add(this.buttonStatistika);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOdjava);
            this.Controls.Add(this.buttonKreirajKorisnickiRacun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaGlavniIzbornik";
            this.Text = "Glavni izbornik";
            this.Load += new System.EventHandler(this.FormaGlavniIzbornik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKreirajKorisnickiRacun;
        private System.Windows.Forms.Button buttonOdjava;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStatistika;
    }
}