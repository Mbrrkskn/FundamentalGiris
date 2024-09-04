using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class.Personeller
{
    public class SatisElemani :Personel
    {
        //sadece kalıtım verdiği yerlerde ulaşılabilir
        //Instance alınınca erişilemez
        public double Prim { get; set; }
        public SatisElemani()
        {
            Maas = base.Maas*1.5 + Prim;
        }

        public void MusterileriAra()
        { 

        }
   
        public void MusterileriZiyaretEt() { }

        public void SatisYap() { }

    
    }
}
