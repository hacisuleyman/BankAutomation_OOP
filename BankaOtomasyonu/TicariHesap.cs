using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonuDeneme
{
    public class TicariHesap : HesapSinifi
    {
        public override string ParaHavale(decimal Ucret, HesapSinifi alanhesap)
        {
            string str = "";
            if (Ucret > Bakiye)
            {
                str = "yok";
                System.Windows.Forms.MessageBox.Show("Havale Edilecek tutar bakiye tutarından fazladır!");
            }
            else
            {
                str = "var";
                Bakiye -= Ucret;
                alanhesap.Bakiye += Ucret;
            }
            return str;
        }
    }
}
