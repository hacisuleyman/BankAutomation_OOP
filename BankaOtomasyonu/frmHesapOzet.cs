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
    public partial class frmHesapOzet : Form
    {
        public BankaSinifi Banka = new BankaSinifi();

        public frmHesapOzet()
        {
            InitializeComponent();
        }

        private void frmHesapOzet_Load(object sender, EventArgs e)
        {

        }

        private void btnOzet_Click(object sender, EventArgs e)
        {
            txtozetliste.Text=Banka.HesapOzetiGoruntule(Convert.ToUInt32(txtHesNoho.Text));
        }
    }
}
