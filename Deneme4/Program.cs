using System;

namespace Deneme4
{
    class Program
    {
        static void Main(string[] args)
        {

            double odemeTutari;
            Console.Write("Ürünün fiyatını giriniz:");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            if (fiyat >= 100)
                odemeTutari = fiyat;
            else
                odemeTutari = fiyat + 5;
            Console.WriteLine("Ödemeniz gereken tutar {0} TL'dir.", odemeTutari);

            Console.ReadKey();

        }
    }
}
