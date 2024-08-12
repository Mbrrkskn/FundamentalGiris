namespace IfElse;

class Program
{
    static void Main(string[] args)
    {

        #region IfElse Ornek
        /*
        Girilen iki sayının

        int sayi1=5;
        int sayi2=5;

        if(sayi1 == 5)
        {
         System.Console.WriteLine("Sayı 5 dir.");
        }
        else
        {
         System.Console.WriteLine("Sayı 5 değildir.");
        }

        if(sayi1>sayi2)
        {
         System.Console.WriteLine(sayi1 +" > "+sayi2);
        }
        else if(sayi1==sayi2)
        {
         System.Console.WriteLine(sayi1 +"="+sayi2);
        }
        else
        {
         System.Console.WriteLine(sayi1 +"<"+sayi2);
        }
        */

        //Girilen suyun sıcaklıgına gore katı,sıvı,gaz halini yazdırın

        /*Sık Yapılan Hatalar 

         if(sayi>10);=> noktalı virgül konulmaz
         {
              Dogru
         }
         else
         {
              Yanlışsa buraya
         }

        */

        #endregion

        #region Suyun Sıcaklıgı

        /* Int16 sıcaklık;
         string temp;
         System.Console.WriteLine("Sıcaklık değerini giriniz:");
        temp =Console.ReadLine(); 
        sıcaklık = Convert.ToInt16(temp) ;     

         if (sıcaklık<=0)
         {
          Console.WriteLine("Su Katıdır.");
         }
         else if (sıcaklık>=0 && sıcaklık <=100)
         {
          System.Console.WriteLine("Su gazdır.");
         }
         else
         {
          System.Console.WriteLine("Su sıvıdır");
         }
         */
        #endregion

        #region Haftanın gunleri

        /*Pazartesi haftanın birinci gunu olmak uzere,
          Ekrandan haftanın gununu okutun.
          1=>pazartesi,2=>sali....7=>pazar
          seklinde bastırın
       

        Console.Write("Haftanın gününü giriniz (1-7): ");
          int gun = Convert.ToInt32(Console.ReadLine());

          if (gun == 1)
          {
              Console.WriteLine("Pazartesi");
          }
          else if (gun == 2)
          {
              Console.WriteLine("Salı");
          }
          else if (gun == 3)
          {
              Console.WriteLine("Çarşamba");
          }
          else if (gun == 4)
          {
              Console.WriteLine("Perşembe");
          }
          else if (gun == 5)
          {
              Console.WriteLine("Cuma");
          }
          else if (gun == 6)
          {
              Console.WriteLine("Cumartesi");
          }
          else if (gun == 7)
          {
              Console.WriteLine("Pazar");
          }
          else
          {
              Console.WriteLine("Geçersiz bir gün girdiniz. Lütfen 1 ile 7 arasında bir sayı girin.");
          }
          */

        #endregion

        #region Final Notu Bulma
        /*
       2 vize bir final alınacak.Vizenin %30 finalin %70 alınacak
     Eger 0-29 => D
      30-49 = C
      50-69 =B
      70-100 = A 

      && => ve , || => yada

        */

        /*
        Console.Write("Birinci vize notunu giriniz: ");
        double vize1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci vize notunu giriniz: ");
        double vize2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Final notunu giriniz: ");
        double final = Convert.ToDouble(Console.ReadLine());

        
        double ortalama = (vize1 * 0.15) + (vize2 * 0.15) + (final * 0.7);

        
        if (ortalama >= 70 && ortalama <= 100)
        {
            Console.WriteLine("Notunuz: A");
        }
        else if (ortalama >= 50 && ortalama < 70)
        {
            Console.WriteLine("Notunuz: B");
        }
        else if (ortalama >= 30 && ortalama < 50)
        {
            Console.WriteLine("Notunuz: C");
        }
        else if (ortalama >= 0 && ortalama < 30)
        {
            Console.WriteLine("Notunuz: D");
        }
        else
        {
            Console.WriteLine("Geçersiz notlar girdiniz. Lütfen 0-100 arasında değerler giriniz.");
        }
    */

        #endregion

        #region Reyon Bulma

        /*
        Dısarıdan urun adı gırılecek ,program urunun hangi reyonda 
        oldugunu soyleyecek.
        Domates,biber,patlıcan icin sebze reyonu
        Diş macunu,parfüm,krem için kozmetik reyonu,
        Telefon,bilgisayar,ses sistemleri için teknoloji reyonu
        bunlardan farklı bir ürün girer ise "Bu ürün bizde yok"
        uyarısı verecek.

       

        

        /*string urun;

        Console.Write("Ürün adını giriniz: ");
        urun = Console.ReadLine().ToLower();

        
        if (urun == "domates" || urun == "biber" || urun == "patlican")
        {
            Console.WriteLine("Bu ürün Sebze reyonunda bulunur.");
        }
        else if (urun == "dis macunu" || urun == "parfum" || urun == "krem")
        {
            Console.WriteLine("Bu ürün Kozmetik reyonunda bulunur.");
        }
        else if (urun == "telefon" || urun == "bilgisayar" || urun == "ses sistemi" || urun == "ses sistemleri")
        {
            Console.WriteLine("Bu ürün Teknoloji reyonunda bulunur.");
        }
        else
        {
            Console.WriteLine("Bu ürün bizde yok.");
        }
    
    */

        #endregion


        #region Fiyat Tespit
        /*
          Urun fiyatı:5 Tl olsun
          Dısarıdan girilecek sipariş sayısına gore
          20 den az ise toplam ucretten %5 indirim yapılacak
          20-50 arasında ise %10 indirim
          20-50 arasında ise %15 indirim
          50-100 arasında ise %15 indirim
          100 ve üzeri için %20 indirim yapılsın
          Ekrana toplam tutar,indirim miktarı ve odenecek tutar bilgilerini yazdır.

        */

        #endregion

        #region UrunFiyati
        //double urunFiyati = 5.0;

        //Console.Write("Sipariş sayisini giriniz: ");
        //int siparisSayisi = Convert.ToInt32(Console.ReadLine());

        //double toplamTutar = urunFiyati * siparisSayisi;
        //double indirimOrani = 0;


        //if (siparisSayisi < 20)
        //{
        //    indirimOrani = 0.05; 
        //}
        //else if (siparisSayisi >= 20 && siparisSayisi < 50)
        //{
        //    indirimOrani = 0.10; 
        //}
        //else if (siparisSayisi >= 50 && siparisSayisi < 100)
        //{
        //    indirimOrani = 0.15; 
        //}
        //else if (siparisSayisi >= 100)
        //{
        //    indirimOrani = 0.20; 
        //}

        //double indirimMiktari = toplamTutar * indirimOrani;
        //double odenecekTutar = toplamTutar - indirimMiktari;
        //Console.WriteLine($"Toplam Tutar: {toplamTutar} TL");
        //Console.WriteLine($"İndirim Miktari: {indirimMiktari} TL");
        //Console.WriteLine($"Ödenecek Tutar: {odenecekTutar} TL");
        //#endregion
        //Console.WriteLine("Hello, World!");



        #endregion

        #region Ternary IF
        //Eger tek satırd UFAK BİR KARAR MEKANİZMASI İLE YOLA DEVAM ETMEK İSTİYORSAK ?
        //OPERAT ORU KULLANMAMIZ GEREKİR.
        //YAZİM FORMATİ sonuc > 10 ? "True" : "False";,
        //Genelde Database'den gelen yada api den gelen degerleri kontrol etmekte sıklıkla kullanılır
        //Yada bir değişkene deger atarken kullanılır
        //int yas = 20;
        //var sonuc = yas > 18 ? "Reşit" : "Reşit Degıldır";
        //Console.Writeline(sonuc);



        #endregion


        #region Switch Case
        /*
         * if-else mantıgı calısır.If else buyuk,kucuk,esit vb. durumları kontrol
         * ederken switch case esitlik durumuna bakar
         * Kendi içerisinde bir indexlemeye sahiptir.
         * Eşitlik kosulları fazla olan durumlarda performans acısından switch case tavsiye edilir.
         */

        //Switch içerisinde veri tipi ne ise case kisminda buna uygun kontrol yapılması gerekiyor
        //Bu durum en sık yapılan hatalardandır.



        #region Ornek1 : Ekrandan mevsim okutun ve ayları bastırın . switch case ile yapılacak.
        //Console.WriteLine("Mevsim giriniz:");
        //string mevsim = Console.ReadLine().ToLower();

        //switch(mevsim)
        //{
        //    case "Kis":
        //        Console.WriteLine("Aralik,Ocak,Subat");
        //        break;
        //    case "IlkBahar":
        //        Console.WriteLine("Mart,Nisan,Mayis");
        //        break;
        //    case "Yaz":
        //        Console.WriteLine("Haziran,Temmuz,Agustos");
        //        break;
        //    case "SonBahar":
        //        Console.WriteLine("Eylül, Ekim,Kaim");
        //        break;
        //        default:
        //        Console.WriteLine("Duzgun mevsim ismi giriniz");
        //        break;
        //}



        #endregion
        #endregion

        #region Ornek 2
        //Ekrandan Rol okutun. Eger Admin girildiyse Admin sayfasına
        // yönlendiriliyorsunuz mesajı. satıs girildiyese Satıs sayfasına yonlendiriliyorsunuz
        //Uye girildiyse uye sayfasına yönlendiriliyorsunuz mesajını verecek switch case yapısını kurunuz
        //ceo,moderator
        //satıs,finans,lojıstık
        //uye,member

        //Console.WriteLine("Rolü giriniz (Admin, Satış, Üye): ");
        //string rol = Console.ReadLine().ToLower();


        //switch (rol)
        //{
        //    case "admin":
        //    case "ceo":
        //    case "moderator":
        //        Console.WriteLine("Admin sayfasına yönlendiriliyorsunuz.");
        //        break;

        //    case "satis":
        //    case "finans":
        //    case "lojistik":
        //        Console.WriteLine("Satış sayfasına yönlendiriliyorsunuz.");
        //        break;

        //    case "üye":
        //    case "member":
        //        Console.WriteLine("Üye sayfasına yönlendiriliyorsunuz.");
        //        break;

        //    default:
        //        Console.WriteLine("Geçersiz rol girdiniz.");
        //        break;
        //}

        #endregion

        #region Ornek 3
        //kullanıcı adı ve sifre okutun. Her ikisi doğru ise 'hosgeldin admin mesajı'
        //girilen bilgilerden hangisi yanlış ise onu açıkça ekrana yazdırım.
        //kullanıcı adı veya şifre hatalı diye göstersin


        string kullanıcıAdı = "admin";
        string kullanıcıSifre = "admin";

        Console.Write("Kullanıcı adını giriniz: ");
        string kullanıcı = Console.ReadLine();

        Console.Write("Şifreyi giriniz: ");
        string sifre = Console.ReadLine();

        string kullanıcıDogrulama = (kullanıcı == kullanıcıAdı) ? "dogru" : "yanlış";
        string sifreDogrulama = (sifre == kullanıcıSifre) ? "dogru" : "yanlış";

            switch (kullanıcıDogrulama)
            {
                case "doğru":
                if (sifreDogrulama == "dogru")
                {
                    Console.WriteLine("Hosgeldin admin");
                }
                else 
                {
                    Console.WriteLine("Şifre hatalı.");
                }

                break;


                case "yanlış":
                if (sifreDogrulama == "dogru")
                {
                    Console.WriteLine("Kullanıcı adı hatalı");
                }

                else
                {
                    Console.WriteLine("Kullanıcı adı ve şifre hatalı.");
                }
                 break;
            }
    }
   
        #endregion

}




