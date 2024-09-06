using _1_Giris;
using _2_ClassOrnekler.Emlak;
using _3_Class.Bilgisayarlar;
using _3_ClassLib.Personeller;




namespace _4_LibraryKullannımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cpu cpu = new Cpu();
            cpu.Marka = "AMD";
            
            AnaKart anaKart = new ();

            //Abstract class'lardan instance alinamaz.
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
           // Kisi = new Kisi("ayse", "kaya");

            //SatisMuduru satisMuduru = new SatisMuduru("Ali", "Yilmaz");
            //SatisElemani satisElemani = new SatisElemani();
            //Console.WriteLine(satisElemani);

            //Kisi kisi = new Kisi();

            //Console.WriteLine(satisElemani.Prim);
            // satisMuduru.Prim = 100;

            //Emlak Bilgilerini Yazdırma
            EmlakTipi emlakTipi = new EmlakTipi(
           ilanNo: 1,
           ilanTarihi: new DateTime(2024, 9, 4),
           kimden: "Sahibinden",
           tapuDurumu: "Kat Mülkiyeti",
           adres: "Fatih Mah. No:24",
           fiyat: 400000,
           satilik: true,
           metreKare: 125,
           konut: "Daire",
           arsa: "",
           isYeri: "",
           konutProjeleri: "Lüks Konut Projesi"
           );

            Console.WriteLine($"EmlakTipi: İlan No: {emlakTipi.İlanNo}, Fiyat: {emlakTipi.Fiyat} TL, Konut: {emlakTipi.Konut}, Proje: {emlakTipi.KonutProjeleri}");
        

        Console.WriteLine("Hello, World!");
        }
    }
}
