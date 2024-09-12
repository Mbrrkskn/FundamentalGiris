using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_EventBomba
{
    public class Telefon
    {
        
        public delegate void KelimeKullanildiHandler();
        public event KelimeKullanildiHandler KelimeKullanildi;

        public void Gorusme()
        {
            Console.WriteLine("Görüşme başladı.");
           

            string kelime = Console.ReadLine();

            if (kelime.ToLower() == "selam")
            {
                KelimeKullan();
            }
            else
            {
                Console.WriteLine("Bomba patlamadı.");
            }
        }

       
        public void KelimeKullan()
        {
            if (KelimeKullanildi != null)
            {
                KelimeKullanildi(); 
            }
        }
    }
}
