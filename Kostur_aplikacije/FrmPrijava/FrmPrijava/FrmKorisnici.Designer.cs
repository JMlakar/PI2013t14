namespace FrmPrijava
{
    partial class FrmKorisnici
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
            this.dgvPregledKorisnika = new System.Windows.Forms.DataGridView();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chboxKorisnik = new System.Windows.Forms.CheckBox();
            this.chboxAdministrator = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledKorisnika)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledKorisnika
            // 
            this.dgvPregledKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledKorisnika.Location = new System.Drawing.Point(43, 14);
            this.dgvPregledKorisnika.Name = "dgvPregledKorisnika";
            this.dgvPregledKorisnika.Size = new System.Drawing.Size(472, 90);
            this.dgvPregledKorisnika.TabIndex = 16;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(338, 199);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(121, 20);
            this.btnUnesi.TabIndex = 14;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(131, 120);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(152, 20);
            this.txtIme.TabIndex = 17;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(131, 146);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(152, 20);
            this.txtPrezime.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Korisničko ime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Lozinka";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(131, 199);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(152, 20);
            this.txtLozinka.TabIndex = 24;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(131, 172);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(152, 20);
            this.txtKorisnickoIme.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tip korisnika";
            // 
            // chboxKorisnik
            // 
            this.chboxKorisnik.AutoSize = true;
            this.chboxKorisnik.Location = new System.Drawing.Point(338, 149);
            this.chboxKorisnik.Name = "chboxKorisnik";
            this.chboxKorisnik.Size = new System.Drawing.Size(63, 17);
            this.chboxKorisnik.TabIndex = 27;
            this.chboxKorisnik.Text = "Korisnik";
            this.chboxKorisnik.UseVisualStyleBackColor = true;
            // 
            // chboxAdministrator
            // 
            this.chboxAdministrator.AutoSize = true;
            this.chboxAdministrator.Location = new System.Drawing.Point(407, 149);
            this.chboxAdministrator.Name = "chboxAdministrator";
            this.chboxAdministrator.Size = new System.Drawing.Size(86, 17);
            this.chboxAdministrator.TabIndex = 28;
            this.chboxAdministrator.Text = "Administrator";
            this.chboxAdministrator.UseVisualStyleBackColor = true;
            // 
            // FrmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 244);
            this.Controls.Add(this.chboxAdministrator);
            this.Controls.Add(this.chboxKorisnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.dgvPregledKorisnika);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label1);
            this.Name = "FrmKorisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnici";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledKorisnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledKorisnika;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chboxKorisnik;
        private System.Windows.Forms.CheckBox chboxAdministrator;


    }
}