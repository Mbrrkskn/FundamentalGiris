using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _13_InterfaceUretim.Abstract;
namespace _13_InterfaceUretim.Concrete
{
    internal class GomlekArkaTaraf : IDikilebilir
    {
        public void Dik()
        {
            Console.WriteLine($"{this.GetType().Name} Dikildi");
        }
    }
}
