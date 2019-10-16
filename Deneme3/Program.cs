using System;

namespace Deneme3
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin;
            int tekrar;
            Console.WriteLine("Çoğaltılmasını istediğiniz metni girin");
            metin = Console.ReadLine();
            Console.WriteLine("Kaç defa yazılacak ?");
            tekrar = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tekrar; i++)
            {
                Console.WriteLine(metin);
            }
            Console.ReadKey();
        }
    }
}
