using System.Diagnostics;

namespace HazirMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            DateTime baslangic = DateTime.Now;
            #region String Hazir Metodlari
            string cumle = "M çiçeği virüsü fareler ve sincaplar gibi kemirgen hayvanlardan veya enfekte olmuş bireylerden bulaşıyor. Virüsün neden olduğu vücut döküntülerine dokunmak, bu döküntülerin bulaştığı giysi, çarşaf, havlu ve benzeri eşyaları kullanmak ve vücut sıvılarıyla temas etmek en önemli bulaş nedenleri arasında yer alıyor.";

            //Console.WriteLine($"Cumlenin Uzunlugu:{cumle.Length}");
            //Console.WriteLine($"Enfekte Kelimesi {cumle.IndexOf("enfekte")} . indextedir");
            #region Cumledeki Kelime Sayisi
            //Console.WriteLine($"Cumlede Toplam {cumle.Split(' ').Count()} kelime vardir");
            //var cumleler = cumle.Split('.');
            //foreach (var item in cumleler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Replace 
            // cumlede fareler yerine kemirgenler yazmak istersek 
            // replace metodu orjinal cumleyi degistirmez . Degismis olan cumleyi size verir.

            //var yeniCumle =cumle.Replace("fareler", "kemirgenler");
            //Console.WriteLine(cumle);
            //Console.WriteLine(yeniCumle);
            #endregion

            #region Substring => cumle icerisinde nokta atisi yaparak istedigimiz bir yeri cekip almaya yarar.
            string str = "Bugun gunlerden cuma";
            //Console.WriteLine(str.Substring(6));// 6. karakterden sonrasini size verir.
            //Console.WriteLine(str.Substring(6,9));// 6. karakterden baslayip 9 adet alacaktir.
            //string krediKartNo = "1234 5678 9123 4567"; //krediKartNo son dort hanesi
            //Console.WriteLine(krediKartNo.Substring(krediKartNo.Length-4));
            //string annekizlikSoyadi = "Yilmaz"; // 3. 5 harfi
            //Console.WriteLine($"{annekizlikSoyadi[2]} ,{annekizlikSoyadi[4]} ");
            #endregion
            #region ToLower() ToUpper()
            //Console.WriteLine(str.ToLower());
            //Console.WriteLine(str.ToUpper());

            #endregion

            #region Insert , Remove
            //Console.WriteLine(str.Insert(str.Length , ".Hava da cok sıcak"));
            //Console.WriteLine(str.Remove(6));
            //Console.WriteLine(str.Remove(6,10));

            #endregion

            #region IsNullOrEmpty
            string.IsNullOrEmpty(str); // string ifadenin null olup olmadigi yada
                                       // empty olup olmadigini kontrol eder

            #endregion
            #region Sansur
            //Console.WriteLine(Sansur(cumle));

            #endregion
            #endregion

            #region Matematik hazir metodlari
            // USt Alma

            //Console.WriteLine(Math.Pow(2, 3)); // 8
            //// KareKok Alma
            //Console.WriteLine(Math.Sqrt(16)); // 4
            //// kup Kok alma
            //Console.WriteLine(Math.Pow(8, 1/3.0)); // 2
            //// PI
            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.Tau);

            #endregion
            #region Yuvarlama Metodları
            // Ceiling => verilen ondalikli sayiyi bir uste yuvarlar
            //Console.WriteLine("Ceiling :"+Math.Ceiling(10.1));
            //// Floor => verilen ondalikli sayiyi aşağı yuvarlar

            //Console.WriteLine("Floor :" + Math.Floor(10.9));
            //// Round=> verilen ondalik li sayiyi yarsindan fazla ise yukari diger durumda asağı yuvarlar
            //Console.WriteLine("Round :" +Math.Round(10.4));
            //Console.WriteLine("Round :" + Math.Round(10.7));
            //Console.WriteLine("Round :" + Math.Round(10.51));
            //Console.WriteLine("Round :" + Math.Round(11.51));
            //Console.WriteLine("Round :" + Math.Round(12.51));
            //Console.WriteLine("Round :" + Math.Round(13.51));
            //Console.WriteLine("Round :" + Math.Round(14.51));



            #endregion

            #region DateTime Hazir Metodlari
            var tarih = DateTime.Now;
            DateTime aDate = DateTime.Now;
            Console.WriteLine("Yerel Saat:" + DateTime.Now);
            Console.WriteLine("UTC Zamani:" + DateTime.UtcNow);
            Console.WriteLine(tarih.ToShortDateString());
            Console.WriteLine(tarih.ToShortTimeString());
            Console.WriteLine(aDate.ToString("dd.MM"));
            Console.WriteLine(aDate.ToString("MM/dd/yyyy"));
            //Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
            //Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
            //Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
            //Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
            //Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
            //Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            //Console.WriteLine(aDate.ToString("MM/dd/yyyy HH:mm"));
            //Console.WriteLine(aDate.ToString("MM/dd/yyyy hh:mm tt"));
            //Console.WriteLine(aDate.ToString("MM/dd/yyyy H:mm"));
            //Console.WriteLine(aDate.ToString("MM/dd/yyyy h:mm tt"));
            //Console.WriteLine(aDate.ToString("MM/dd/yyyy HH:mm:ss"));
            //Console.WriteLine(aDate.ToString("MMMM dd"));
            //Console.WriteLine(aDate.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));
            //Console.WriteLine(aDate.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
            //Console.WriteLine(aDate.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));
            //Console.WriteLine(aDate.ToString("HH:mm"));
            //Console.WriteLine(aDate.ToString("hh:mm tt"));
            //Console.WriteLine(aDate.ToString("H:mm"));
            //Console.WriteLine(aDate.ToString("h:mm tt"));
            //Console.WriteLine(aDate.ToString("HH:mm:ss"));
            //Console.WriteLine(aDate.ToString("yyyy MMMM"));

            // Dogum Tarihi Belirleme
            DateTime dogumTarihi = new DateTime(2000, 4, 15);//Zilan
            DateTime okulaBaslamaTarihi = dogumTarihi.AddYears(7);
            DateTime ortaOkulTarih = okulaBaslamaTarihi.AddYears(4);
            DateTime liseTarihi = ortaOkulTarih.AddYears(4);
            Console.WriteLine("Zilan Dogum Gunu:" + dogumTarihi.DayOfWeek);
            Console.WriteLine("Zilan Dogum Gunu Yilin kacin gunu :" + dogumTarihi.DayOfYear);

            // Artik Yil
            Console.WriteLine(DateTime.IsLeapYear(dogumTarihi.Year));
            #region Iki Tarih arasindaki farklar
            TimeSpan timeSpan = DateTime.Now - dogumTarihi;

            Console.WriteLine("Zilan  => " + timeSpan.Days + " gundur hayatta");

            TimeSpan performans = DateTime.Now - baslangic;
            Console.WriteLine("Programin Calisma suresi :" + performans.TotalNanoseconds);
            Console.WriteLine("Programin Calisma suresi :" + performans.Nanoseconds);
            stopWatch.Stop();
            Console.WriteLine("Miliseconds:" + stopWatch.ElapsedMilliseconds);
            #endregion
            #endregion
        }

        public static string Sansur(string cumle)
        {
            string yeniCumle = "";
            List<string> yasakliKelimeler = new List<string>();
            yasakliKelimeler.Add("fareler");
            yasakliKelimeler.Add("vücut");
            yasakliKelimeler.Add("dokunmak");
            foreach (var kelime in yasakliKelimeler)
            {
                if (cumle.Contains(kelime))
                {
                    string yildiz = "";
                    for (int i = 0; i < kelime.Length; i++)
                    {
                        yildiz += "*";
                    }
                    cumle = cumle.Replace(kelime, yildiz);
                }
            }

            return cumle;
        }
    }
}
