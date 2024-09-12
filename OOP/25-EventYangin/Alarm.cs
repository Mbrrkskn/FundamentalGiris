using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_EventYangin
{
    public class Alarm
    {
        public event OlayTemsilci AlarmCaldi;

        public void AlarmCal(object alarmiTetikleyen)
        {
            if(alarmiTetikleyen is Kablo)
            {
                Console.WriteLine("Alarm kablo yüzünden caldi");
                AlarmCaldi(this);
            }
            else if(alarmiTetikleyen is Sigara)
            {
                Console.WriteLine("Alarm sigara yuzunden caldi");
               AlarmCaldi(this);
            }
        }
    }
}
