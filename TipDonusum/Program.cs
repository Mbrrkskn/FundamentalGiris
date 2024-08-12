namespace TipDonusum;

class Program
{
    static void Main(string[] args)
    {
         /*
         Ornek:
         Ekrandan bir deger okumak için Console.ReadLine() metodu kullanılır

        */
        byte bsayi;           Byte bsayi2;
        sbyte sbyte1;         SByte sbyte2;
        short x,y;            Int16 a,b; //short
        int sayi1,sayi2;      Int32 sayi3,sayi4;
        float fsayi1;         Single fsayi2;
        long longsayi;        Int64 longsayi2;
        decimal dsayi;        Decimal dsayi2;
        double doublesayi;    Double doublesayi2;
         string input1,input2;

        System.Console.WriteLine("Birinci sayiyi giriniz:");
        input1=Console.ReadLine();
        //tip dönüşümünde 1.yol: convert sınıfını kullanmak
        sayi1 = Convert.ToInt32(input1);
        //2.yol
        sayi1 = int.Parse(input1); 
        x =(short)sayi1;  //Cast,Ricada bulunmak.Daha kucuk bir tipe cevirirken kullanırız
        doublesayi =sayi1;
        sayi2=(int)doublesayi;
        System.Console.WriteLine("İkinci sayiyi giriniz:");
        input2=Console.ReadLine();
        sayi2=int.Parse(input2);
        System.Console.WriteLine("String Toplamı:" +input1+input2);
        System.Console.WriteLine("Numerik Toplamı:" +(sayi1+sayi2));

        Console.WriteLine("Hello, World!");
    }
}
