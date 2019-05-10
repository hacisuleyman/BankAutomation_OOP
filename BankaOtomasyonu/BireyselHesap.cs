using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonuDeneme
{
    public class BireyselHesap : HesapSinifi
    {
        public override string ParaHavale(decimal Ucret,HesapSinifi alanhesap)
        {
            string str="";
            decimal havaleucret;

            havaleucret = Ucret * (0.02m);

            if (Ucret > Bakiye)
            {
                str = "yok";
                System.Windows.Forms.MessageBox.Show("Havale Edilecek tutar bakiye tutarından fazladır!");
            }
            else
            {
                Bakiye -= Ucret+ havaleucret;
                alanhesap.Bakiye += Ucret;
                str = "var";
            }
            return str;
        }
    }
}
