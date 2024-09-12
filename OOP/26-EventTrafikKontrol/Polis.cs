using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventTrafikKontrol
{
    public class Polis
    {
        public string AdSoyad { get; set; }
        public Polis(string adSoyad)
        {
            AdSoyad = adSoyad;
        }
        public void CezaKes(object sender, HizAsimiEventArgs e)
        {
            Console.WriteLine($"{e.Plaka} plakalı aracın sürücüsüne {e.Hiz} km hızla gittiği için {e.Ceza} TL ceza kesilmiştir.");
            Console.WriteLine($"Cezayı kesen polis: {AdSoyad}");
        }
    }
}
