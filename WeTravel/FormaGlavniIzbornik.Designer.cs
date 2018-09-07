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
            this.buttonPregledRacuna = new System.Windows.Forms.Button();
            this.buttonStatistika = new System.Windows.Forms.Button();
            this.buttonIzdavanjeRacuna = new System.Windows.Forms.Button();
            this.buttonOdjava = new System.Windows.Forms.Button();
            this.buttonAdministracijaRacuna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPregledRacuna
            // 
            this.buttonPregledRacuna.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPregledRacuna.Location = new System.Drawing.Point(23, 229);
            this.buttonPregledRacuna.Name = "buttonPregledRacuna";
            this.buttonPregledRacuna.Size = new System.Drawing.Size(149, 46);
            this.buttonPregledRacuna.TabIndex = 9;
            this.buttonPregledRacuna.Text = "Pregled izdanih računa";
            this.buttonPregledRacuna.UseVisualStyleBackColor = false;
            this.buttonPregledRacuna.Click += new System.EventHandler(this.buttonPregledRacuna_Click);
            // 
            // buttonStatistika
            // 
            this.buttonStatistika.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonStatistika.Location = new System.Drawing.Point(23, 164);
            this.buttonStatistika.Name = "buttonStatistika";
            this.buttonStatistika.Size = new System.Drawing.Size(149, 46);
            this.buttonStatistika.TabIndex = 8;
            this.buttonStatistika.Text = "Statistika";
            this.buttonStatistika.UseVisualStyleBackColor = false;
            this.buttonStatistika.Click += new System.EventHandler(this.buttonStatistika_Click);
            // 
            // buttonIzdavanjeRacuna
            // 
            this.buttonIzdavanjeRacuna.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonIzdavanjeRacuna.Location = new System.Drawing.Point(23, 91);
            this.buttonIzdavanjeRacuna.Name = "buttonIzdavanjeRacuna";
            this.buttonIzdavanjeRacuna.Size = new System.Drawing.Size(149, 50);
            this.buttonIzdavanjeRacuna.TabIndex = 7;
            this.buttonIzdavanjeRacuna.Text = "Izdavanje računa";
            this.buttonIzdavanjeRacuna.UseVisualStyleBackColor = false;
            this.buttonIzdavanjeRacuna.Click += new System.EventHandler(this.buttonIzdavanjeRacuna_Click);
            // 
            // buttonOdjava
            // 
            this.buttonOdjava.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonOdjava.Location = new System.Drawing.Point(298, 20);
            this.buttonOdjava.Name = "buttonOdjava";
            this.buttonOdjava.Size = new System.Drawing.Size(90, 40);
            this.buttonOdjava.TabIndex = 6;
            this.buttonOdjava.Text = "Odjava";
            this.buttonOdjava.UseVisualStyleBackColor = false;
            this.buttonOdjava.Click += new System.EventHandler(this.buttonOdjava_Click);
            // 
            // buttonAdministracijaRacuna
            // 
            this.buttonAdministracijaRacuna.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAdministracijaRacuna.Location = new System.Drawing.Point(23, 20);
            this.buttonAdministracijaRacuna.Name = "buttonAdministracijaRacuna";
            this.buttonAdministracijaRacuna.Size = new System.Drawing.Size(149, 51);
            this.buttonAdministracijaRacuna.TabIndex = 5;
            this.buttonAdministracijaRacuna.Text = "Administracija korisničkih računa";
            this.buttonAdministracijaRacuna.UseVisualStyleBackColor = false;
            this.buttonAdministracijaRacuna.Click += new System.EventHandler(this.buttonAdministracijaRacuna_Click);
            // 
            // FormaGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 294);
            this.Controls.Add(this.buttonPregledRacuna);
            this.Controls.Add(this.buttonStatistika);
            this.Controls.Add(this.buttonIzdavanjeRacuna);
            this.Controls.Add(this.buttonOdjava);
            this.Controls.Add(this.buttonAdministracijaRacuna);
            this.Name = "FormaGlavniIzbornik";
            this.Text = "FormaGlavniIzbornik";
            this.Load += new System.EventHandler(this.FormaGlavniIzbornik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPregledRacuna;
        private System.Windows.Forms.Button buttonStatistika;
        private System.Windows.Forms.Button buttonIzdavanjeRacuna;
        private System.Windows.Forms.Button buttonOdjava;
        private System.Windows.Forms.Button buttonAdministracijaRacuna;
    }
}