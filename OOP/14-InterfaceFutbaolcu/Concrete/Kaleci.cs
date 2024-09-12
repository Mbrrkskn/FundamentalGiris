using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14_InterfaceFutbaolcu.Abstract;

namespace _14_InterfaceFutbaolcu.Concrete
{
    public class Kaleci : BaseFutbolcu, IKaleci
    {
        public string DegajYap()
        {
            return $"{AdiSoyadi} Degaj Yaptı";
        }

        public string PenaltiKurtar()
        {
            return $"{AdiSoyadi} Penalti kurtardı";
        }

        public string TopuElleYakala()
        {
            return $"{AdiSoyadi} Topu Yakaladı";
        }
    }
}
