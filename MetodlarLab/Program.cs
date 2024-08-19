namespace MetodlarLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sorular
            /*
             *  1- KdvHesapla(100,20,dahil) => 83.33
             *     KdvHesapla(100,20,haric) => 120
             *  
             *  2-HızHesapla(100km,30 dakika) => 200 km hızla gitmen lazım
             *  
             *  
             *  3-DiziOlusturulsun(elemansayisi) => int tipinden içerisinde 1-100 
             *  rastgele sayıların oldugu bir dizi donecek
             *  
             *  4- SehirGetir(0)=> rastgele bir şehir getirsin.
             *  SehşrGetir(34) => İstanbulu getirsin.
             *  
             *  5-Sesliharfsayisi(string) => 5 adet sesli harf vardır.
             *  a,e,i şeklinde bir çıktı versin.
             *  
             *  6-Sifrele(string) => sifrelenmiş sekilde bastirsin.SifreCoz(sifrelenmiş) => kelime
             *  
             *  7-Klavyeden girilen bir tamsayının basamaklarını ekrana yazdıran metod. BasamakBul(int)
             *  
             */

           
            //1.soru
            double sonucDahil = KdvHesapla(100, 20, "dahil");
            Console.WriteLine($"KDV Dahil Tutar: {sonucDahil}");

            double sonucHaric = KdvHesapla(100, 20, "haric");
            Console.WriteLine($"KDV Hariç Tutar: {sonucHaric}");


            //2.Soru
            Console.Write("Mesafeyi girin (km): ");
            double mesafe = double.Parse(Console.ReadLine());

            Console.Write("Süreyi girin (dakika): ");
            double sure = double.Parse(Console.ReadLine());

            double hiz = HızHesapla(mesafe, sure);

            Console.WriteLine($"{hiz} km/h hızla gitmen lazım.");

            //3.Soru
            Console.WriteLine("Dizinin eleman sayısını giriniz:");
            int elemanSayisi = int.Parse(Console.ReadLine());

            int[] rastgeleDizi = DiziOlusturulsun(elemanSayisi);

            Console.WriteLine("Rastgele oluşturulan dizi: ");
            foreach (int sayi1 in rastgeleDizi)
            {

            Console.WriteLine(sayi1 + " "); 
            }

            //4.soru
            string[] sehirler = {
            "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa",
            "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ",
            "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
            "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars",
            "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya",
            "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş",
            "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt",
            "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa",
            "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman",
            "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova",
            "Karabük", "Kilis", "Osmaniye", "Düzce"
        };
            Console.Write("Bir şehir numarası girin (1-81): ");
            int numara = int.Parse(Console.ReadLine());
            if (numara >= 1 && numara <= 81)
            {
                Console.WriteLine($"Numaraya karşılık gelen şehir: {SehirGetir(numara, sehirler)}");
            }
            else
            {
                Console.WriteLine("Geçersiz numara! Lütfen 1 ile 81 arasında bir numara girin.");
            }
            //5.soru

            Console.Write("Bir kelime girin: ");
            string input = Console.ReadLine();

            SesliHarfSayisi(input);

            //6.soru
            Console.Write("Bir kelime girin: ");
            string kelime = Console.ReadLine();

            // Şifreleme
            string sifrelenmis = Sifrele(kelime);
            Console.WriteLine($"Şifrelenmiş: {sifrelenmis}");

            // Şifreyi çözme
            string cozulmus = SifreCoz(sifrelenmis);
            Console.WriteLine($"Şifre çözülmüş: {cozulmus}");

            //7.soru
            Console.Write("Bir tamsayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            BasamakBul(sayi);

            #endregion


        }

        //1.soru 
        static double KdvHesapla(double tutar, double kdvOrani, string kdvTipi)
        {
            if (kdvTipi == "dahil")
            {
                
                return tutar / (1 + kdvOrani / 100);
            }
            else if (kdvTipi == "haric")
            {
                
                return tutar * (1 + kdvOrani / 100);
            }
            else
            {
                throw new ArgumentException("Geçersiz KDV tipi. 'dahil' veya 'haric' olmalıdır.");
            }
        }

        //2.Soru
        static double HızHesapla(double mesafe, double sureDakika)
        {
            double sureSaat = sureDakika / 60; // Süreyi saate çeviriyoruz
            return mesafe / sureSaat; // Hızı hesaplıyoruz
        }

        //3.soru
        static int[] DiziOlusturulsun(int elemanSayisi)
        {
            Random rnd = new Random();
            int[] dizi = new int[elemanSayisi];

            for (int i = 0; i < elemanSayisi; i++)
            {
                dizi[i] = rnd.Next(1, 101); // 1-100 arasında rastgele sayı
            }

            return dizi;
        }

        //4.Soru
        static string SehirGetir(int numara, string[] sehirler)
        {
            return sehirler[numara - 1]; // Dizideki indeksi hesaplarken numara - 1 kullanılır
        }

        //5.soru
        static void SesliHarfSayisi(string kelime)
        {

            char[] sesliHarfler = { 'a', 'e', 'i', 'o', 'u','ö','ü', 'A', 'E', 'I', 'O','Ö','Ü', 'U','ı', 'İ' };
            List<char> bulunanSesliHarfler = new List<char>();

            int sesliHarfSayisi = 0;

            foreach (char harf in kelime)
            {
                if (Array.Exists(sesliHarfler, sesli => sesli == harf))
                {
                    sesliHarfSayisi++;
                    bulunanSesliHarfler.Add(harf);
                }


                Console.WriteLine($"{sesliHarfSayisi} adet sesli harf vardır.");
                Console.WriteLine($"Bulunan sesli harfler: {string.Join(", ", bulunanSesliHarfler)}");
            }
        }

        //6.soru
        static string Sifrele(string kelime)
        {
            // Her harfi ASCII değerine 3 ekleyerek şifreleme
            char[] karakterler = kelime.ToCharArray();
            for (int i = 0; i < karakterler.Length; i++)
            {
                karakterler[i] = (char)(karakterler[i] + 3);
            }
            return new string(karakterler);
        }

        static string SifreCoz(string sifrelenmis)
        {
            // Her harfi ASCII değerinden 3 çıkararak çözme
            char[] karakterler = sifrelenmis.ToCharArray();
            for (int i = 0; i < karakterler.Length; i++)
            {
                karakterler[i] = (char)(karakterler[i] - 3);
            }
            return new string(karakterler);
        }

        //7.soru
        static void BasamakBul(int sayi)
        {
            
            string sayiStr = sayi.ToString();

            Console.WriteLine($"{sayi} sayısının basamakları:");

            foreach (char basamak in sayiStr)
            {
                Console.WriteLine(basamak);
            }
        }
    }
}
