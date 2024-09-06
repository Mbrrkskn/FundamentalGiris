using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract
{
    #region Konu Anlatimi
    //Abstract classlar sadece kalitim verir
    //Instance Calısmaz

    //public sealed class MuzikAleti olunca kalıtım vermez hiçbir yere
    #endregion
    public abstract class MuzikAleti
    {
        public abstract string Marka { get; set; }
        public abstract string Model { get; set; }

        //public string Cal()
        //{
        //    return "Muzik Aleti Çaldı";

        //}
        //public string AkortYap()
        //{
        //    return "Muzik Aleti Akort Yapti";
        //}

        //1-Abstract metodların govdesi olmaz.Sadece method imzaları vardır
        //2-Kalıtım verdikleri yerde govdesinin yazılması şarttır
        //3-Abstract methodlar ancak abstract siniflar içerisinde tanımlanabilir
        //4-Abstract olarak işaretlenmiş tum methodlar mutlaka kalitim verildiği yerde override eilmelidir


        public abstract string Cal();

        //virtual olarak işaretlenen metodların govdesi yazilabilir.
        //virtual metodlar abstract olsun veya olöasın bütün classlarda tanimlanabilir

        public virtual void AkordYap()
        {
            Console.WriteLine("Müzik Aleti Akord Edildi.");
        }
    }
}
