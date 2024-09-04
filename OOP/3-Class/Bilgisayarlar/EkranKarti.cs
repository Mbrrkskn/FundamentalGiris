using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class.Bilgisayarlar
{
    public enum EkranKartiTipi
    {
        nVIDIA=1,
        AMD
    }
    public class EkranKarti:BaseItem
    {
        public short Hafiza { get; set; }
        public EkranKartiTipi KartiTipi { get; set; }
    }
}
