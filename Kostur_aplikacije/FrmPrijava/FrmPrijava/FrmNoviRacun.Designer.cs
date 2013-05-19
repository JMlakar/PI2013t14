namespace FrmPrijava
{
    partial class FrmNoviRacun
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
            this.dgvPregledStavki = new System.Windows.Forms.DataGridView();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.txtOpisPopusta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chboxR1 = new System.Windows.Forms.CheckBox();
            this.chboxNormalni = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledStavki)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledStavki
            // 
            this.dgvPregledStavki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledStavki.Location = new System.Drawing.Point(43, 31);
            this.dgvPregledStavki.Name = "dgvPregledStavki";
            this.dgvPregledStavki.Size = new System.Drawing.Size(472, 90);
            this.dgvPregledStavki.TabIndex = 16;
            // 
            // btnPohrani
            // 
            this.btnPohrani.Location = new System.Drawing.Point(119, 220);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(148, 20);
            this.btnPohrani.TabIndex = 14;
            this.btnPohrani.Text = "Pohrani";
            this.btnPohrani.UseVisualStyleBackColor = true;
            // 
            // txtOpisPopusta
            // 
            this.txtOpisPopusta.Location = new System.Drawing.Point(119, 147);
            this.txtOpisPopusta.Name = "txtOpisPopusta";
            this.txtOpisPopusta.Size = new System.Drawing.Size(148, 20);
            this.txtOpisPopusta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Šifra korisnika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Stavke računa";
            // 
            // chboxR1
            // 
            this.chboxR1.AutoSize = true;
            this.chboxR1.Location = new System.Drawing.Point(119, 186);
            this.chboxR1.Name = "chboxR1";
            this.chboxR1.Size = new System.Drawing.Size(40, 17);
            this.chboxR1.TabIndex = 18;
            this.chboxR1.Text = "R1";
            this.chboxR1.UseVisualStyleBackColor = true;
            // 
            // chboxNormalni
            // 
            this.chboxNormalni.AutoSize = true;
            this.chboxNormalni.Location = new System.Drawing.Point(178, 186);
            this.chboxNormalni.Name = "chboxNormalni";
            this.chboxNormalni.Size = new System.Drawing.Size(67, 17);
            this.chboxNormalni.TabIndex = 19;
            this.chboxNormalni.Text = "Normalni";
            this.chboxNormalni.UseVisualStyleBackColor = true;
            // 
            // FrmNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 277);
            this.Controls.Add(this.chboxNormalni);
            this.Controls.Add(this.chboxR1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPregledStavki);
            this.Controls.Add(this.btnPohrani);
            this.Controls.Add(this.txtOpisPopusta);
            this.Controls.Add(this.label1);
            this.Name = "FrmNoviRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi račun";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledStavki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledStavki;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.TextBox txtOpisPopusta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chboxR1;
        private System.Windows.Forms.CheckBox chboxNormalni;
    }
}