
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_EventYangin
{
    public class Sigara
    {
        public event OlayTemsilci Yandim;
        private readonly string _Marka;

        public Sigara(string marka)
        {
            this._Marka = marka;
        }
        public void SigaraIc()
        {
           
            Console.WriteLine($"{_Marka} sigara yandi");
           
        }
    }
}
