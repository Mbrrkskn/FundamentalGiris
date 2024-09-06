using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.LokantaOrnegi
{
    internal class TazeFasulye:IPisirilebilir
    {
        public void Pisir()
        {
            Console.WriteLine(this.GetType().Name + "Pisti");
        }
    }
}
