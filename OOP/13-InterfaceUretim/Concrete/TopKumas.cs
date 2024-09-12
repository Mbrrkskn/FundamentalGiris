using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13_InterfaceUretim.Abstract;

namespace _13_InterfaceUretim.Concrete
{
    public enum KalipTipi
    {
        GomlekArka=1,
        GomlekOn=2,
        GomlekKol=3
    }
    internal class TopKumas : IKalip, IKesilebilir
    {
        private IMakina SonrakiStep {  get; set; }
        private bool _flag;
        private KalipTipi _KalipTipi;
        public void KalipCikar(KalipTipi kalipTipi)
        {
            _KalipTipi = kalipTipi;
            Console.WriteLine("Top kumastan kalıp çıkartıldı");
            _flag= true;
        }

        public void Kes()
        {
            //if (_flag)
            //    Console.WriteLine("Top kumas kesimden çıktı");
            //else Console.WriteLine("Once kalip çıkartılması lazım");

            Console.WriteLine( _flag == true ? "Top kumas kesimden çıktı" : "Once kalip çıkartılması lazım");
            switch(_KalipTipi)
            {
                case KalipTipi.GomlekArka:
                   
                    break;
                case KalipTipi.GomlekOn:

                    break;
                case KalipTipi.GomlekKol:
                    break;
                default:
                    break;

            }

        }
    }
}
