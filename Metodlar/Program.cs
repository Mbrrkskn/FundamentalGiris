using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatımı

            /*
             * Metod Nedir : Belirli bir işlevi yerine yetirmek icin kullanilan bir kod blogudur
             * Metodlarin tipleri => geriye deger donen yada donmeyen metodlar 
             *                       Eger metodlar geriye deger donmeyecek ise void olarak isaretlenmek zorundadir.
             *                       Eger DEger Donecek ise tipi belirtmek zorundadir.
             * Butun metodlar parametrik şekilde olabilir.
             * Yani bir meyoda tipini belirtmek şarti ile istediginiz kadar parametre gonderebilirsiniz.
             * 
             * Faydalari : Kodun tekrarini engeller. Tekrar kullanimi saglar
             * Kodun okunakligini arttirir. Programi daha moduler hale getirir.
             * 
             * Tanimlama Sekli 
             * 
             * [Erişim belirteci] [Geri Donus Tipi] [MetodAdi](aldigi parametreler) 
             * {
             *    Kodlar buraya...
             * }
             * 
             * [Erişim belirteci] => metoda kimlerin ulasabilecegini belirler 
             *                       public , private ,internal protected seklinde degerler alabilir.
             *                       public => genel kullanima acik demek. Simdilik bunu kullanacagiz.
             * 
             * [Geri Donus Tipi] => Eger bir sey donmeyecekse void olarak isaretlenmelidir.
             *                      Donus tipi int,float,string,datetime v.b.. degerler donebilir.
             *                      Eger geri donus tipi tanimliyse metod sonunda mutlaka return ifadesi olmak zorundadir.
             *                      
             * (aldigi parametreler) => metoda gondermek istedigimiz verilerdir. Ayrac olarak , ile ayrilirlar
             *                          MEtoda gelecek olan parametrelerin mutlaka tiplerinin de yazilmasi zorunludur.
             *  Metodlarin tanimlandigi yerler genelde  class icerisindedir.                     
             */
            #endregion

            #region Metod imzasi.
            /*
             * Aldgi parametreler farkli oldugu surece ayni isimde metod yazilabilir.
             * Buna metod overload yani aşırı yuklenmesi denir.
             * 
             * Metodun geri donus tipi imzaya dahil degildir.
             * 
             * 
             */

            #endregion



            #region İki sayıyı Toplayacak metod
            //public static void  Topla (int sayi1,int sayi2)
            //public static long  Topla (int sayi1,int sayi2)

            //#endregion
            //Topla(3, 5);
            //decimal toplam = Topla(3.5m, 5.3m);
            //Console.WriteLine($"Float Toplam:{toplam.ToString("0.00")}");




            // public static void  Topla (int sayi1,int sayi2)
            // {
            //     Console.WriteLine($"Toplam:{sayi1 + sayi2}");

            // }
            // public static long Topla(long sayi1, long sayi2)
            // {
            //     return sayi1 + sayi2;
            // }
            // public static int Topla(byte sayi1, byte sayi2)
            // {
            //    return sayi1 + sayi2;
            // }
            //public static float Topla(float sayi1, float sayi2)
            //{
            // return sayi1 + sayi2;
            //}
            //public static double Topla(double sayi1, double sayi2)
            //{
            // return sayi1 + sayi2;
            //}

            /// <summary>
            ///  Gelen iki decimal sayiyi toplar ve sonucu geri döner
            /// </summary>
            /// <param name="sayi1">Decimal tipinden olmalıdır</param>
            /// <param name="sayi2">Decimal tipinden olmalıdır</param>
            /// <returns>Geriye decimal döner</returns>
            //public static decimal Topla(decimal sayi1, decimal sayi2)
            //   {
            //    return sayi1 + sayi2;
            //   }

            #endregion

            #region Sorular
            /*
             * 1-Kensisine gelen mesajı ekrana yazan metod EkranaYaz()
             * 2-Ekrandan sayi okutup int donen sayioku metodu yazınız
             * 3-İki adet integer deger alıp bir adet string operator alsın
             *   Gelen operatore gore 4 islem sonucunu ekrana yazdırsın
             * 4-Faktoriyel alan metod yazınız
             * 5-Verilen sayınnın verilen üssünü alacak metod long UssunuAl(2,4)
             * 6
             */


            // 1-Kensisine gelen mesajı ekrana yazan metod EkranaYaz()
            //EkranaYaz("Merhabalar. Bu bir mesajdır");
            //EkranaYaz("Müberra Keskin :) ");
            //Console.ReadKey();

            //static void EkranaYaz(string mesaj)
            //{
            //    Console.WriteLine(mesaj);
            //}


            //  2-Ekrandan sayi okutup int donen sayioku metodu yazınız
            //static int SayiOku()
            //{
            //    Console.Write("Bir sayı giriniz: ");
            //    string input = Console.ReadLine();
            //    int sayi;

            //    while (!int.TryParse(input, out sayi))
            //    {
            //        Console.WriteLine("Geçersiz giriş, lütfen bir sayı giriniz.");
            //        input = Console.ReadLine();
            //    }

            //    return sayi;
            //}


            //{
            //    int sayi = SayiOku();
            //    Console.WriteLine("Girilen sayı: " + sayi);
            //}

            //2-İkinci yapılışı 
            //int sayi = SayiOku("Bir sayi giriniz:");
            //double sayi1 = (double)SayiOku("Double bir sayi giriniz:");
            //double sayi2 = (double)SayiOku("Double bir sayi giriniz:");
            //Console.WriteLine( DortIslem(sayi1, sayi2,'/'));

            //2.soru 2 yöntem ile yapılışı
            //    public static int SayiOku(string mesaj)
            //    {
            //        int sayi;
            //        bool sonuc = true;
            //        do
            //        {
            //            Console.WriteLine(mesaj);
            //            sonuc = int.TryParse(Console.ReadLine(), out sayi);

            //        } while (!sonuc);
            //        return sayi;
            //    }
            //    public static void EkranaYaz(string mesaj)
            //    {
            //        Console.WriteLine(mesaj);
            //    }




            // 3-İki adet integer deger alıp bir adet string operator alsın
            //Gelen operatore gore 4 islem sonucunu ekrana yazdırsın
            //static void IslemYap(int sayi1, int sayi2, string operatoru)
            //{
            //    int sonuc = 0;
            //    bool gecerliIslem = true;

            //    switch (operatoru)
            //    {
            //        case "+":
            //            sonuc = sayi1 + sayi2;
            //            break;
            //        case "-":
            //            sonuc = sayi1 - sayi2;
            //            break;
            //        case "*":
            //            sonuc = sayi1 * sayi2;
            //            break;
            //        case "/":
            //            try
            //            {
            //                sonuc = sayi1 / sayi2;
            //            }
            //            catch (DivideByZeroException)
            //            {
            //                Console.WriteLine("Bölme işleminde bölen 0 olamaz!");
            //                gecerliIslem = false;
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Geçersiz operatör!");
            //            gecerliIslem = false;
            //            break;
            //    }

            //    if (gecerliIslem)
            //    {
            //        Console.WriteLine($"Sonuç: {sayi1} {operatoru} {sayi2} = {sonuc}");
            //    }
            //}

            //int sayi1 = SayiOku();
            //int sayi2 = SayiOku();

            //Console.Write("Bir operatör giriniz (+, -, *, /): ");
            //string operatoru = Console.ReadLine();

            //IslemYap(sayi1, sayi2, operatoru);

            //3.soru İkinci yöntem
            //public static double DortIslem(double sayi1, double sayi2, char islem)
            //{

            //    double sonuc = 0;
            //    switch (islem)
            //    {
            //        case '+':
            //            return sayi1 + sayi2;
            //        case '-':
            //            return sayi1 - sayi2;
            //        case '/':
            //            try
            //            {
            //                return sayi1 / sayi2;
            //            }
            //            catch (Exception ex)
            //            {

            //                Console.WriteLine("Sifira bolme hatasi");
            //                return 0;
            //            }
            //        case '*':
            //            return sayi1 * sayi2;
            //        default:
            //            Console.WriteLine("Beklenmedik bir durum olustu.");
            //            return 0;
            //    }
            //}


            //4-Faktoriyel alan metod yazınız
            //            Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz: ");
            //            int sayi = int.Parse(Console.ReadLine());
            //            Console.WriteLine($"{sayi}! = {Faktoriyel(sayi)}");

            //    }
            //           static long Faktoriyel(int n) => n <= 1 ? 1 : n * Faktoriyel(n - 1);
            //}

            //4.soru 2. yöntemi
            //public static long Faktoryel(int sayi)
            //{
            //    long sonuc = 1;
            //    for (int i = 1; i < sayi; i++)
            //    {
            //        sonuc *= i;
            //    }
            //    return sonuc;
            //}

            //4.soru Recursive metod ile yapılışı
            // Recursive metod ile faktoryel

            //public static long FaktoryelRecursive(int sayi)
            //{

            //    //if (sayi < 0)
            //    //{
            //    //    Console.WriteLine("Negatif sayi girilemez");
            //    //    return 1;
            //    //}
            //    if (sayi >= 2)
            //    {
            //        return sayi * FaktoryelRecursive(sayi - 1);
            //    }
            //    else
            //    {
            //        return 1;
            //    }
            //}


            // 5 - Verilen sayınnın verilen üssünü alacak metod long UssunuAl(2,4)

            //try-catch ile üssü hesaplama işlemi , ben yaptım.
            //try
            //{
            //    Console.Write("Taban sayıyı girin: ");
            //    double taban = double.Parse(Console.ReadLine());

            //    Console.Write("Üs sayısını girin (kesirli olabilir, örn. 0.5): ");
            //    double us = double.Parse(Console.ReadLine());

            //    double sonuc = Math.Pow(taban, us);  
            //    Console.WriteLine($"Sonuç: {sonuc}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Geçersiz giriş. Lütfen sayısal bir değer girin.");
            //}


            //Arkadaşımın yaptığı çözüm 
            Console.Write("Taban sayıyı girin: ");
            double taban = double.Parse(Console.ReadLine());

            Console.Write("Üs sayısını girin (örnek: 1/3): ");
            string usGirdisi = Console.ReadLine();
            double us = KesirHesapla(usGirdisi);

            double sonuc = UsHesapla(taban, us);
            Console.WriteLine($"Sonuç: {sonuc}");
        }

        static double KesirHesapla(string kesir)
        {
            // Kesirli sayıyı kontrol et
            if (kesir.Contains("/"))
            {
                string[] payPayda = kesir.Split('/');
                double pay = double.Parse(payPayda[0]);
                double payda = double.Parse(payPayda[1]);
                return pay / payda;
            }
            else
            {
                return double.Parse(kesir);
            }
        }

        public static double UsHesapla(double taban, double us)
        {
            return Math.Pow(taban, us);

        }
        #endregion
    }
}
 

        
    


