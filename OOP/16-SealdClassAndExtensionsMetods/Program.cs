using System.Data.SqlClient;

namespace _16_SealdClassAndExtensionsMetods
{
  public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kalıtım vermez. Ancak ınstance alınabilir
             * Bu yapısı ile classın tam tersidir.
             * 
             * muhurlu class'lardır.
             * 
             * 
             */
            string kelime = "çığşöü";

            Console.WriteLine(kelime.TurkceKarakterleriTemizle());
            SqlConnection connection = new();
            connection.MyExtensionsConnection();
        }
    }
}
