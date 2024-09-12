using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.InsanKaynaklari
{
    public class InsanKaynaklari
    {
        public void BasvuruDegerlendir(Aday aday)
        {
           
            Console.WriteLine($"İnsan Kaynakları {aday.Ad} {aday.Soyad} başvurusunu inceliyor...");

          
            if (aday.YetenekTestiSonucu)
            {
                Console.WriteLine("Başvuru olumlu sonuçlandı.");
            }
            else
            {
                Console.WriteLine("Başvuru olumsuz sonuçlandı.");
            }
        }
    }
}
