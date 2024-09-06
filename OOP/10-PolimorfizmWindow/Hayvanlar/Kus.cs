using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorfizmWindow.Hayvanlar
{
    public class Kus:Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Cik Cik");
        }
        public override void HareketEt()
        {
            Console.WriteLine(" Kus uçar");
        }
    }
}
