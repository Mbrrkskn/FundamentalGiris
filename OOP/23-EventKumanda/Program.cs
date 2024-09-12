namespace _23_EventKumanda
{
    internal class Program
    {
        #region Kumandaya basılınca arabanın kapıları acılsın


        #endregion
        static void Main(string[] args)
        {
           Kumanda k1= new Kumanda("que");
            Kumanda k2 = new Kumanda("123");
            Kumanda k3 = new Kumanda("asd");
            Kumanda k4 = new Kumanda("xyz");

            Araba araba = new Araba("Bmw", "asd");

            k1.KumandayaBas += araba.SinyalAl;
            k2.KumandayaBas += araba.SinyalAl;
            k3.KumandayaBas += araba.SinyalAl;
            k4.KumandayaBas += araba.SinyalAl;

            k1.TusaBas();
            k2.TusaBas();
            k3.TusaBas();
            k4.TusaBas();


        }
    }
}
