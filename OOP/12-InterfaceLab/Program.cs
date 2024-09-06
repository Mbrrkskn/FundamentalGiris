using _12_InterfaceLab.FirinOrnegi;
using _12_InterfaceLab.LokantaOrnegi;

namespace _12_InterfaceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #region Concrete instance alma
            //Usta usta = new Usta() { AdSoyad = "Hasan Usta" };
            //Makina makina = new Makina() { MakinaAdi = "Yogurma makinası" };
            //makina.Start();
            // usta.MolaVer();
            // #endregion

            // //interfacelerden  ve abstractlardan instance alınmaz
            // #region Interface uzerinden instance alma
            // IYogurma usta1 = new Usta() { AdSoyad = "Hasan Usta" };
            // IYogurma makina1 = new Makina() { MakinaAdi = "Yogurma makinası" };
            // usta1.HamurYogur();
            // makina1.HamurYogur();

            // #endregion

            // KaraFirin karaFirin = new KaraFirin();
            // karaFirin.EkmekPisir(usta);
            // karaFirin.EkmekPisir(makina);

            // Console.WriteLine("Hello, World!");

            #region Lokanta Ornegı

            #region Concrete instance alma
            //Pilav pilav = new Pilav();
            //Kofte kofte = new Kofte();
            //KuruFasulye kuruFasulye = new KuruFasulye();
            //Sutlac sutlac = new Sutlac();

            #endregion

            #region Interface uzerinden instance alma
            IPisirilebilir pilav = new Pilav();
            IPisirilebilir kofte= new Kofte();
            IPisirilebilir kuruFasulye = new KuruFasulye();
            IPisirilebilir sutlac = new Sutlac();
           // IPisirilebilir salata = new Salata();
            #endregion

            List<IPisirilebilir> pisirilebilirs = new List<IPisirilebilir>();
            pisirilebilirs.Add(pilav);
            pisirilebilirs.Add(kofte);
            pisirilebilirs.Add(kuruFasulye);
            pisirilebilirs.Add(sutlac);
           // pisirilebilirs.Add(salata);
           

            BorsaLokantasi borsaLokantasi = new BorsaLokantasi();
            borsaLokantasi.YemekPisir(pisirilebilirs);

            /*
             * IT elemanı arayan bir firmanın insan kaynaklarındaki 
             * basvuru surecini modelleyin
             * 
             */

            #endregion
        }
    }
}
