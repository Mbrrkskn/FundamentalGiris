using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class.Personeller
{
   public class SatisMüdürü: SatisElemani
    {
        //Odev: Prim property'si instance alındıgında gorunmeyecek
          
        public SatisMüdürü()
        {
            BagliElemanlar = new List<SatisElemani>();
            Maas =base.Maas +PrimHesapla();
            
        }
        public  List<SatisElemani>  BagliElemanlar { get; set; }
        public void SatisToplantisiYap() { }
        public void BayiToplantilariYap() { }

        private double PrimHesapla()
        {
            double primtoplami = 0;
            foreach(var item in BagliElemanlar)
            {
                primtoplami += item.Prim * 0.1;
            }
            return primtoplami;
        }
       
    }
}
