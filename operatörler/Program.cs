using System;

namespace operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            

       Console.WriteLine("*****Atama ve İlişkisel Atama*****"); 
       //atama ve işlemli atama
         
        int  y=2;
        //  y=y+2;
        //  Console.WriteLine(y);
        y+=2;
        Console.WriteLine(y);

        Console.WriteLine("*****Mantıksal Operatörler*****");


        //Mantıksal Operatörler

        bool isSuccess = true ;
        bool isComplated = false;

        if(isSuccess&&isComplated)
        Console.WriteLine("perfect");
        if(isSuccess||isComplated)
        Console.WriteLine("Great");
        if(isSuccess && !isComplated)
        Console.WriteLine("Fine");

        Console.WriteLine("*****İlişkisel Operatörler*****");
        //İlişkisel Operatörler

        int a =3;
        int b = 4;

        bool sonuc = a<b;
        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc = a<=b;
        Console.WriteLine(sonuc);
        sonuc = a>=b;
        Console.WriteLine(sonuc);
        sonuc = a!=b;
        Console.WriteLine(sonuc);
        sonuc = a==b;
        Console.WriteLine(sonuc);

        Console.WriteLine("****Aritmatik Operatörler****");
        int sayi1=3;
        int sayi2=2;
        int sayi3= sayi1+sayi2;
        Console.WriteLine(sayi3);

        Console.WriteLine("****Mod Alma***");

        int sayi4 = 20%2;
        if(sayi4==0)
        Console.WriteLine("Sayı Çifttir");
        if(sayi4==1)
        Console.WriteLine("Sayı Tektir");
        
        

        }
    }
}
