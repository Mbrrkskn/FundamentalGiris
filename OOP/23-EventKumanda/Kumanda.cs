using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_EventKumanda
{
    public delegate void EventKumandaEventHandler(string kod);
    public class Kumanda
    {
        public event EventKumandaEventHandler KumandayaBas;
       
        private readonly string _kod;
        public Kumanda(string kod) 
        {
            this._kod = kod;
        }
        public void TusaBas()
        {
            Console.WriteLine("Kumandaya basıldı");
            KumandayaBas(_kod);
        }
    }
}
