using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventTrafikKontrol
{
    public class HizAsimiEventArgs : EventArgs
    {
        public string Plaka { get; set; }
        public int Hiz { get; set; }
        public int Ceza { get; set; }

        public HizAsimiEventArgs(string plaka, int hiz, int ceza)
        {
            Plaka = plaka;
            Hiz = hiz;
            Ceza = ceza;
        }
    }
}
