using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class.Menuler
{
    internal class Menu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int OrderNo { get; set; }
        public string URL { get; set; }
        public int UstMenuID { get; set; }
        public Menu UstMenu { get; set; }
    }
}
