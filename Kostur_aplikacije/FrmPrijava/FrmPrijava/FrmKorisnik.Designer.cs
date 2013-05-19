namespace FrmPrijava
{
    partial class FrmKorisnik
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
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnNoviRacun = new System.Windows.Forms.Button();
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnPregledObavijesti = new System.Windows.Forms.Button();
            this.btnPregledCjenika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(190, 249);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(152, 34);
            this.btnOdjava.TabIndex = 11;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnNoviRacun
            // 
            this.btnNoviRacun.Location = new System.Drawing.Point(191, 195);
            this.btnNoviRacun.Name = "btnNoviRacun";
            this.btnNoviRacun.Size = new System.Drawing.Size(152, 34);
            this.btnNoviRacun.TabIndex = 9;
            this.btnNoviRacun.Text = "Novi račun";
            this.btnNoviRacun.UseVisualStyleBackColor = true;
            this.btnNoviRacun.Click += new System.EventHandler(this.btnNoviRacun_Click);
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.Location = new System.Drawing.Point(190, 141);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(152, 34);
            this.btnKlijenti.TabIndex = 8;
            this.btnKlijenti.Text = "Unos klijenta";
            this.btnKlijenti.UseVisualStyleBackColor = true;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            // 
            // btnPregledObavijesti
            // 
            this.btnPregledObavijesti.Location = new System.Drawing.Point(190, 90);
            this.btnPregledObavijesti.Name = "btnPregledObavijesti";
            this.btnPregledObavijesti.Size = new System.Drawing.Size(152, 34);
            this.btnPregledObavijesti.TabIndex = 7;
            this.btnPregledObavijesti.Text = "Pregled obavijesti";
            this.btnPregledObavijesti.UseVisualStyleBackColor = true;
            this.btnPregledObavijesti.Click += new System.EventHandler(this.btnPregledObavijesti_Click);
            // 
            // btnPregledCjenika
            // 
            this.btnPregledCjenika.Location = new System.Drawing.Point(190, 35);
            this.btnPregledCjenika.Name = "btnPregledCjenika";
            this.btnPregledCjenika.Size = new System.Drawing.Size(152, 34);
            this.btnPregledCjenika.TabIndex = 6;
            this.btnPregledCjenika.Text = "Pregled cjenika";
            this.btnPregledCjenika.UseVisualStyleBackColor = true;
            this.btnPregledCjenika.Click += new System.EventHandler(this.btnPregledCjenika_Click);
            // 
            // FrmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 320);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnNoviRacun);
            this.Controls.Add(this.btnKlijenti);
            this.Controls.Add(this.btnPregledObavijesti);
            this.Controls.Add(this.btnPregledCjenika);
            this.Name = "FrmKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisničko sučelje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnNoviRacun;
        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnPregledObavijesti;
        private System.Windows.Forms.Button btnPregledCjenika;
    }
}