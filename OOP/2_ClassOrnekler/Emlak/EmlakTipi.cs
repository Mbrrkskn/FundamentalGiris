using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassOrnekler.Emlak
{
    public class EmlakTipi: Emlak
    {
        public string Konut { get; set; }
        public string Arsa { get; set; }
        public string IsYeri { get; set; }
        public string KonutProjeleri { get; set; }


        public EmlakTipi(int ilanNo, DateTime ilanTarihi, string kimden, string tapuDurumu, string adres, double fiyat, bool satilik, double metreKare, string konut, string arsa, string isYeri, string konutProjeleri): base(ilanNo, ilanTarihi, kimden, tapuDurumu, adres, fiyat, satilik, metreKare)
        {
            Konut = konut;
            Arsa = arsa;
            IsYeri = isYeri;
            KonutProjeleri = konutProjeleri;
        }
    }
}
