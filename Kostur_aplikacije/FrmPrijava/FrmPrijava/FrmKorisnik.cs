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
    public partial class FrmKorisnik : Form
    {
        public FrmKorisnik()
        {
            InitializeComponent();
        }

        private void btnPregledCjenika_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmSviCjenici frmSviCjenici = new FrmSviCjenici();

            frmSviCjenici.ShowDialog();

            this.Show();
        }

        private void btnPregledObavijesti_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmPregledObavijesti frmPregledObavijesti = new FrmPregledObavijesti();

            frmPregledObavijesti.ShowDialog();

            this.Show();

        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmKlijenti frmKlijenti = new FrmKlijenti();

            frmKlijenti.ShowDialog();

            this.Show();

        }

        private void btnNoviRacun_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmNoviRacun frmNoviRacun = new FrmNoviRacun();

            frmNoviRacun.ShowDialog();

            this.Show();

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
