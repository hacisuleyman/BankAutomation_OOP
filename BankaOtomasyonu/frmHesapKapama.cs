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
    public partial class frmHesapKapama : Form
    {
        public BankaSinifi Banka = new BankaSinifi();

        public frmHesapKapama()
        {
            InitializeComponent();
        }

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            Banka.HesapKapamaKontrol(Convert.ToUInt32(txtHesapNo.Text));

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHesapNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHesapKapama_Load(object sender, EventArgs e)
        {

        }
    }
}
