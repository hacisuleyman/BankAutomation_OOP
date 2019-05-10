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
    public partial class frmTicMusteriEkle : Form
    {
        public BankaSinifi Banka = new BankaSinifi();
        public frmTicMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnTicEkle_Click(object sender, EventArgs e)
        {
            Random rastMusNo = new Random();
            TicariMusteri t1 = new TicariMusteri();

            if (txtTicTCNo.TextLength < 11)
                MessageBox.Show("TC Kimlik Numarısını Kontrol Ediniz. " + Environment.NewLine + "TC Kimlik No 11 Haneli Olmalıdır!");

            else
            {
                t1.Ad = txtTicAd.Text;
                t1.Soyad = txtTicSoyad.Text;
                t1.TCNo = Convert.ToUInt64(txtTicTCNo.Text);

                if (Banka.TCKNKontrol(t1.TCNo) == "kvar")
                    MessageBox.Show("Bu TC Kimlik Numarasına Ait Müşteri Zaten Var.");

                else
                {
                    t1.MusteriTip = "ticari";
                    t1.Telefon = Convert.ToUInt64(txtTicTelefon.Text);
                    t1.KullaniciAdi = txtKullaniciAdi.Text;
                    t1.MusteriNo = Convert.ToString(rastMusNo.Next(20000, 30000));

                    while (Banka.MusteriNoKontrol(t1.MusteriNo) == "var")
                    {
                        t1.MusteriNo = Convert.ToString(rastMusNo.Next(20000, 30000));
                    }

                    Banka.MusteriEkle(t1);
                    MessageBox.Show("Müşteri numarası: " + t1.MusteriNo.ToString());
                }
            }
        }

        private void TicariMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
