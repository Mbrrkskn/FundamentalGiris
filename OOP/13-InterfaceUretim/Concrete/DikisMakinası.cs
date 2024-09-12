using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13_InterfaceUretim.Abstract;

namespace _13_InterfaceUretim.Concrete
{
    internal class DikisMakinası (List<IDikilebilir> dikilebilirUrunler,string Marka,string Model):BaseMakina(Marka,Model),IMakina
    {
        public void Calis()
        {
            foreach (var item in dikilebilirUrunler)
            {
                item.Dik();
            }
        }

    }
}
