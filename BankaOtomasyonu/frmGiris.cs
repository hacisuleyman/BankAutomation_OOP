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
    public partial class frmGiris : Form
    {
        BankaSinifi Banka = new BankaSinifi();

        public frmGiris()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void yeniMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblMusNo_Click(object sender, EventArgs e)
        {

        }

        private void yeniMüşteriToolStripMenuItem1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void paraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParaYatir pe = new frmParaYatir();
            pe.MdiParent = this;
            pe.Banka = this.Banka;
            pe.Show();


        }
        private void frmGiris_Load(object sender, EventArgs e)
        {



        }

        private void hesapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bireyselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBirMusteriEkle bm = new frmBirMusteriEkle();
            bm.MdiParent = this;
            bm.Banka = this.Banka;
            bm.Show();
            


        }

        private void ticariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTicMusteriEkle tm = new frmTicMusteriEkle();
            tm.MdiParent = this;
            tm.Banka=this.Banka;
            tm.Show();
        }

        private void yeniHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapEkle he = new frmHesapEkle();
            he.MdiParent = this;
            he.Banka = this.Banka;
            he.Show();

        }

        private void paraÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParaCek pc = new frmParaCek();
            pc.MdiParent = this;
            pc.Banka = this.Banka;
            pc.Show();
        }

        private void paraHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHavale ph = new frmHavale();
            ph.MdiParent = this;
            ph.Banka = this.Banka;
            ph.Show();
        }

        private void hesapÖzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapOzet ho = new frmHesapOzet();
            ho.MdiParent = this;
            ho.Banka = this.Banka;
            ho.Show();
        }

        private void hesapKapamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapKapama hk = new frmHesapKapama();
            hk.MdiParent = this;
            hk.Banka = this.Banka;
            hk.Show();
        }

        private void hesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bankaRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankaRapor br = new frmBankaRapor();
            br.MdiParent = this;
            br.Banka = this.Banka;
            br.Show();
        }
    }
}
