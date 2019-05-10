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
    public partial class frmBirMusteriEkle : Form
    {
        public BankaSinifi Banka;
        public frmBirMusteriEkle()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBirEkle_Click(object sender, EventArgs e)
        {
            Random rastMusNo = new Random();
            BireyselMusteri b1 = new BireyselMusteri();

            if (txtBirTCNo.TextLength < 11)
                MessageBox.Show("TC Kimlik Numarasını Kontrol Ediniz. " + Environment.NewLine + "TC Kimlik No 11 Haneli Olmalıdır!");

            else
            {
                
                b1.Ad = txtBirAd.Text;
                b1.Soyad = txtBirSoyad.Text;
                b1.MusteriTip = "bireysel";
                b1.TCNo = Convert.ToUInt64(txtBirTCNo.Text);

                if (Banka.TCKNKontrol(b1.TCNo) == "kvar")
                    MessageBox.Show("Bu TC Kimlik Numarasına Ait Müşteri Zaten Var.");

                else
                {
                    b1.Telefon = Convert.ToUInt64(txtBirTelefon.Text);
                    b1.MusteriNo = Convert.ToString(rastMusNo.Next(10000, 20000));
                    while (Banka.MusteriNoKontrol(b1.MusteriNo) == "var")
                        b1.MusteriNo = Convert.ToString(rastMusNo.Next(10000, 20000));

                    Banka.MusteriEkle(b1);
                    MessageBox.Show("Müşteri numarası: " + b1.MusteriNo.ToString());
                }
            }
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBirAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBirTCNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
