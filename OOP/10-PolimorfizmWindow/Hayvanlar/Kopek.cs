using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorfizmWindow.Hayvanlar
{
    public class Kopek:Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("HAV HAV");
        }
        public override void HareketEt()
        {
            Console.WriteLine("Kopek Kostu");
        }

    }
}
