namespace _28_DelegatettenLamdayaGecis
{

    public delegate long MyDelegate(int sayi);
    public delegate bool TekmiCiftmi(int sayi);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate'lerin Lamda Exppresion'a Evrim Sureci

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
           
            
            MyDelegate delege1 = new MyDelegate(KareAl);
            MyDelegate delege2 = delegate (int sayi) { return sayi * sayi; };
            MyDelegate delege3 = (int sayi) => { return sayi * sayi; };
            MyDelegate delege4= sayi => sayi * sayi;
       
            TekmiCiftmi tekcift = delegate (int sayi) { return sayi % 2 == 0 ? true : false; };
            TekmiCiftmi tekcift1 = (int sayi) => { return sayi % 2 == 0 ? true : false; };
            TekmiCiftmi tekcift2 = sayi => sayi % 2 == 0;

            Console.WriteLine(tekcift2.Invoke(3));

            var liste1 = list.Where(sayi => tekcift(sayi));
            var liste2 = list.Where(sayi => tekcift1(sayi));
            var liste3 = list.Where(p => tekcift2(p));
            var liste4 = list.Where(sayi => sayi%2 == 0);
            var liste5 = list.Where(sayi => sayi%3 == 0);

            List<string> sehirler = new List<string> { "Adana", "Mus", "Van", "Ankara", "Izmır" };
            var sonuc = sehirler.Where(sehir => sehir.Contains("Van"));
            var sonuc2 = sehirler.Where(sehir => SehirBul(sehir));
            var sonuc3 = sehirler.Where(sehir => { return sehir.Contains("an"); });
       
            var sonnuc4 = sehirler.Where(p => p.Length == 3).ToList();
            #endregion
        }

        public static bool SehirBul(string sehir)
        {
            return sehir.Contains("an");

        }
        public bool TekCift(int sayi)
        {
            return sayi%2== 0?true:false;
        }
        public static long KareAl(int sayi) {
            {
                return sayi * sayi;
            }
        }

    }
}
