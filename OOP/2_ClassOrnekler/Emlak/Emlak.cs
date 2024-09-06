using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassOrnekler.Emlak
{
    public class Emlak
    {
        public int İlanNo { get; set; }
        public DateTime İlanTarihi { get; set; }

        public string Kimden { get; set; }
        public string TapuDurumu { get; set; }
        public string Adres { get; set; }

        public double Fiyat { get; set; }
        public bool Satilik { get; set; }
        public double MetreKare { get; set; }

        public Emlak(int ilanNo, DateTime ilanTarihi, string kimden, string tapuDurumu, string adres, double fiyat, bool satilik, double metreKare)
        {
            İlanNo = ilanNo;
            İlanTarihi = ilanTarihi;
            Kimden = kimden;
            TapuDurumu = tapuDurumu;
            Adres = adres;
            Fiyat = fiyat;
            Satilik = satilik;
            MetreKare = metreKare;
        }

    }
}
