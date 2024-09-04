using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class.Personeller
{
    public class Sekreter :Personel
    {
        public Sekreter()
        {
            Maas = base.Maas+7000;
        }

        public void TelefonlaraBak() { }
        public void RandevulariAyarla() { }
    }
}
