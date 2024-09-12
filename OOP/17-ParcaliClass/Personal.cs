using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ParcaliClass
{
    /*
     * Partial Clas'lar birden fazla dosyada olan yapılardır
     * Eger class cok buyukse parcalara ayrılabilir
     * 
     * 
     */
    internal partial class Personal
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        public string Gsm { get; set; }
        public bool Cinsiyet { get; set; }
        public string Email { get; set; }

    }
}
