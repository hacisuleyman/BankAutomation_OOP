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
    public partial class frmParaCek : Form
    {
        public BankaSinifi Banka = new BankaSinifi();

        public frmParaCek()
        {
            InitializeComponent();
        }

        private void frmParaCek_Load(object sender, EventArgs e)
        {

        }

        private void btnBulPc_Click(object sender, EventArgs e)
        {
            txtGoruntulePc.Text ="HESAP NO    BAKİYE    "+ Environment.NewLine + Banka.HesapBul(Convert.ToUInt32(txtHesNoPc.Text));
        }

        private void btnCekPc_Click(object sender, EventArgs e)
        {
            Banka.ParaCekKontrol(Convert.ToUInt32(txtHesNoPc.Text), Convert.ToDecimal(txtTutarPc.Text));
        }

        private void txtGoruntulePc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
