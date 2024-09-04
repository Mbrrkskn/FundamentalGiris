using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class.Bilgisayarlar
{
    public class Bilgisayar
    {
        public AnaKart AnaKart { get; set; }
        public Cpu Cpu { get; set; }
        public List<Ram> Ramlar { get; set; }
        public List<EkranKarti> EkranKartlari { get; set; }

        public List<HardDisk> Diskler { get; set; }


        //Kurucu metod yada yapıcı metod da denir
        //Terminolojide constructar olarak geçeer
        //Eger propertylere ilk deger ataması yapılmış ise
        //Once propertylere deger atanır sonra constructor calıstırılır
        //Consturctler'lar class ismi ile ayni olmak zorundadır
        //Constructer'lar geri donus tipi yoktur
        public Bilgisayar()
        {

            Cpu = new Cpu("AMD");
            Ramlar = new List<Ram>() { new Ram { Fiyat = 5 }, new Ram { Fiyat = 5 } };
            EkranKartlari = new List<EkranKarti>() { new EkranKarti { Fiyat = 10 } };
            Diskler = new List<HardDisk>() { new HardDisk { Fiyat = 30 } };
            AnaKart = new AnaKart();
        }
        public double FiyatHesapla()
        {
            double toplamtutar = 0;
            foreach (var item in Ramlar)
            {
                toplamtutar += item.Fiyat;
            }
            foreach (var item in Diskler)
            {
                toplamtutar += item.Fiyat;
            }
            foreach (var item in EkranKartlari)
            {
                toplamtutar += item.Fiyat;
            }
            toplamtutar += AnaKart.Fiyat;
            toplamtutar += Cpu.Fiyat;

            return toplamtutar;

        }
    }
}
