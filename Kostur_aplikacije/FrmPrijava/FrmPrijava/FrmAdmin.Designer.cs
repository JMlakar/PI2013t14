namespace FrmPrijava
{
    partial class FrmAdmin
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
            this.btnUsluge = new System.Windows.Forms.Button();
            this.btnCjenici = new System.Windows.Forms.Button();
            this.btnCRM = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnPostavkeRacuna = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsluge
            // 
            this.btnUsluge.Location = new System.Drawing.Point(191, 40);
            this.btnUsluge.Name = "btnUsluge";
            this.btnUsluge.Size = new System.Drawing.Size(152, 34);
            this.btnUsluge.TabIndex = 0;
            this.btnUsluge.Text = "Usluge";
            this.btnUsluge.UseVisualStyleBackColor = true;
            this.btnUsluge.Click += new System.EventHandler(this.btnUsluge_Click);
            // 
            // btnCjenici
            // 
            this.btnCjenici.Location = new System.Drawing.Point(191, 95);
            this.btnCjenici.Name = "btnCjenici";
            this.btnCjenici.Size = new System.Drawing.Size(152, 34);
            this.btnCjenici.TabIndex = 1;
            this.btnCjenici.Text = "Kreiraj cjenik";
            this.btnCjenici.UseVisualStyleBackColor = true;
            this.btnCjenici.Click += new System.EventHandler(this.btnCjenici_Click);
            // 
            // btnCRM
            // 
            this.btnCRM.Location = new System.Drawing.Point(191, 146);
            this.btnCRM.Name = "btnCRM";
            this.btnCRM.Size = new System.Drawing.Size(152, 34);
            this.btnCRM.TabIndex = 2;
            this.btnCRM.Text = "CRM";
            this.btnCRM.UseVisualStyleBackColor = true;
            this.btnCRM.Click += new System.EventHandler(this.btnCRM_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Location = new System.Drawing.Point(192, 200);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(152, 34);
            this.btnKorisnici.TabIndex = 3;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // btnPostavkeRacuna
            // 
            this.btnPostavkeRacuna.Location = new System.Drawing.Point(192, 256);
            this.btnPostavkeRacuna.Name = "btnPostavkeRacuna";
            this.btnPostavkeRacuna.Size = new System.Drawing.Size(152, 34);
            this.btnPostavkeRacuna.TabIndex = 4;
            this.btnPostavkeRacuna.Text = "Postavke računa";
            this.btnPostavkeRacuna.UseVisualStyleBackColor = true;
            this.btnPostavkeRacuna.Click += new System.EventHandler(this.btnPostavkeRacuna_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(192, 306);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(152, 34);
            this.btnOdjava.TabIndex = 5;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 370);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnPostavkeRacuna);
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.btnCRM);
            this.Controls.Add(this.btnCjenici);
            this.Controls.Add(this.btnUsluge);
            this.Name = "FrmAdmin";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsluge;
        private System.Windows.Forms.Button btnCjenici;
        private System.Windows.Forms.Button btnCRM;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnPostavkeRacuna;
        private System.Windows.Forms.Button btnOdjava;
    }
}