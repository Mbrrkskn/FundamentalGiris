using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.FirinOrnegi
{
    public class Makina:IYogurma
    {
        public string MakinaAdi { get; set; }

        public void HamurYogur()
        {
            Console.WriteLine(MakinaAdi +   "Hamur Yoğurdu");
        }
        public void Start()
        {

        }
        public void Stop()
        {
        }

    }
}
