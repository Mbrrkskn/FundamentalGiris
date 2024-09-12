using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14_InterfaceFutbaolcu.Abstract;

namespace _14_InterfaceFutbaolcu.Concrete
{
    public class OrtaSaha : BaseFutbolcu, IOrtaSaha
    {
        public string PasTrafigiYap()
        {
            return $"{AdiSoyadi} Topu Yakaladı";
        }
    }
}
