using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorfizmWindow.CepTelefonlari
{
    public class BasePhone
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public virtual void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(@"..\..\..\Sounds\default.wav"))
            {
                player.Play();
            }
        }
    }
}
