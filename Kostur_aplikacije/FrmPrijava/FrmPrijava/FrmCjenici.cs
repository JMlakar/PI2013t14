﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrijava
{
    public partial class FrmKreirajCjenik : Form
    {
        public FrmKreirajCjenik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmSviCjenici frmSviCjenici = new FrmSviCjenici();

            frmSviCjenici.ShowDialog();


            this.Show();
            
        }
    }
}
