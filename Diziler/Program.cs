namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatımı
            /*
             * Birden fazla aynı tipten veriyi bir arada tutmamızı sağlayan nesnelerdir.
             * Dizilerin eleman sayısı sabittir
             * Sonradan değiştirilemezler.
             * 
             * index her zaman 0'dan başlar
             * 
             * Çok karşılaşılan hata:
             * Index was outside the bound of the array
             * Bu hata dizinin eleman sayısının dısında bir işlem yapılıyor demektir
             * 
             * tanımlama kuralı: <veri tipi>[] diziAdi;
             *                   int[] sayilar;
             *                   DateTime[] tarihler;
             *                   bool[] test;
             * 
             */

            #endregion
            #region Dizi Tanımlama ve Deger Atama

            //int[] notlar; //Burada dizi tanımlanmış olsada eleman sayısı belli değildir.
            //int[] sayilar = new int[10]; //Bu 10 elemanlı bir dizidir.Default değerleri sıfırdır.
            //int[] sayilar2 = {0,1,2,3,4,5,6,7,8,9}; //Buda 10 elemanlı bir dizidir.Burada ilk değer ataması yapılmıştır.

            //Tek tek deger atama için dizi index kullanılır
            //sayilar[3] = 20; //Burada 4.elemana 20 değeri atanmıştır.

            /*Dizilerin ekrana bastırlması için bildiğimiz dongülerin hepsi gecerlidir
            Genelde for dongusu kullanılır.
            Ancak sıklıkla foreach'de kullanılır.
            foreach dongu degıldır. Aradaki farl 1-10 arasındaki sayıları foreach ile ekrana yazdıramayız
            foreach için mutlaka bir veri seti gereklidir.
            Bu ister dizi ister
            */
            //for (int i = 200; i>100; i--)
            //{}

            #region var keywordu
            /*
             * var javascriptdeki var benzeridir.
             * runtime sırasındaki veri tipi belli olur
             * Veri tipi belli olduktan sonrasında artık baska veri tipi atilamaz
             */
            //var temp = DateTime.Now;
            //temp ="ali veli"; //burası hata verecektir
            #endregion

            //foreach ile kullanımı
            //foreach(var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}

            //for kullanımı
            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    Console.WriteLine(sayilar2[i]);
            //}
            #endregion

            #region 20 kişilik bir sınıfın notlarını rastgele atama yapalım
            //int[] notlar = new int[20];
            //Random rnd = new Random();

            //Foreach ile donerken deger ataması yapılamaz
            //sık yapılan hatalardandır
            //foreach (var item in notlar)
            //{
            //    item = rnd.Next(20,100);
            //}

            //for (int i=0; i<notlar.Length; i++)
            //{
            //    notlar[i] = rnd.Next(20, 100);
            //}
            //foreach(var item  in notlar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region string'e farklı bakıs

            //string str = "Beşiktaş";
            //for (int i = 0; i<str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            //foreach (char ch in str)
            //{
            //    Console.WriteLine(ch);
            //}

            #endregion

            #region Cok Boyutlu Diziler

            /*
             * İki boyutlu bir dizi için int[,] matris = new int[2,3]
             * 3 Boyutlu bir dizi için int[,,] küp = new int[3,3,3];
             * 
             * 
             */
            // Random random = new Random();   
            //int[,] matris = new int[3, 3];
            //Console.WriteLine($"Matrisin 1. Boyutu {matris.GetLength(0)}\nMatrisin 2.Boyutu {matris.GetLength(1)}");

            //for (int i = 0; i < matris.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        Console.WriteLine(matris[i,j]);
            //    }
            //}

            #region 20 kişilik bir sınıfın 2 vize 1 final notunu tuyacak dizyi tanımlayınız

            //int[,] notlar2 = new int[20, 3];

            //for (int i = 0; i < notlar2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < notlar2.GetLength(1); j++)
            //    {
            //        notlar2[i, j] = rnd.Next(20, 101);
            //    }

            //}
            //for (int i = 0; i < notlar2.GetLength(0); i++)
            //{
            //    int vize1 = notlar2[i, 0];
            //    int vize2 = notlar2[i, 1];
            //    int final = notlar2[i, 2];

            //    double ortalama = (vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4);

            //    if (ortalama >= 50)
            //    {
            //        Console.WriteLine($"Öğrenci {i + 1}: Ortalama: {ortalama:F2} - Geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Öğrenci {i + 1}: Ortalama: {ortalama:F2} - Kaldı");
            //    }

            //Bu dizideki öğrencilerin geçme kalma durumunu ekrana basınız
            //vizelerin toplamının %30 finalinin %70'i alınacak
            //50 ve üzeri geçti olacak
            #endregion

            #endregion

            #region Dizideki en kucuk ve en buyuk elemanı bulma

            //int[] sayilar = new int[20];

            //Random rnd = new Random(); 

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = rnd.Next(1, 100);
            //}

            //int enKucuk = sayilar[0];
            //int enBuyuk = sayilar[0];

            //for (int i = 1; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] < enKucuk)
            //    {
            //        enKucuk = sayilar[i];
            //    }

            //   else if (sayilar[i] > enBuyuk)
            //    {
            //        enBuyuk = sayilar[i];
            //    }
            //}

            //Console.WriteLine("Dizideki en küçük sayı: " + enKucuk);
            //Console.WriteLine("Dizideki en büyük sayı: " + enBuyuk);

            //ikinci yöntem
            //int[] sayilar2 = new int[20];
            //for (int i =0; i < sayilar2.Length; i++)
            //{
            //    sayilar2[i] = rnd.Next(0, 100);
            //    Console.WriteLine(sayilar2[i]);
            //}
            //Console.WriteLine(sayilar2.Max());
            //Console.WriteLine(sayilar2.Min());
            #endregion


            #region Olusturdugumuz int[] dizileri sıralayın
            //küçükten büyüğe ,büyükten küçüğe olarak

            int[] sayilar2 = new int[20];
            Random rnd = new Random();

            //  rastgele sayılar atıyorum
            for (int i = 0; i < sayilar2.Length; i++)
            {
                sayilar2[i] = rnd.Next(0, 100);
                Console.WriteLine(sayilar2[i]); // diziyi ekrana yazdırıyoruz
            }

            // küçükten büyüğe sıralama
            for (int i = 0; i < sayilar2.Length - 1; i++)
            {
                for (int j = 0; j < sayilar2.Length - i - 1; j++)
                {
                    if (sayilar2[j] > sayilar2[j + 1])
                    {
                        // elemanları takas yapıyoruz
                        int temp = sayilar2[j];
                        sayilar2[j] = sayilar2[j + 1];
                        sayilar2[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nKüçükten büyüğe sıralanmış dizi:");
            foreach (int sayi in sayilar2)
            {
                Console.WriteLine(sayi);
            }

            //  büyükten küçüğe sıralama
            for (int i = 0; i < sayilar2.Length - 1; i++)
            {
                for (int j = 0; j < sayilar2.Length - i - 1; j++)
                {
                    if (sayilar2[j] < sayilar2[j + 1])
                    {
                        // elemanları takas yapıyoruz
                        int temp = sayilar2[j];
                        sayilar2[j] = sayilar2[j + 1];
                        sayilar2[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi:");
            foreach (int sayi in sayilar2)
            {
                Console.WriteLine(sayi);
            }


            #endregion
        }
    }
}

