using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_HizAsimEvent
{
    public interface IArabaEvents
    {
        public delegate void HizAsimHandler();
        public event HizAsimHandler HizAsim;
    }
}
