using _2_ClassOrnekler.Otomotiv;
using _2_ClassOrnekler.Otomotiv.Otomobil;
using _2_ClassOrnekler.Otomotiv.Ticariler.Kamyonlar;

namespace _2_ClassOrnekler
{
    internal class Program
    {
        //struct'lar tutulurken 
        static void Main(string[] args)
        {
            
            #region Class Instance Alma
            //1.Yol
            Kitap kitap = new Kitap();
            kitap.KitapAdi = "İnce Memed";
            kitap.Yazar = "Yasar Kemal";
            kitap.BaskiYili = new DateOnly(1967,1,1);
            kitap.SayfaSayisi = 300;
            kitap.YayınEvi = "YKB";


            //2.Yol object initilation

            Kitap kitap2 = new Kitap()
            {
                Yazar = "Orhan Pamuk",
                YayınEvi="YKB",
                KitapAdi ="Yeni Hayat",
                BaskiYili=new DateOnly(2000,1,1),
                SayfaSayisi = 250,
                Barkod = "123123123"
            };

            //enum içeren classlardan instance alma

            Otomobil otomobil = new Otomobil();
            otomobil.KasaTipi = KasaTipi.Sedan;
            otomobil.YakitTipi =YakitTipi.Dizel;
            otomobil.Cekis = Cekis.ArkadanItıs;
            otomobil.Marka = "BMW";
            otomobil.Model = "3.20";

            Kamyon kamyon = new Kamyon();
           // kamyon.UstYapi = UstYapi.AcıkKasa;

            //kasaların hepsini çağırma
            var kasalar = Enum.GetNames(typeof(KasaTipi));
            foreach (var item in kasalar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Enum.GetValues(typeof(KasaTipi)));
            Console.WriteLine(Enum.GetNames(typeof(KasaTipi)));

            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
