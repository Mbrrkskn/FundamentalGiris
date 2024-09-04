using _3_Class.Bilgisayarlar;
using _3_Class.Personeller;

namespace _4_LibraryKullannımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cpu cpu = new Cpu();
            cpu.Marka = "AMD";
            
            AnaKart anaKart = new ();

            //BaseItem baseItem = new BaseItem();
            //baseItem.Marka = "xyz";
            //baseItem.Model = "abc";
            //baseItem.Fiyat = 12;

            Bilgisayar bilgisayar = new Bilgisayar ();
            OyuncuBilgisayari oyuncu = new();


            //Bilgisayar bilgisayar = new Bilgisayar ();
            //bilgisayar.AnaKart = anaKart;
            //bilgisayar.Cpu = cpu;
            //bilgisayar.Ramlar = new List<Ram> ();
            //bilgisayar.Ramlar.Add(new Ram() { Marka = "Kingston" });
            //bilgisayar.Ramlar.Add(new Ram() { Marka = "Corsair" });
            //bilgisayar.Diskler = new List<HardDisk>();
            //bilgisayar.Diskler.Add(new HardDisk { DiskTipi = DiskTipi.SSD, Marka = "Seagate" });
            //bilgisayar.EkranKartlari = new List<EkranKarti>();
            //oyuncu = null;

            Console.WriteLine("Oyuncu bilgisayari Fiyati :" + oyuncu.FiyatHesapla());
            Console.WriteLine("bilgisayar Fiyati :" + bilgisayar.FiyatHesapla());
            SatisMüdürü satisMuduru = new SatisMüdürü();
            SatisElemani satisElemani = new SatisElemani();
            // Console.WriteLine(satisElemani.Prim);
            // satisMuduru.Prim = 100;
            satisMuduru.BagliElemanlar.Add(satisElemani);  //SatisMüdürü'ne bağlı satış elemanları ekliyorum
            Console.WriteLine($"Satış Müdürü'nün Maaşı: {satisMuduru.Maas}");  //Satış Müdürü'nün maaşını ve primini hesaplıyoruz




            Console.WriteLine("Hello, World!");
        }
    }
}
