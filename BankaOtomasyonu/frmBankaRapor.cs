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
    public partial class frmBankaRapor : Form
    {
        public BankaSinifi Banka = new BankaSinifi();
        public frmBankaRapor()
        {
            InitializeComponent();
        }

        private void frmBankaRapor_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGosterBr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GELİR:" + Banka.Rapor.BankaYatirilanpara + Environment.NewLine + "GİDER:" + Banka.Rapor.BankaCekilenPara + Environment.NewLine +
                           "TOPLAMPARA:" + Banka.Rapor.ToplamPara);
        }
    }
}
