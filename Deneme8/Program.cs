using System;

namespace Deneme8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1, z;
            int sayi;

            Console.WriteLine("Adım sayısını giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());         

            Console.WriteLine(x + " " + "\n" + y + " ");

            for (int i = 0; i < sayi - 2; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;

            }
        }
    }
}
