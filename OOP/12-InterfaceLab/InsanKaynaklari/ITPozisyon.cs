using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.InsanKaynaklari
{
    public class ITPozisyon
    {
        public string PozisyonAdi { get; set; }
        public string ArananYetenekler { get; set; }

        public ITPozisyon(string pozisyonAdi, string arananYetenekler)
        {
            PozisyonAdi = pozisyonAdi;
            ArananYetenekler = arananYetenekler;
        }

        public void PozisyonBilgisiGoster()
        {
            Console.WriteLine($"Pozisyon: {PozisyonAdi}, Aranan Yetenekler: {ArananYetenekler}");
        }
    }
}
