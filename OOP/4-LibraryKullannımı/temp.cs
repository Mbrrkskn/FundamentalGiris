using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_Class.Personeller;

namespace _4_LibraryKullannımı
{
    public class temp :SatisElemani
    {
        int sayi;
        protected List<SatisElemani> satiscilar = new List<SatisElemani>();

        public void test()
        {
            //double prim =base.Prim;
        }

        //Metod burda pribvatedeir
        void test2() { }

        //Sadece kalıtım verdiği yerlerden ulasılabilir
        protected void test3() { }

    }
}
