namespace _26_EventTrafikKontrol
{
    internal class Program
    {
        /*
         * Trafik polisi hiz kontrolu yapsin.
         * Otomobiller icin hiz siniri 120
         * Kamyonlar icin 80 
         * Pikap ve Ticariler icin de 90 olacak sekilde kontrol yapsin
         * 
         * Ticariler icin 1000 Tl , Kamyonlar icin 1500 Tl cezayi Firmaya  kessin
         * Otomobiller icin de 800 Tl traik cezasi kessin. 
         * 
         * Ekrana gelecek yazi Plaka no 'lu arabani şöförüne x hiziyla gittiginden dolayi 1000 TL ceva kesilmistir.
         * Cezayi kesen polisin adi ve soyadi 
         * 
         * 
         * Olay Sofor gaza basinca kontrol gerçeklessin.
         * 
         */
        static void Main(string[] args)
        {
            Polis polis = new Polis("Ali Demir");

            Sofor sofor1 = new Sofor("Müberra", "Keskin", "34 MBR 55", "Otomobil");
            Sofor sofor2 = new Sofor("Müberra", "Keskin", "34 MBR 55", "Ticari");

            sofor1.HizAsimi += polis.CezaKes;
            sofor2.HizAsimi += polis.CezaKes;

            sofor1.GazaBas(130);
            sofor2.GazaBas(100);


        }
    }
}
