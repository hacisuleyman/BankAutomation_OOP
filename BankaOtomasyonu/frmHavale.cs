using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonuDeneme
{
    public partial class frmHavale : Form
    {
        public BankaSinifi Banka = new BankaSinifi();

        public frmHavale()
        {
            InitializeComponent();
        }

        private void frmHavale_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGonBul_Click(object sender, EventArgs e)
        {
            txtGoruntuleHav.Text = "HESAP NO    BAKİYE" + Environment.NewLine + Banka.HesapBul(Convert.ToUInt32(txtGonHesNo.Text));
        }

        private void btnAlBul_Click(object sender, EventArgs e)
        {
            txtGoruntuleHav.Text = "HESAP NO    BAKİYE" + Environment.NewLine + Banka.HesapBul(Convert.ToUInt32(txtAlHesNo.Text));
        }

        private void btnHavaleYap_Click(object sender, EventArgs e)
        {
            ulong hesapno = Convert.ToUInt32(txtGonHesNo.Text);
            ulong hesapno2 = Convert.ToUInt32(txtAlHesNo.Text);
            decimal miktar = Convert.ToDecimal(txtHavaleTutar.Text);
            Banka.HavaleKontrol(hesapno,hesapno2,miktar);
        }

        private void txtGoruntuleHav_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
