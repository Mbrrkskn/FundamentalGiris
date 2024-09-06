using _12_InterfaceLab.FirinOrnegi;
using _12_InterfaceLab.InsanKaynaklari;
using _12_InterfaceLab.LokantaOrnegi;

namespace _12_InterfaceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Concrete instance alma
            //Usta usta = new Usta() { AdSoyad = "Hasan Usta" };
            //Makina makina = new Makina() { MakinaAdi = "Yogurma makinası" };
            //makina.Start();
            // usta.MolaVer();
            #endregion

            // //interfacelerden  ve abstractlardan instance alınmaz
            #region Interface uzerinden instance alma
            // IYogurma usta1 = new Usta() { AdSoyad = "Hasan Usta" };
            // IYogurma makina1 = new Makina() { MakinaAdi = "Yogurma makinası" };
            // usta1.HamurYogur();
            // makina1.HamurYogur();

            #endregion

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
            //IPisirilebilir pilav = new Pilav();
            //IPisirilebilir kofte= new Kofte();
            //IPisirilebilir kuruFasulye = new KuruFasulye();
            //IPisirilebilir sutlac = new Sutlac();

            #endregion

            //List<IPisirilebilir> pisirilebilirs = new List<IPisirilebilir>();
            //pisirilebilirs.Add(pilav);
            //pisirilebilirs.Add(kofte);
            //pisirilebilirs.Add(kuruFasulye);
            //pisirilebilirs.Add(sutlac);


            //BorsaLokantasi borsaLokantasi = new BorsaLokantasi();
            //borsaLokantasi.YemekPisir(pisirilebilirs);

            /*
             * IT elemanı arayan bir firmanın insan kaynaklarındaki 
             * basvuru surecini modelleyin
             * 
             */

            #endregion

            Aday aday = new Aday
            {
                Ad = "Müberra",
                Soyad = "Keskin",
                Yas = 23,
                Gsm = "5316625633",
                Eposta = "keskinmuberra111@gmail.com",
                MezunOlduguOkul = "Medipol Üniversitesi",
                AskerikDurumu =false,
                Cinsiyet = false,
                MedeniHal = false,
                Ehliyet = "B",
                BildigiDiller = "Türkçe, İngilizce",
                YazilimDilleri = "C#, Java, Sql"
            };



            Aday aday2 = new Aday
            {
                Ad = "Efe",
                Soyad = "Keskin",
                Yas = 34,
                Gsm = "5551211211",
                Eposta = "keskinefe@gmail.com",
                MezunOlduguOkul = "Doguş Üniversitesi",
                AskerikDurumu = false,
                Cinsiyet = true,
                MedeniHal = true,
                Ehliyet = "B",
                BildigiDiller = "Türkçe, İngilizce",
                YazilimDilleri = "Kotlin,Python"
            };
            // Aday başvurusunu yapıyor
            aday.BasvuruYap();
            aday2.BasvuruYap();

            // Aday yetenek testine giriyor
            aday.YetenekTestiDegerlendirme(true);  // Test başarılı
            aday2.YetenekTestiDegerlendirme(false); //Test basarısız

            // İnsan Kaynakları başvuruyu değerlendiriyor
            InsanKaynaklari.InsanKaynaklari ik = new InsanKaynaklari.InsanKaynaklari();
            ik.BasvuruDegerlendir(aday);
            ik.BasvuruDegerlendir(aday2);

           
            // IT pozisyonu bilgisi
            ITPozisyon itPozisyon = new ITPozisyon("Yazılım Geliştirici", "C#, Java, Sql bilgisi");
            itPozisyon.PozisyonBilgisiGoster();

            // Başvuru sonucunu göster
            aday.BasvuruSonucu();
            aday2.BasvuruSonucu();




        

    }
    }
}
