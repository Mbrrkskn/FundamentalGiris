using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14_InterfaceFutbaolcu.Abstract;

namespace _14_InterfaceFutbaolcu.Concrete
{
    public class Defans : BaseFutbolcu, IDefans
    {
        public string CoreCoreMucadele()
        {
            return $"{AdiSoyadi} Mucadele etti";
        }

        public string DefansYap()
        {
            return $"{AdiSoyadi} Defans Yaptı";
        }

        public string TopGecerAdamGecmez()
        {
            return $"{AdiSoyadi} Faul Yapti";
        }
    }
}
