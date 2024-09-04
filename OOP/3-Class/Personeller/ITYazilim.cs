using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class.Personeller
{
    public class ITYazilim: Personel
    {
        public ITYazilim()
        {
            Maas=base.Maas*2.5;
        }
        public void KodYaz()
        {

        }
        public void DebugYap() { }
        public void TestEt() { }
    }
}
