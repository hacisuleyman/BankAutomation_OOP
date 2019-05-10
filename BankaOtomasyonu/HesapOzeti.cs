using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonuDeneme
{
    public class HesapOzeti
    {
        public ulong HesNo { get; set; }
        public string IslemTipi { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }


    }
}
