using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _25_EventYangin
{
    public class Insan
    {
        public string AdSoyad { get; set; }

        public Insan(string adSoyad)
        {
            AdSoyad = adSoyad;
        }
        public void Kac(object sorun)
        {
            if(sorun is Alarm)
            {
                Console.WriteLine($"{AdSoyad} Alarmdan dolayı kaçtı");
            }
            else if(sorun is Kablo)
            {
                Console.WriteLine($"{AdSoyad} kablo yanınca merak edip baktı");
            }
        }

        public void RahatsızOl(object rahatsizEden)
        {
            if (rahatsizEden is Alarm)
            {
                Console.WriteLine($"{AdSoyad} Alarmdan dolayı rahatsız oldu");
            }
            else if (rahatsizEden is Kablo)
            {
                Console.WriteLine($"{AdSoyad} kablo yanınca sondurmeye calıstı");
            }
            else if  (rahatsizEden is Sigara)
            {
                Console.WriteLine($"{AdSoyad} oksürmeye basladı");
            }

        }
    }
}
