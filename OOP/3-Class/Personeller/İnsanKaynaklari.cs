using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class.Personeller
{
    public class İnsanKaynaklari: Personel
    {
        public İnsanKaynaklari()
        {
            Maas = base.Maas*2;
        }
        public void IseAlimGorusmesiYap() { }
        public void BordroHazirla() { }

        public void OryantasyonuSagla() { }
        public void IstenCikart() { } 
    }
}
