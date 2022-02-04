using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnteger Variables Practice
           int sayi=1; int sayi1=5;
           int sayi2= sayi+sayi1;
            Console.WriteLine(sayi2);

            //String and Date Time Variables Practice

           String tarih = DateTime.Now.ToString("dd.mm.yyyy");

            // Boolen Variables Practice

            bool s = 10>2;
            Console.WriteLine(s); // True 
            bool y = 10<3; //False
            Console.WriteLine(y); 

            //String Variables Practice

            string ad = "selin";
            string soyad = "yazıcı";
            Console.WriteLine("Adınız : "+ ad+" "+ "Soyadınız:"+soyad);

            //Long Variables Practice

            long sayi4 = 454848848484;
            Console.WriteLine(sayi4);

            //Char Variables Practice

            char c = 't';
            Console.WriteLine(c);

            //Double Variables Practice 

            double tl = 5.99;
            Console.WriteLine("Tutar: "+tl);
        

        
        }
    }
}
