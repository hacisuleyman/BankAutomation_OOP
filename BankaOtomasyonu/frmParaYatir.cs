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
    public partial class frmParaYatir : Form
    {
        public BankaSinifi Banka = new BankaSinifi();
        public frmParaYatir()
        {
            InitializeComponent();
        }

        private void ParaEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnBulPy_Click(object sender, EventArgs e)
        {
            txtGoruntulePy.Text ="HESAP NO    BAKİYE" + Environment.NewLine + Banka.HesapBul(Convert.ToUInt32(txtHesNoPy.Text));
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            Banka.ParaYatirKontrol(Convert.ToUInt32(txtHesNoPy.Text),Convert.ToDecimal(txtYatTutar.Text));
        }

        private void txtGoruntulePy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
