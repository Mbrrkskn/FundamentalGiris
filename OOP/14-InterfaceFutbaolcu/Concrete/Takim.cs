using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14_InterfaceFutbaolcu.Abstract;

namespace _14_InterfaceFutbaolcu.Concrete
{
    public class Takim(List<BaseFutbolcu> futbolcular)
    {
        public override string ToString()
        {
            string sonuc = string.Empty;
            foreach (var futbolcu in futbolcular)
            {
                sonuc += futbolcu.ToString();
            }
            return sonuc;
        }

    }
}
