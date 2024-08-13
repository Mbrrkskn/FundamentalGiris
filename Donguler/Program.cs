namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatımı
            /* 3 adet dongumuz var
             * for,while,do-while
             * foreach dongu degildir.Iterasyondur.yani foreach calısabilmesi için mutlaka elimizde bir dataset olması gerekir
             * Yani ya bir dizi olacak yada bir liste vb. bir dataset olacak
             * 
             */

            #endregion

            #region For Dongusu

            /*
             * For dongusu için bir başlangıc degeri gerekir.Bir kosul olacak ve artım miktarı olacak.
             * Syntax for(baslangıc;kosul;artım)
             * {
             * }
             * 
             */

            //int temp = 0;
            //int sayi = temp++;
            //sayi = ++temp;

            ////1-10 arasındaki sayıları bastıralım
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////10-20 arasındaki sayıları bastıralım
            //for (int i = 10; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////50-20 arasındaki sayıları bastıralım
            //for (int i = 50; i >= 20; i--)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Ornke 1
            //İlk yüz sayının toplamı ve ortalaması

            // int toplam = 0;
            // for (int i = 1; i <= 100; i++)
            // {
            //     toplam += i;
            // }

            // //iki integer sayının bolumu ıntegerdır.kusuratlı cıkması için degerlerden
            // //birisinin kesirli bir sayıya cevrilmesi gerekir
            ///* float ortalama = toplam / 100f;
            // ortalama = (float)toplam/100;
            //ortalama =toplam/(float)100;
            //ortalama =Convert.ToSingle(toplam)/(float)100;

            // */
            // double ortalama = (double)toplam / 100;

            // Console.WriteLine("İlk 100 sayının toplamı: " + toplam);
            // Console.WriteLine("İlk 100 sayının ortalaması: " + ortalama);




            #endregion

            #region Ornek2

            /* 2015 ile 2025 arasındaki yılları ekrana basınız.
             * ancak pandemi yılını es geçiniz (2020)
             * 
             *  for (int i = 2015; i < 2026; i++)
            {
             * //if (i==2020)
               // continue;
               //Console.WriteLine(i);
            }
             */

            //ikinci yontem
            //for (int i = 2015; i < 2026; i++)
            //{
            //    if(i != 2020)
            //    Console.WriteLine(i);
            //}

            //Donguyu kırmak için break kullanılır

            //for (int i = 2015; i < 2026; i++)
            //{
            //    if (i==2020)
            //    break;
            //  Console.WriteLine(i);
            //}

            //Programdan çıkmak için return kullanılır
            //for (int i = 2015; i < 2026; i++)
            //{
            //    if (i == 2020)
            //        return;
            //   Console.WriteLine(i);
            //}
            //Console.WriteLine("Dongu sonu");


            #endregion



            #region While dongusu

            /*
             * while kosul dogru oldugu sürece işlemleri gerçekleştiren bir dongudur
             * genel syntax
             * while(kosul)
             * {
             * kosul dogru oldugu surece
             * }
             * 
             */
            #region 0 girilene kadar ekrandan okutulan sayıları toplayıp yazdıralım

            //int toplam = 0, sayi = 1,sayac=0;
            //while(sayi!=0)
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi; //toplam =toplam +sayi; demek
            //    sayac++; //sayac =sayac +1;

            //}
            //Console.WriteLine("Girilen sayıların adedi" + sayac + "Toplamı:" + toplam);
            //Console.WriteLine("Girilen sayıların adedi {0} Toplamı : {1}",sayac,toplam);
            //Console.WriteLine($"Girilen sayıların adedi {sayac} Toplamı : {toplam}");

            #region Sayı Tahmin oyunu :  1-50 arası sayı tutulacak.Kullanıcıya 5 tahmin hakkı verilecek
            //eger tutulandan daha buyuk sayı girilirse daha kucuk bir sayı giriniz mesajı
            //eger tutulandan daha kucuk sayı girilirse daha buyuk bir sayı giriniz mesajı
            //oyunu bildiyse eger kacıncı yada tahminde bildiğini yazdırın
            //en sonunda oyuna devam etmek istiyor musunuz sorusunu alın. ve ona gore tekrarlatın


            string devametmekıstıyormu;
            do
            {

                Random rnd = new Random();
                int tutulansayi = rnd.Next(1, 50);
                byte tahminHakki = 5;
                int kullaniciTahmini;
                bool bilmedurumu = false;


                Console.WriteLine("1 ile 50 arasında bir sayı giriniz");

                while (tahminHakki > 0)
                {
                    Console.WriteLine();
                    Console.Write("Tahmininizi giriniz: ");
                    kullaniciTahmini = int.Parse(Console.ReadLine());

                    if (kullaniciTahmini > tutulansayi)
                    {
                        Console.WriteLine("Daha küçük bir sayı giriniz.");
                    }
                    else if (kullaniciTahmini < tutulansayi)
                    {
                        Console.WriteLine("Daha büyük bir sayı giriniz.");
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler sayıyı " + (6 - tahminHakki) + ". tahmininizde bildiniz");
                        bilmedurumu = true;
                        break;
                    }

                    tahminHakki--;

                    if (tahminHakki > 0 && !bilmedurumu)
                    {
                        Console.WriteLine("Kalan tahmin hakkınız: " + tahminHakki);
                    }
                    else if (tahminHakki == 0 && !bilmedurumu)
                    {
                        Console.WriteLine("Tahmin hakkınız kalmadı. Tutulan sayı: " + tutulansayi);
                    }
                }
                Console.Write("Oyuna devam etmek istiyor musunuz? (Evet için 'e', Hayır için 'h' yazınız): ");
                devametmekıstıyormu = Console.ReadLine().ToLower();

            }
            while (devametmekıstıyormu == "e");

            Console.WriteLine("Oyun bitti. Tekrar görüşmek üzere!");




            #region Fibonacci 
            //1,1,2,3,5,8,13,21,34.... kendinden onceki iki sayının toplami şeklindedir.
            // ilk 20 fibanocci sayisini ekrana bastirin.

            int n = 20; 
            int a = 0, b = 1; 
            int sayi = 0; 

            Console.WriteLine("İlk 20 Fibonacci sayısı:");

            while (sayi < n)
            {
                Console.Write(a + " "); 
                int next = a + b;
                a = b; 
                b = next; 
                sayi++; 
            }

            Console.WriteLine(); 

            #endregion
            #endregion
            #endregion

            #endregion
        }

    }
}


