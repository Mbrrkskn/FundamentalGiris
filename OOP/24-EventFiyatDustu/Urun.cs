using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EventFiyatDustu
{
    public delegate void FiyatDustuHandler(int fiyat);//geri donus tipi olmayan ve her metodu temsil eder
    public class Urun
    {
        public event FiyatDustuHandler FiyatDustuEvent;
        public string UrunAdi { get; set; }
        private int _Fiyat;

        public int Fiyat
        {
            get { return _Fiyat; }
            set
            {

                FiyatDustuEvent(value);

                _Fiyat = value;
            }
        }
    }
}
