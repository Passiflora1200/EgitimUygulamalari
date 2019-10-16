using System;

namespace Deneme6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaçıncı ayda olduğunuzu girin:");
            int ay = Convert.ToInt32(Console.ReadLine());
            switch (ay)
            {
                
                case 1:
                    Console.Write("Ocak");
                    break;
                case 2:
                    Console.Write("Şubat");
                    break;
                case 3:
                    Console.Write("Mart");
                    break;
                case 4:
                    Console.Write("Nisan");
                    break;
                case 5:
                    Console.Write("Mayıs");
                    break;
                case 6:
                    Console.Write("Haziran");
                    break;
                case 7:
                    Console.Write("Temmuz");
                    break;
                case 8:
                    Console.Write("Ağustos");
                    break;
                case 9:
                    Console.Write("Eylül <3");
                    break;
                case 10:
                    Console.Write("Ekim");
                    break;
                case 11:
                    Console.Write("Kasım");
                    break;
                case 12:
                    Console.Write("ARALIK");
                    break;
                default:
                    Console.Write("Ay bilgisini yanlış girdiniz.");
                    break;
            }
        }
    }
}
