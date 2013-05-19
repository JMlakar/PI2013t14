using System;
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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmAdmin frmAdmin = new FrmAdmin();

            //frmAdmin.ShowDialog();


            //this.Show();
            

            FrmKorisnik frmKorisnik = new FrmKorisnik();

            frmAdmin.Show();
            this.Show();

            frmKorisnik.Show();
         

            this.Show();
            
            


        }
    }
}
