using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorfizmWindow.Hayvanlar
{
    public class Kedi :Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Miyav");
        }
        public override void HareketEt()
        {
            Console.WriteLine("Kedi Kostu");
        }
    }
}
