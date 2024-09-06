using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.InsanKaynaklari
{
    public class Aday : IBasvuruYap,IYetenekTesti
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public  string Gsm { get; set; }
        public string Eposta { get; set; }
        public string MezunOlduguOkul { get; set; }
        public bool AskerikDurumu { get; set; }
        public bool Cinsiyet { get; set; }
        public  bool MedeniHal { get; set; }
        public string Ehliyet { get; set; }
        public string BildigiDiller { get; set; }
        public string YazilimDilleri { get; set; }
        public bool YetenekTestiSonucu { get; private set; }

        public void BasvuruYap()
        {
            Console.WriteLine($"{Ad} {Soyad}, başvurusunu tamamladı.");
        }
        public void YetenekTestiDegerlendirme(bool basarili)
        {
            YetenekTestiSonucu = basarili;
            string sonuc = basarili ? "Başarılı" : "Başarısız";
            Console.WriteLine($"{Ad} {Soyad}, yetenek testinden {sonuc} oldu.");
        }
        public void BasvuruSonucu()
        {
            if (YetenekTestiSonucu)
            {
                Console.WriteLine($"{Ad} {Soyad} başvurusu olumlu sonuçlandı.");
            }
            else
            {
                Console.WriteLine($"{Ad} {Soyad} başvurusu olumsuz sonuçlandı.");
            }
        }
    }
   
}
