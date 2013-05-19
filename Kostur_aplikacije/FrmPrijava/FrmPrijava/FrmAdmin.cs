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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnUsluge_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmUsluge frmUsluge = new FrmUsluge();

            frmUsluge.ShowDialog();

            this.Show();
        }

        private void btnCjenici_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmKreirajCjenik frmCjenici = new FrmKreirajCjenik();

            frmCjenici.ShowDialog();

            this.Show();
        }

        private void btnCRM_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmCRM frmCRM = new FrmCRM();

            frmCRM.ShowDialog();

            this.Show();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmKorisnici frmKorisnici = new FrmKorisnici();

            frmKorisnici.ShowDialog();

            this.Show();
        }

        private void btnPostavkeRacuna_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmPostavkeRacuna frmPostavkeRacuna = new FrmPostavkeRacuna();

            frmPostavkeRacuna.ShowDialog();

            this.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
