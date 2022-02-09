using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit Conversion (Bilinçsiz Dönüşüm düşük kapasiteli bir değişkenin kendinden
            // daha yüksek kapasiteli bir değişkene atanma durumudur. Çevrimi sizin yerinize makina yapar.)

            Console.WriteLine("*****Implicit Conversion*****");

            byte a = 5;
            sbyte b =30 ;
            short c = 10;
            int d = a+b+c ;
            Console.WriteLine("d:"+ d);
            
            long h = d;
            Console.WriteLine("h:"+h);

            float i = h;
            Console.WriteLine("i:"+ i);

            string e = "Selin";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:"+g);


            //Explicit Conversion (Bilinçli Dönüşüm)
            //C# kendi kendine yapamadığı dönüşümlerdir. Convert ve Parse kullanarak dönüştürebiliriz.

            Console.WriteLine("****** Explicit Conversion ******");
            int x = 4;
            byte y= (byte)x;
            Console.WriteLine("y:"+y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:",t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:",v);

            //*****ToString Methodu******
            Console.WriteLine("***** To String Methodu *****");
            int xx = 6;
            string yy=xx.ToString();
            Console.WriteLine(yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:"+zz);

            //System.Convert
            Console.WriteLine("**** System.Convert Sınıfı ****");
            string s1= "10", s2="20";
            int sayi1,sayi2;
            int toplam;
            sayi1= Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1+sayi2;
            Console.WriteLine("Toplam: "+toplam);

            //Parse
            Console.WriteLine("****Parse****");
            ParseMethod();


        }
        public static void ParseMethod()
        {
                String metin ="10";
                String metin2 ="10.25";
                int rakam1;
                double double1;

                rakam1 = Int32.Parse(metin);
                double1 = double.Parse(metin2);
                Console.WriteLine("Rakam:"+ rakam1);
                Console.WriteLine("Double:"+rakam1);

        }
    }
}
