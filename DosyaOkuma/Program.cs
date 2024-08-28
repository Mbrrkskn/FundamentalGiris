namespace DosyaOkuma
{

    public struct Ilce
    {
        public int IlceKodu;
        public int IlKodu;
        public string IlceAdi;
    }

    struct Sehir  //Kendi Veri Tipimiz
    {
        public string plakakodu;
        public string il;
        public DateTime CreateDate;
        public bool isActive;
    }
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            #region Dosya Okuma İşlemleri

            #region Konu Anlatımı
            /*
             * Dosya Nedir? = İçerisinde çeşitli bilgiler saklayan yapılara dosya denir
             * Bilgi Türleri = metinsel veriler,ses dosyaları,fotograf ve resim dosyaları
             * Database dosyaları, html dosyaları,office dosyaları vb.
             * 
             * Bunlar arasında bizim en cok uzerinde duracagımız .csv dosyaları olacaktır.
             * Csv(Comma Seperated values) veriler arasında bir ayraç ile 
             * (Genelde ',' yada ';' olur) ayrılmış dosyalara csv dosyaları denir.
             * 
             * c# da dosya okumanın bir çok yolu vardır
             * . En hızlı ve kolay olanı File sınıfıdır.
             * 
             */

            #endregion

            #region Sehirleri okuma , Siralama Ve Ekaran yazdirma

            var sehirler = SehirleriOku();

            // //Siralama
            var sonuc = sehirler.OrderBy(p => p.plakakodu).ToList();

            // foreach (var sehir in sonuc)
            // {
            //     Console.WriteLine($"{sehir.plakakodu} => {sehir.il}");
            // } 

            sonuc.ForEach(p => Console.WriteLine($"{p.plakakodu} => {p.il}"));



            #endregion
            var ilceler = IlceleriOku(); //=> Geriye Ilceler Listesi donsun
                                         //foreach (var item in ilceler)
                                         //{
                                         //    Console.WriteLine($"{item.IlceKodu} {item.IlKodu} {item.IlceAdi}");
                                         //}

            #region Ilceler uzerinde IStanbulun ilcelerini bulalim
            //Siralama
            var ilceSonuc = ilceler.OrderBy(p => p.IlKodu).ToList();
            //foreach (var ilce in ilceler)
            //{
            //    //if (ilce.IlKodu == 34)
            //        Console.WriteLine(ilce.IlKodu + " " + ilce.IlceAdi);
            //}


            //Listelerde Arama Yapma. Izmirin ilceleri 
            var izmirIlceler = ilceler.Where(p => p.IlKodu == 35).ToList();
            izmirIlceler.ForEach(p => Console.WriteLine(p.IlKodu + " " + p.IlceAdi));
            // IStanbulda ki ilcelerin icerisinde 'B' olan ilceler hangileridir.

            var result = ilceler.Where(p => p.IlKodu == 34 && p.IlceAdi.Contains('B')).ToList();
            Console.WriteLine("IStanbuldaki Icerisinde B olan ilcelerin listesi");
            result.ForEach(p => Console.WriteLine(p.IlceAdi));

            #endregion


            #region Custsomer-1000.csv dosyasının okunması

            #endregion
            #endregion


            static List<Ilce> IlceleriOku()
            {
                string path = "c:\\temp\\ilce.csv"; // cift backslah
                List<Ilce> ilceler = new List<Ilce>();
                try
                {
                    string[] satirlar = File.ReadAllLines(path);

                    foreach (var satir in satirlar)
                    {
                        Ilce ilce = new Ilce(); // Sehir struct 'dan ornek alinmasi

                        var sonuc = satir.Split(','); //Gelen satiri ',' gore ayirir.
                        #region Eger Tirnaklar gorunmek istenmiyorsa 1. Yol Replace Etmektir.
                        //ilce.IlceKodu = sonuc[0].Replace('"',' ');
                        //ilce.IlKodu = sonuc[1].Replace('"', ' '); 
                        #endregion

                        #region Eger Tirnaklar gorunmek istenmiyorsa 2. Yol int cevirmektir.
                        ilce.IlceKodu = int.Parse(sonuc[0].Replace('"', ' ').Trim());
                        ilce.IlKodu = int.Parse(sonuc[1].Replace('"', ' ').Trim());
                        ilce.IlceAdi = sonuc[1].Replace('"', ' ').Trim();
                        #endregion
                        ilce.IlceAdi = sonuc[2];

                        ilceler.Add(ilce);


                    }

                }
                catch (PathTooLongException ex)
                {
                    Console.WriteLine("Dosya yolu cok uzun:" + ex.Message);
                }
                catch (FileNotFoundException ex)
                {

                    Console.WriteLine("Hata:Aradiginiz dosyaya su an ulasilamadi:" + ex.Message);
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine("Hata:Aradiginiz Klasore ulasilamadi:" + ex.Message);

                }

                catch (Exception ex)
                {
                    Console.WriteLine("Hat:" + ex.Message);

                }



                return ilceler;
            }



            static List<Sehir> SehirleriOku()
            {
                string path = "c:\\tempp\\il.csv"; //cift backslah
                                                   //string path2 = @"c:\tempp\il.csv";   //string verbatim
                List<string> plakalar = new List<string>();
                List<string> iller = new List<string>();

                List<Sehir> sehirler = new List<Sehir>();
                try
                {

                    string[] satirlar = File.ReadAllLines(path);

                    foreach (var satır in satirlar)
                    {
                        Sehir sehir = new Sehir(); //Sehir structtan örnek alınması

                        var sonuc = satır.Split(','); //Gelen satiri ',' gore ayırır
                        sehir.plakakodu = sonuc[0];
                        sehir.il = sonuc[1];
                        sehir.isActive = true;
                        sehir.CreateDate = DateTime.Now;

                        #region Amele yöntemi
                        //plakalar.Add(sonuc[0]) ;  //Ayrılan parcanın 0.elemanı plaka kodu
                        //iller.Add(sonuc[1]) ;   //Ayrılan parcanın 1.Elemanı sehir

                        #endregion
                        #region Modern Yöntem
                        //7 sehirler.Add(sehir);
                        #endregion

                        // Console.WriteLine(satır);
                    }


                    #region Amele Yontemi


                    //for (int i = 0; i< plakalar.Count; i++)
                    //{
                    //    Console.WriteLine($"{plakalar[i]} => {iller[i]}");
                    //}
                    #endregion

                    //foreach (Sehir sehir in sehirler)
                    //{
                    //    Console.WriteLine($"{sehir.plakakodu}=>{sehir.il}\t\tKayit Zamani=>{sehir.CreateDate}\tAktifmi=>{sehir.isActive}");
                    //}

                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Hata:Aradığınız dosyaya su an ulaşamadınız:" + ex.Message);
                }
                catch (PathTooLongException ex)
                {
                    Console.WriteLine("Dosya yolu cok uzun:" + ex.Message);
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine("Hata:Aradıgınız Klasore ulasılamadı:" + ex.Message);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata:" + ex.Message);
                }
                return sehirler;

            }

            
        }
    }
}
