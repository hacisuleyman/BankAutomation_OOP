using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonuDeneme
{
    public abstract class HesapSinifi
    {
        public ulong HesapNo { get; set; }

        public decimal Bakiye = 0;

        public int Tutar { get; set; }

        public decimal EkHesap { get; set; }

        public string ParaCek(decimal tutar)
        {
            string str = "";
            HesapOzeti hesapOz = new HesapOzeti();

            if (tutar < 750)
            {
                if (tutar < Bakiye || tutar == Bakiye)
                {
                    Bakiye -= tutar;
                    str = "var";
                }
                else
                {
                    if (tutar < (Bakiye + EkHesap) || tutar == (Bakiye + EkHesap))
                    {
                        Bakiye -= tutar;
                        str = "var";
                    }

                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Bakiye Yetersiz");
                        str = "yok";
                    }
                }
            }

            else
                System.Windows.Forms.MessageBox.Show("Para Çekme Limitini Aştınız.");

            return str;
        }

        public void ParaYatir(decimal tutar)
        {
            HesapOzeti hesapOz = new HesapOzeti();

            Bakiye += tutar;
        }
        public abstract string ParaHavale(decimal Ucret, HesapSinifi alanhesap);
        
        
    }
}
