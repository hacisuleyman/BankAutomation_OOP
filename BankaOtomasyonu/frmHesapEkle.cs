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
    public partial class frmHesapEkle : Form
    {
        public BankaSinifi Banka = new BankaSinifi();

        public frmHesapEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapEkle_Click(object sender, EventArgs e)
        {
            
            BireyselHesap bh = new BireyselHesap();
            TicariHesap th = new TicariHesap();
            Random rastHesNo = new Random();
            if (Banka.MusteriKontrol(txtMusteriNo.Text) == "Bireysel")
            {

                bh.HesapNo = Convert.ToUInt64(rastHesNo.Next(100000, 200000));
                while (Banka.HesapNoKontrol(bh.HesapNo) == "var")
                {
                    bh.HesapNo = Convert.ToUInt64(rastHesNo.Next(100000, 200000));
                }
                Banka.HesapOlusturKontrol(Convert.ToString(txtMusteriNo.Text), bh);
                bh.EkHesap = 500;

                MessageBox.Show("Hesap numarası: " + bh.HesapNo.ToString());


            }
            else if(Banka.MusteriKontrol(txtMusteriNo.Text) == "Ticari")
            {

                th.HesapNo = Convert.ToUInt64(rastHesNo.Next(200000, 300000));
                while (Banka.HesapNoKontrol(th.HesapNo) == "var")
                {
                    th.HesapNo = Convert.ToUInt64(rastHesNo.Next(200000, 300000));
                }
                Banka.HesapOlusturKontrol(Convert.ToString(txtMusteriNo.Text), th);
                th.EkHesap = 1000;

                MessageBox.Show("Hesap numarası: " + th.HesapNo.ToString());
            }

            else
                MessageBox.Show("Kayıtlı bir müşteri numarası bulunamadı.");
        }

        private void frmHesapEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
