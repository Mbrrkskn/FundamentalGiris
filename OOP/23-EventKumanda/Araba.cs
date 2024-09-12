using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_EventKumanda
{
  public class Araba
    {
        public delegate void HizAsimHandler();
        public event HizAsimHandler HizAsim;

        private readonly string _kod;

       
        public string Marka { get; set; }
        public Araba(string marka, string kod)
        {
            this.Marka = marka;
            this._kod = kod;
        }
        public void SinyalAl(string kod)
        {

            Console.WriteLine($"{Marka}Sinyal alındı {kod}");
            if(kod == _kod)
            {
                KapilariAc();
            }

        }

        private void KapilariAc()
        {
            Console.WriteLine($"{Marka} kapilari acildi Kod:{_kod}");
        }
    }
}
