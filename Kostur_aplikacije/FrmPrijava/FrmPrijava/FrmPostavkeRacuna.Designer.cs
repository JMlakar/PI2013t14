namespace FrmPrijava
{
    partial class FrmPostavkeRacuna
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNazivPoduzeca = new System.Windows.Forms.TextBox();
            this.txtOIBPoduzeca = new System.Windows.Forms.TextBox();
            this.btnPrimjeni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv poduzeća";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "OIB poduzeća";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PDV";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Primjeni";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNazivPoduzeca
            // 
            this.txtNazivPoduzeca.Location = new System.Drawing.Point(157, 28);
            this.txtNazivPoduzeca.Name = "txtNazivPoduzeca";
            this.txtNazivPoduzeca.Size = new System.Drawing.Size(152, 20);
            this.txtNazivPoduzeca.TabIndex = 18;
            // 
            // txtOIBPoduzeca
            // 
            this.txtOIBPoduzeca.Location = new System.Drawing.Point(157, 60);
            this.txtOIBPoduzeca.Name = "txtOIBPoduzeca";
            this.txtOIBPoduzeca.Size = new System.Drawing.Size(152, 20);
            this.txtOIBPoduzeca.TabIndex = 19;
            // 
            // btnPrimjeni
            // 
            this.btnPrimjeni.Location = new System.Drawing.Point(157, 95);
            this.btnPrimjeni.Name = "btnPrimjeni";
            this.btnPrimjeni.Size = new System.Drawing.Size(152, 20);
            this.btnPrimjeni.TabIndex = 20;
            // 
            // FrmPostavkeRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 195);
            this.Controls.Add(this.btnPrimjeni);
            this.Controls.Add(this.txtOIBPoduzeca);
            this.Controls.Add(this.txtNazivPoduzeca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPostavkeRacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postavke računa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNazivPoduzeca;
        private System.Windows.Forms.TextBox txtOIBPoduzeca;
        private System.Windows.Forms.TextBox btnPrimjeni;
    }
}