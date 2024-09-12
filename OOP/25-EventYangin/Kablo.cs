using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_EventYangin
{
    public class Kablo
    {
        public event OlayTemsilci Yandim;

        public void AkimGecir()
        {
            Console.WriteLine("Kablo yandi");
            Yandim(this);
        }
    }
}
