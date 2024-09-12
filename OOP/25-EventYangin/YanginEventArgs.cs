using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_EventYangin
{
    public delegate void OlayTemsilci(object sender);
    public class YanginEventArgs:EventArgs
    {
        public int State { get; set; } = 1;
    }
}
