using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract
{
    public class Muzisyen
    {
        //public Gitar Gitar { get; set; }

        //public Flut Flut { get; set; }
        //public Piyano Piyano { get; set; }

        public string AdSoyad { get; set; }
        /* Caldıgı aletleri tek tek prop olarak ifade etmek 
         * ilerleyen durumda yeni bir müzik aleti caldıgında kodda
         * degısıklıge neden olacaktır.Bu ıstenilen bır durum değildir
         * 
         * Bu nedenle bütün müzik aletlerinin base class'i olan MuzikAleti
         * sınıfını tutan bir listede ifade etmek dogru  olan yoldur.
         * 
         * 
         */
        public List<MuzikAleti> CaldıgıAletler { get; set; }
        public Muzisyen(List<MuzikAleti>muzikAleti)
        {
            CaldıgıAletler = muzikAleti;
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in CaldıgıAletler)
            {
                str += $"{item.Marka} {item.Model}  \n";
            }
            return str + " Calıyor";
        }
    }
}
