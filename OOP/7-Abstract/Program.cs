using _7_Abstract.AlanHesaplari;

namespace _7_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Muzik
            //Gitar gitar = new Gitar() { Marka = "Fender", Model = "xyz" };
            //Flut flut = new Flut() { Marka ="Yamaha",Model ="xyz"};

            //Piyano piyano = new Piyano() { Marka = "Roland", Model = "qwz" }; ;
            //Console.WriteLine(gitar);
            //Console.WriteLine(flut);
            //Console.WriteLine(piyano);
            //Console.WriteLine(gitar.Cal());
            //Console.WriteLine(flut.Cal());
            //flut.AkordYap();
            //gitar.AkordYap();


            //List<MuzikAleti> muzikAletis = new List<MuzikAleti>();
            //muzikAletis.Add(gitar);
            //muzikAletis.Add(flut);
            //muzikAletis.Add(piyano);
            //Muzisyen İsmailYk = new Muzisyen(muzikAletis);
            //Console.WriteLine(İsmailYk);

            #endregion

            #region Sekil ornegı

            DikUcgen dikUcgen = new DikUcgen() { KisaKenar = 3, UzunKenar = 4 };
            Kare kare = new Kare() { KisaKenar = 5, UzunKenar = 5};
            List<Sekil> sekils = new List<Sekil>() { kare, dikUcgen };
            AlanHesaplayici hesaplayici = new AlanHesaplayici(sekils);
            //Console.WriteLine(hesaplayici.AlanHesapla());
            //Console.WriteLine(hesaplayici.CevreHesapla());

            Console.WriteLine(hesaplayici);

            #endregion
        }
    }
}
