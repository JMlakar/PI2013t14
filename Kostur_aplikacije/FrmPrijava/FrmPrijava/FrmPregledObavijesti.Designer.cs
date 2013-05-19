namespace FrmPrijava
{
    partial class FrmPregledObavijesti
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
            this.listaObavijesti = new System.Windows.Forms.ListBox();
            this.btnIsprazni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaObavijesti
            // 
            this.listaObavijesti.FormattingEnabled = true;
            this.listaObavijesti.Location = new System.Drawing.Point(37, 26);
            this.listaObavijesti.Name = "listaObavijesti";
            this.listaObavijesti.Size = new System.Drawing.Size(490, 186);
            this.listaObavijesti.TabIndex = 0;
            // 
            // btnIsprazni
            // 
            this.btnIsprazni.Location = new System.Drawing.Point(37, 232);
            this.btnIsprazni.Name = "btnIsprazni";
            this.btnIsprazni.Size = new System.Drawing.Size(154, 35);
            this.btnIsprazni.TabIndex = 1;
            this.btnIsprazni.Text = "Isprazni listu";
            this.btnIsprazni.UseVisualStyleBackColor = true;
            // 
            // FrmPregledObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 293);
            this.Controls.Add(this.btnIsprazni);
            this.Controls.Add(this.listaObavijesti);
            this.Name = "FrmPregledObavijesti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled obavijesti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaObavijesti;
        private System.Windows.Forms.Button btnIsprazni;

    }
}