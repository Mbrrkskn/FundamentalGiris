using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract
{
    public class Flut : MuzikAleti
    {
        public override string Marka { get; set; }
        public override string Model { get; set; }

        //Normal classlar içerisinde abstract metod tanımlanamazlar
        //Aşağıdaki kod hata verecektir
        // public abstract void Test();
        public override string Cal()
        {
            return "Flüt Caldi";
            
        }
        public override string ToString()
        {
            return $"Marka {Marka} Model {Model}";
        }
    }
}
