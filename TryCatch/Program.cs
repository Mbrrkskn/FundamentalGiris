namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatımı
            /*try catch hata yakalamakta kullanılan bir yapıdır.
             * 
             * Hata => Hatalar 3 ana baslık altında toplanabilir
             * 1- Syntax hataları (Genelde Ide yakalıyor ve daha derlemeden hatanın altını cızıyor
             * 2-Run Time sırasında cıkacak hatalar.Calışma zamanı hataları sıfıra bolme hatası,
             * tıp donusum hatası.Input output hataları vb.
             * 3-Mantık hataları => Programcılar tarafından yapılan hatalardır.
             * Bulunması ve çözülmesi biraz daha zordur.
             * Debug yapılarak çözümlenir.
             * 
             * 
             * Kullanımı 
             * try
             * {
             * Calıstırılacak kodlar buraya
             * }
             * catch (Expection ex)
             * {
             * Hata yakalandıktan sonra yapılacak ısler buraya
             *
             * }
             * finally //zorunlu değil her zaman kullanmak zorunda değiliz
             * {
             * Hata olsun olmasın mutlaka burayada ugrayacak
             * }
             */

            #endregion

            #region Ornek Ikı sayıyı bolme durumu
            //try
            //{
            //    int sayi1, sayi2;
            //    Console.WriteLine("Birinci sayiyi giriniz.");
            //    sayi1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("İkinci sayiyi giriniz.");
            //    sayi2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Bolum:{sayi1/sayi2}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Sıfıra bolme hatası olustu");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("duzgun formatta sayı giriniz");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Çok büyük sayı girdiniz");
            //}
            //catch (Exception ex)  //Burada Exception ile hata yakalanacak ise en sona atılır
            //{
            //    Console.WriteLine("Bilinmeyen bir hata olustu");
            //}

            #endregion

            #region Kontrollu sayı cevrılmesı
            //int sayi1, sayi2;
            //float fsayi;
            //double dsayi;
            //DateTime trh;
            //bool sonuc1, sonuc2;
            //Console.WriteLine("Birinci sayiyi giriniz");
            //sonuc1 = int.TryParse(Console.ReadLine(), out sayi1);
            //Console.WriteLine("Ikinci  sayiyi giriniz");
            //sonuc2 = int.TryParse(Console.ReadLine(), out sayi2);


            //if (sonuc1 == true && sonuc2 == true)
            //{
            //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));
            //}

            //sonuc1 = float.TryParse(Console.ReadLine(), out fsayi);
            //Console.WriteLine("Float:" + fsayi.ToString("0.00"));
            //sonuc1 = double.TryParse(Console.ReadLine(), out dsayi);
            //Console.WriteLine("Decimal:" + dsayi.ToString("0.00"));

            //sonuc1 = DateTime.TryParse("01.01.2000", out trh);
            //Console.WriteLine("Tarih:" + trh);



            #endregion
        }
    }
}
