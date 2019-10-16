using System;

namespace Deneme7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 60, 80, 55, 42, 13, 24, 26, 25, 26, 55, 45, 50, 50, 40 };
            int sayi, kontrol = 0;
            Console.Write("Bir sayı giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    kontrol++;
                }
            }
            if (kontrol == 0)
            {
                Console.WriteLine("Sayı dizi içinde bulunamadı...");
            }
            else
            {
                Console.WriteLine("Bu sayı dizide {0} adet var", kontrol);
            }
            Console.ReadLine();
        }
    }
}
