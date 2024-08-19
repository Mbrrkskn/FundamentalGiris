using System.Collections;

namespace ArrayListt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Konu Anlatımı
            /*
             * Simdiye kadar gordugumuz dizilerin ozellikleri 
             * Tip bagımlılıgı,Diğeri ise eleman sayısı bagımlılıgı var.
             * 
             * ArrayList'ler bu problemleri ortadan kaldırır.
             * Bir ArrayList tanimladıgımızda herhangi bir eleman sayısı yada 
             * tip belirtmek zorunda değiliz
             * 
             * ArrayList'ler object turunden degerler aldigindan 
             * her turlu bilgi atilabilir. Ancak arama yada kiyaslama yapildiginda
             * unboxing işlemi yapmak zorundayiz.
             * 
             * Dezavantajı : veriler uzerinde gezerken unboxing islemi yapilmak zorunda.
             * Bu da performans kaybina neden olmaktadir.
             */

            #endregion

            #region Ornek 1

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Ali");
            arrayList.Add(DateTime.Now);
            arrayList.Add(12.5f);
            arrayList.Add(12.5f);
            decimal toplam = 0;
            foreach (var item in arrayList)
            {
                decimal sayi;
                var sonuc = decimal.TryParse(item.ToString(), out sayi);
                if (sonuc)
                {
                    toplam += sayi;
                }
                Console.WriteLine(item);
            }
            Console.WriteLine(toplam);

            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
