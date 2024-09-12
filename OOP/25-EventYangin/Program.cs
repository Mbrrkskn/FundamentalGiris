namespace _25_EventYangin
{
    internal class Program
    {
        #region Konu
        /*
         * Bir mahallede insanlar olsun.
         * Bazilari sigara içsin
         * Sigara içilmesinden yada kisa devredenn dolayı yangın çıksın
         * Yangın çıkınca alarm çalsın.İtfaiyeye haber versin 
         * Alarm çalınca komsular rahatsız olsun yada kacsın
         * 
         */
        #endregion
        static void Main(string[] args)
        {
            Kablo kablo = new Kablo();
            Sigara sigara = new Sigara("Malboro");
            Alarm alarm = new Alarm();
            Itfaiye ıtfaiye = new Itfaiye();
            Insan ali = new Insan("ali");
            Insan veli = new Insan("veli");
            Insan ayse = new Insan("ayse");
            Insan fatma = new Insan("fatma");
            Insan hasan = new Insan("hasan");
            Insan kadriye = new Insan("kadriye");

            kablo.Yandim += alarm.AlarmCal;
            alarm.AlarmCaldi += ıtfaiye.MudahaleEt;
            alarm.AlarmCaldi += ali.RahatsızOl;
            alarm.AlarmCaldi += ayse.Kac;
            alarm.AlarmCaldi += fatma.RahatsızOl;
            alarm.AlarmCaldi += fatma.Kac;
            alarm.AlarmCaldi += hasan.RahatsızOl;
            alarm.AlarmCaldi += kadriye.RahatsızOl;
            alarm.AlarmCaldi += kadriye.Kac;

            sigara.Yandim += alarm.AlarmCal;
            sigara.Yandim += ıtfaiye.MudahaleEt;

            sigara.Yandim += ali.RahatsızOl;
            sigara.Yandim += ayse.RahatsızOl;

            sigara.SigaraIc();
            kablo.AkimGecir();



        }
    }
}
