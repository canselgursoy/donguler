using System;
namespace donguler
{
    class Program
    {
        static void Main(string []args)
        {
            //ekranda girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.Write("Lütfen bir sayı giriniz.");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {
                if (i%2 == 1)
                    Console.WriteLine(i);

            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int çiftToplam = 0;

            for (int i = 1; i < 1000; i++)
            {
                if(i%2 == 1)
                    tekToplam += i; // tektoplam = tektoplam+i;

                else 
                    çiftToplam += i;

            }
            Console.WriteLine("tek toplam:" + tekToplam);
            Console.WriteLine("çift toplam:" + çiftToplam);

            //break, continue
            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                break;
                Console.WriteLine(i);


            }

            for (int i = 1; 1 < 10; i++)

            {
                if (i == 4)
                continue;
                Console.WriteLine(i);
                
            }



        }
    }
}

