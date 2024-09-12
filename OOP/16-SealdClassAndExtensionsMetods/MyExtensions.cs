using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _16_SealdClassAndExtensionsMetods
{
    public static class MyExtensions
    {
        public static SqlConnection MyExtensionsConnection(this SqlConnection connection)
        {
            return connection;
        }
        public static string TurkceKarakterleriTemizle(this string kelime)
        {
            return kelime.Replace('ç', 'c')
                .Replace('ı', 'i')
                .Replace('ğ', 'g')
                .Replace('ş', 's')
                .Replace('ü', 'u')
                .Replace('ö', 'o');
        }
    }
}
