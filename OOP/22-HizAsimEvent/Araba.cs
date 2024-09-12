using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_HizAsimEvent
{
  public class Araba
    {
        public delegate void HizAsimHandler();
        public event HizAsimHandler HizAsim;

        private int _hiz;

        public int Hiz
        {
            get { return _hiz; }
          set {
                if (value > 120)
                {
                    HizAsim();

                }
            } 
        }
        public string Marka { get; set; }
        public Araba(string marka, int hiz)
        {
            this.Marka = marka;
            this.Hiz = hiz;
        }

    }
}
