using System;

namespace Deneme5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Lütfen bir sayı girin:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
                Console.WriteLine("{0} sayısı pozitif bir sayıdır.", sayi);
            else if (sayi < 0)
                Console.WriteLine("{0} sayısı negatif bir sayıdır.", sayi);
            else
                Console.WriteLine("Girilen sayı 0'a eşittir.");

            Console.ReadKey();
        }
    }
}
