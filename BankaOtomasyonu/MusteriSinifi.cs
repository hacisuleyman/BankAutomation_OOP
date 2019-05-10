using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonuDeneme
{
    public abstract class MusteriSinifi
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string MusteriNo { get; set; }

        public string MusteriTip { get; set; }

        public ulong TCNo { get; set; }

        public ulong Telefon { get; set; }

        public List<HesapSinifi> Hesaplar { get; set; }

        public void HesapEkle(HesapSinifi h)
        {
            Hesaplar.Add(h);
        }

        public void HesapKapa(HesapSinifi h)
        {
            Hesaplar.Remove(h);
        }
        
        public MusteriSinifi()
        {
            this.Hesaplar = new List<HesapSinifi>();    //composition ilişki
        }

        
    }
}
