namespace _27_EventBomba
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bomba bomba = new Bomba();
            Telefon telefon = new Telefon();

            telefon.KelimeKullanildi += bomba.Patla;

            telefon.Gorusme();

            Console.ReadLine();


        }
    }
}
