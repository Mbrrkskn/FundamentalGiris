using System.Globalization;

namespace _21_DosyaTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MOC_DATA.csv dosyasını okutup listeye atalim

            #region Sorular
            /*
             * 1-1990 sonrası doğan bayanların içerisinde kaç kişi mazda kullanıyor?
             * 2-Erkeklerde 1980 ile 1990 arası doganların Ford kullanım sayısı nedir?
             * 
             * 3-Erkeklerin ve bayanların araç kullanım dağılımı nedir?
             * 
             */
            #endregion


            string filePath = "C:\\tempp\\MOCK_DATA.csv"; // CSV dosyasının yolu
            var people = new List<Person>();

            // CSV dosyasını okuma ve listeye atma
            using (var reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Başlık satırını geçiyoruz
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    // Person nesnesi oluşturma
                    var person = new Person
                    {
                        Id = int.Parse(values[0]),
                        FirstName = values[1],
                        LastName = values[2],
                        Email = values[3],
                        Gender = values[4],
                        CarName = values[5],
                        CarModel = values[6],
                        CarYear = int.Parse(values[7]),
                        BirthDate = DateTime.ParseExact(values[8], "dd.MM.yyyy", CultureInfo.InvariantCulture)
                    };

                    people.Add(person);
                }
            }

            // 1990 sonrası doğan bayanların sayısını bulma
            var result = people
                .Where(p => p.Gender == "Female" && p.BirthDate.Year > 1990 && p.CarName == "Mazda")
                .ToList();

            Console.WriteLine($"1990 sonrası doğan ve Mazda kullanan bayanların sayısı: {result.Count}");
        }

        // Kişi bilgilerini tutacak sınıf
        public class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Gender { get; set; }
            public string CarName { get; set; }
            public string CarModel { get; set; }
            public int CarYear { get; set; }
            public DateTime BirthDate { get; set; }

           
        }
    }
}
