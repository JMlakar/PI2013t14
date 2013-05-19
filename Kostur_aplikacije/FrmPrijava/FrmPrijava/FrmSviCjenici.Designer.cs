namespace FrmPrijava
{
    partial class FrmSviCjenici
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
            this.dgvPregledCjenika = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPregledStavaka = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledCjenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledStavaka)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledCjenika
            // 
            this.dgvPregledCjenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledCjenika.Location = new System.Drawing.Point(32, 34);
            this.dgvPregledCjenika.Name = "dgvPregledCjenika";
            this.dgvPregledCjenika.Size = new System.Drawing.Size(493, 87);
            this.dgvPregledCjenika.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cjenici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stavke cjenika";
            // 
            // dgvPregledStavaka
            // 
            this.dgvPregledStavaka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledStavaka.Location = new System.Drawing.Point(32, 175);
            this.dgvPregledStavaka.Name = "dgvPregledStavaka";
            this.dgvPregledStavaka.Size = new System.Drawing.Size(493, 87);
            this.dgvPregledStavaka.TabIndex = 3;
            // 
            // FrmSviCjenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 293);
            this.Controls.Add(this.dgvPregledStavaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPregledCjenika);
            this.Name = "FrmSviCjenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cjenici";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledCjenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledStavaka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledCjenika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPregledStavaka;
    }
}