namespace _22_HizAsimEvent
{

    #region Senaryo
    /*
     * Bir araba class'ımız olacak.Hız bilgisi tutulacak.
     * 120'yi gecince hiz sinirini aştınız uyarısı verecek
     */

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
           Araba araba = new Araba("Bmw",90);
            araba.HizAsim += HizAsildi;
            for (int i = 100; i < 150; i=i+10)
            {
                araba.Hiz = i;
            }
           
        }
        public static void HizAsildi(int _hiz)
        {
            Console.WriteLine("Araba hiz limiti asti:" +_hiz);
        }
    }
}
