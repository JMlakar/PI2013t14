namespace FrmPrijava
{
    partial class FrmCRM
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
            this.txtOpisPopusta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVrijemeProvjere = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.coboxBrDolazaka = new System.Windows.Forms.ComboBox();
            this.dgvCRM = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCRM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opis popusta";
            // 
            // txtOpisPopusta
            // 
            this.txtOpisPopusta.Location = new System.Drawing.Point(45, 129);
            this.txtOpisPopusta.Multiline = true;
            this.txtOpisPopusta.Name = "txtOpisPopusta";
            this.txtOpisPopusta.Size = new System.Drawing.Size(357, 79);
            this.txtOpisPopusta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj dolazaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vrijeme provjere";
            // 
            // txtVrijemeProvjere
            // 
            this.txtVrijemeProvjere.Location = new System.Drawing.Point(130, 265);
            this.txtVrijemeProvjere.Name = "txtVrijemeProvjere";
            this.txtVrijemeProvjere.Size = new System.Drawing.Size(121, 20);
            this.txtVrijemeProvjere.TabIndex = 5;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(130, 300);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(121, 20);
            this.btnUnesi.TabIndex = 6;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            // 
            // coboxBrDolazaka
            // 
            this.coboxBrDolazaka.FormattingEnabled = true;
            this.coboxBrDolazaka.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.coboxBrDolazaka.Location = new System.Drawing.Point(130, 232);
            this.coboxBrDolazaka.Name = "coboxBrDolazaka";
            this.coboxBrDolazaka.Size = new System.Drawing.Size(121, 21);
            this.coboxBrDolazaka.TabIndex = 7;
            // 
            // dgvCRM
            // 
            this.dgvCRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCRM.Location = new System.Drawing.Point(42, 17);
            this.dgvCRM.Name = "dgvCRM";
            this.dgvCRM.Size = new System.Drawing.Size(472, 90);
            this.dgvCRM.TabIndex = 8;
            // 
            // FrmCRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 349);
            this.Controls.Add(this.dgvCRM);
            this.Controls.Add(this.coboxBrDolazaka);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtVrijemeProvjere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpisPopusta);
            this.Controls.Add(this.label1);
            this.Name = "FrmCRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCRM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpisPopusta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVrijemeProvjere;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.ComboBox coboxBrDolazaka;
        private System.Windows.Forms.DataGridView dgvCRM;
    }
}