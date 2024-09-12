using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbaolcu.Abstract
{
    public enum Mevki:byte
    {
        Kaleci=1,
        Defans,
        OrtaSaha,
        Forvet
    }
    public abstract class BaseFutbolcu:IFutbolcu
    {
        public Mevki Mevki { get; set; }
        public string AdiSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Millimi { get; set; }
        public byte SutGucu { get; set; }
        public byte Agresiflilik { get; set; }
        public byte Dayanıklılık { get; set; }
        public byte Hiz { get; set; }

        public override string ToString()
        {
            return $"{AdiSoyadi}\nYas{DateTime.Now.Year-DogumTarihi.Year}\nMevki{Mevki}\nSut Gucu {SutGucu}\nHiz:{Hiz}\nMillimi{Millimi}";
        }
        public string Kos()
        {
            return $"{AdiSoyadi} Kostu";
        }

        public string PasAt()
        {
            return $"{AdiSoyadi} Pas attı";
        }

        public string PresYap()
        {
            return $"{AdiSoyadi} Pres Yapti";
        }

        public string SutCek()
        {
            return $"{AdiSoyadi} Sut Cekti";
        }
    }
}
