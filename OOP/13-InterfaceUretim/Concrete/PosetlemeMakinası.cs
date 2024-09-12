using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13_InterfaceUretim.Abstract;

namespace _13_InterfaceUretim.Concrete
{
    internal class PosetlemeMakinası(List<IPosetlenebilir> posetlenebilirs,string Marka,string Model):BaseMakina(Marka,Model),IMakina
    {
        public void Calis()
        {
            foreach (var item in posetlenebilirs)
            {
                item.Posetle();
            }
        }

    }
}
