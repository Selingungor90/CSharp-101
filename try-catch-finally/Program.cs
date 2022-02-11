using System;

namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hatalı olan kodumuz.*/
            // try{
            //      Console.WriteLine("Bir sayı giriniz");
            // int sayi= Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Girmiş Olduğunuz Sayı: "+ sayi); 

            // }
            /*Hatayı tutan kod bloğu.*/
            // catch(Exception ex){
            //     Console.WriteLine("Hata"+ex);

            // }
           /*Finally hata alsın almasın çalışır. Zorunlu Değildir*/ 
        //    finally{
        //         Console.WriteLine("İşlem Tamamlandı");

        //     }

            try{
                // int a =int.Parse(null);
                int a = int.Parse("-20000000000000");

            }
            catch(ArgumentNullException ex) //boş değer hatası
            {

                Console.WriteLine("Boş Değer Girdiniz");
                Console.WriteLine(ex);

            }

            catch(OverflowException ex) //Değer büyük küçük hatası
            {
                Console.WriteLine("Çok küçük veya çok büyük sayı girdiniz");
                Console.WriteLine(ex);
            }
           
           catch(FormatException ex) // Veri tipi Format hatası
           {
               Console.WriteLine("Veri Tipi Uygun Değil");
               Console.WriteLine(ex);
           }
           finally{
               Console.WriteLine("İşlem Tamamlandı.");
           }
           
        }
    }
}
