using System;

namespace DegiskenTanimlama
{

public class Program
{
    public static void Main(string[] args)
    {
        
        #region Degiskenlere Deger aralıkları

        System.Console.WriteLine("Değişken uzunlukları");
        System.Console.WriteLine("Byte..........."); //byte kapınumarası
        System.Console.WriteLine(byte.MinValue + " " + byte.MaxValue);
        System.Console.WriteLine("Short..........."); 
        System.Console.WriteLine(short.MinValue + " " + short.MaxValue);
        System.Console.WriteLine("unsing short...........");
        System.Console.WriteLine(ushort.MinValue + " " + ushort.MaxValue);
        System.Console.WriteLine("int..........."); //sayi
        System.Console.WriteLine(int.MinValue + " " + int.MaxValue);
        System.Console.WriteLine("uint...........");
        System.Console.WriteLine(uint.MinValue + " " + uint.MaxValue);

        System.Console.WriteLine("long...........");
        System.Console.WriteLine(long.MinValue + " " + long.MaxValue);
        System.Console.WriteLine("ulong...........");
        System.Console.WriteLine(ulong.MinValue + " " + ulong.MaxValue);

//küsüratlı değerler,float(4 byte),double(8 byte),decimal(16 byte)

System.Console.WriteLine("float...........");
        System.Console.WriteLine(float.MinValue + " " + float.MaxValue);
        System.Console.WriteLine("double...........");
        System.Console.WriteLine(double.MinValue + " " + double.MaxValue);
        System.Console.WriteLine("decimal...........");
        System.Console.WriteLine(decimal.MinValue + " " + decimal.MaxValue);
        
        #endregion 

        #region Degisken Tanimlama Kuralları
       /*
       1-Degisken isimleri sayı ile başlayamaz
       2-reserve kelime kullanılmaz => static,void,public vb.
       3-Özel karakterlerden sadece" _ " kullanılır .
       4-En fazla 255 karakter olabilir 
       5-<Tip> <değişkenadi> = <ilk değer atamasi>;
       */

       //Birleşik kelimleren oluşan degisken isimlerindeki prensipler
       //int StokMiktarı => Pascal Case
       //stokMiktari  => camel case
       //stok_miktari  => snake case
       //stok-miktari => kebab case

        #endregion

        #region Ornek
        //Bir öğrencinin ad,soyad,dogumtarihi
        //ayakkabı numarası,tcno,gsm bilgilerini 
        //temsil edecek değişkenleri tanimlayalım

        string ad="Ali",soyad;
        DateTime DogumTarihi;
        DateTime Bugun = DateTime.Now; //İlk deger ataması
        byte ayakkabiNumarsai = 42;
        string tcno="12345678901";
        System.Console.WriteLine(tcno.Substring(7));
        //tcno.ToString().Substring(8,11);
        string gsm="+905316625633";
        
        #endregion
        // RunTime sirasında tipi belirleme
        var temp = 12;
       System.Console.WriteLine(temp);
       var sayi = 12.3; //Default olarak double olur,float için f, decimal için m
      

        #region Küsürlü Sayilar


 #endregion
        #region  Sabitler
        const float pi=3.14f;
        // pi = 4.56f; const degiskenlere 
        System.Console.WriteLine(pi);
        #endregion
        

       
    

       #region Degisklenlerin Yasam ömrü
       
       {
        string email = "ali@gmail.com";
        System.Console.WriteLine(yas);
        System.Console.WriteLine(email);
        {
            System.Console.WriteLine(yas);
            System.Console.WriteLine(email);
            System.Console.WriteLine(sayi1);
        }
         //System.Console.WriteLine(sayi1);  hata vericektir
       }
       //System.Console.WriteLine(email); hata vericektir
       //System.Console.WriteLine(sayi1);  hata vericektir
       #endregion
       
       #region nullable degısken tanımlama ve?
       
       string sehir = "";
       
       #endregion
       
        Console.WriteLine("Hello, World!");
    }
}
}

