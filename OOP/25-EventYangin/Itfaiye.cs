using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_EventYangin
{
    public class Itfaiye
    {
        public void MudahaleEt(object yardimCagiran)
        {
            if(yardimCagiran is Alarm)
            {
                Console.WriteLine("Itfaiye yangına mudahale etti");

            }
        }
    }
}
