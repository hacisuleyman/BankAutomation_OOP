using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonuDeneme
{
    public class BankaSinifi
    {
        public BankaRaporu Rapor;
        public List<MusteriSinifi> Musteriler { get; set; }
        public List<HesapOzeti> HesapOzetleri;

        public BankaSinifi()
        {
            this.Rapor = new BankaRaporu();                 //composition ilişki 
            this.Musteriler = new List<MusteriSinifi>();    //composition ilişki
            this.HesapOzetleri = new List<HesapOzeti>();    //composition ilişki
        }

        public void MusteriEkle(MusteriSinifi m)
        {
            Musteriler.Add(m);
        }

        public string MusteriKontrol(string musterino)
        {
            string str = "";
            foreach (MusteriSinifi m in Musteriler)
            {
                if (musterino == m.MusteriNo)
                {
                    if (m.MusteriTip == "bireysel")
                        str += "Bireysel";

                    else
                        str += "Ticari";
                }
            }
            return str;
        }

        public string TCKNKontrol(ulong kimlikno)
        {
            string str = " ";
            foreach (MusteriSinifi m in Musteriler)
            {
                if (kimlikno == m.TCNo)
                    str = "kvar";

                else
                    str = "kyok";  
            }
            return str;
        }

        public void HesapOlusturKontrol(string musterino, HesapSinifi h)
        {
            foreach (MusteriSinifi m in Musteriler)
            {
                if (musterino == m.MusteriNo)
                    m.HesapEkle(h);
            }
        }
                                               
        public void HesapKapamaKontrol(ulong hesapno)
        {
            foreach (MusteriSinifi m1 in Musteriler)
            {
                foreach (HesapSinifi h1 in m1.Hesaplar)
                {
                    if (hesapno == h1.HesapNo)
                    {
                        if (h1.Bakiye == 0)
                        {
                            m1.HesapKapa(h1);
                            System.Windows.Forms.MessageBox.Show("Hesap Kapatıldı.");
                            break;
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("Hesabın kapatılabilmesi için bakiye 0 olmalıdır.");
                    }
                }
            }
        }

        public string MusteriNoKontrol(string musterino)
        {
            string str = " ";
            foreach (MusteriSinifi m in Musteriler)
            {
                if (m.MusteriNo == musterino)
                    str = "var"; 
                else
                    str = "yok";
            }
            return str;
        }

        public string HesapNoKontrol(ulong hesapno)
        {
            string str = " ";
            foreach (MusteriSinifi m in Musteriler)
            {
                foreach (HesapSinifi h in m.Hesaplar)
                {
                    if (hesapno == h.HesapNo)
                        str = "var";
                    
                    else
                        str = "yok";
                }
            }
            return str;
        }

        public string HesapBul(ulong hesno)
        {
            string str = "";
            foreach (MusteriSinifi m in Musteriler)
            {
                foreach (HesapSinifi hesap in m.Hesaplar)
                {
                    if (hesno == hesap.HesapNo)
                        str = "     " + hesap.HesapNo.ToString() + "      " + hesap.Bakiye;
                }
            }
            return str;
        }


        public void ParaCekKontrol(ulong hesapno, decimal tutar)
        {
            HesapOzeti hesapozeti = new HesapOzeti();
            DateTime zaman;

            foreach (MusteriSinifi m in Musteriler)
            {
                foreach (HesapSinifi h in m.Hesaplar)
                {
                    if (hesapno == h.HesapNo)
                    {
                        if (h.ParaCek(tutar) == "var")
                        {
                            System.Windows.Forms.MessageBox.Show("Tutar çekildi.");
                            Rapor.BankaCekilenPara += tutar;
                            Rapor.ToplamPara -= tutar;
                            
                            zaman = DateTime.Now;
                            hesapozeti.HesNo = hesapno;
                            hesapozeti.IslemTipi = "PARA CEKME ISLEMI";
                            hesapozeti.Tutar = -tutar;
                            hesapozeti.Tarih = zaman;
                            HesapOzetiEkle(hesapozeti);
                        }
                    }
                }
            }
        }

        public void ParaYatirKontrol(ulong hesapno, decimal tutar)
        {
            HesapOzeti hesapozeti = new HesapOzeti();
            DateTime zaman;
            foreach (MusteriSinifi m in Musteriler)
            {
                foreach (HesapSinifi h in m.Hesaplar)
                {
                    if (hesapno == h.HesapNo)
                    {
                        h.ParaYatir(tutar);
                        System.Windows.Forms.MessageBox.Show("Tutar yatırıldı.");
                        Rapor.BankaYatirilanpara += tutar;
                        Rapor.ToplamPara += tutar;

                        zaman = DateTime.Now;
                        hesapozeti.HesNo = hesapno;
                        hesapozeti.IslemTipi = "PARA YATIRMA ISLEMI";
                        hesapozeti.Tutar = tutar;
                        hesapozeti.Tarih = zaman;
                        HesapOzetiEkle(hesapozeti);
                    }
                }
            }
        }


        public void HavaleKontrol(ulong hesapno1, ulong hesapno2, decimal ucret)
        {
            HesapOzeti hesozet = new HesapOzeti();
            HesapOzeti hesozet1 = new HesapOzeti();
            DateTime zaman;
            foreach (MusteriSinifi m in Musteriler)
            {
                foreach (HesapSinifi h in m.Hesaplar)
                {
                    if (hesapno1 == h.HesapNo)
                    {
                        foreach (MusteriSinifi m1 in Musteriler)
                        {
                            foreach (HesapSinifi h1 in m1.Hesaplar)
                            {
                                if (hesapno2 == h1.HesapNo)
                                {
                                    if (h.ParaHavale(ucret, h1) == "var")
                                    {
                                        System.Windows.Forms.MessageBox.Show("Tutar havale yapıldı.");
                                        if (h.HesapNo > 100000 && h.HesapNo < 200000)
                                            Rapor.ToplamPara += ucret*(0.02m);

                                        zaman = DateTime.Now;
                                        hesozet.HesNo = hesapno1;
                                        hesozet.IslemTipi = "HAVALE İŞLEMİ";
                                        hesozet.Tutar = -ucret;
                                        hesozet.Tarih = zaman;
                                        HesapOzetiEkle(hesozet);

                                        zaman = DateTime.Now;
                                        hesozet1.HesNo = hesapno2;
                                        hesozet1.IslemTipi = "HAVALE İŞLEMİ";
                                        hesozet1.Tutar = ucret;
                                        hesozet1.Tarih = zaman;
                                        HesapOzetiEkle(hesozet1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void HesapOzetiEkle(HesapOzeti hesapozeti)
        {
            HesapOzetleri.Add(hesapozeti);
        }

        public string HesapOzetiGoruntule(ulong hesno)
        { string str="";
            foreach(HesapOzeti ho in HesapOzetleri)
            {    if(hesno==ho.HesNo)
                     str += ho.HesNo.ToString()+ "        " + ho.Tutar + "         " + ho.Tarih + "       " + ho.IslemTipi+Environment.NewLine;
            }
            return str;
        }
    }
}
