namespace RefOutKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatımı
            /*
             * ref ve out c'deki pointer mantıgı ile aynıdır
             * Yani metdolara deger turundeki verilerin referans turunden
             * gecirilmesini sağlar
             * 
             * ref kullanılırken varsayılan deger atanması zorunludur
             * out için boyle ilk deger atanması 
             * 
             */


            #endregion

            #region Out Ornegi
            //    int result =12;
            //    Console.WriteLine(SayiCevirmeyiDene("30",out result));
            //    int toplam, fark;
            //    long carpim;
            //    double bolum;
            //    DortIslem(3, 5, out toplam, out fark, out carpim, out bolum);
            //    Console.WriteLine($"3 ve 5 'in Toplam:{toplam} Fark:{fark} Carpım:{carpim} Bolum:{bolum}");
            #endregion

            #region ref ornegi
            int a = 2;
           // int toplam = testTopla(5, ref a);
            // Console.WriteLine(toplam);
            int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            DiziElelmanSayisiArttir(ref sayilar, 10);
            Console.ReadKey();
            #endregion
        }
        public static void DiziElelmanSayisiArttir(ref int[] sayilar, int elemansayisi)
        {
            int[] yeniDizi = new int[elemansayisi];
            for (int i = 0; i < sayilar.Length; i++)
            {
                yeniDizi[i] = sayilar[i];
            }
            sayilar = yeniDizi;
        }

        public static int testTopla(int sayi1,ref int sayi2)
        {
            sayi2 = 5;
            return sayi1 + sayi2;
        }
        public static bool SayiCevirmeyiDene(string deger, out int sonuc)
        {
            //out olarak işaretlenmiş olan parametreye deger atanmsı zorunludur
            try
            {
                sonuc = int.Parse(deger);
                return true;
            }
            catch (Exception e)
            {
                sonuc = 0;
                return false;
            }
        }
   
        public static bool DortIslem(int sayi1,int sayi2,out int toplam,out int fark, out long carpim,out double bolum)
        {
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            if(sayi2 ==0)
            {
                bolum = 0;
                return false;
            }
            bolum = (double)sayi1/ sayi2;
            return true;
        }
    }
}
