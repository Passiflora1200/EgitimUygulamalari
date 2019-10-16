using System;

namespace Deneme1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 10, 20, 15, 5, 7, 3, 4, 12, 8, 39, 2 };
            int enbuyuk = dizi[0];
            int enkucuk = dizi[0];

            for (int i = 0; i < dizi.Length; i++)
            {

                if (dizi[i] > enbuyuk)
                    enbuyuk = dizi[i];

                if (dizi[i] < enkucuk)
                    enkucuk = dizi[i];

            }

            Console.WriteLine("En küçük :{0}", enkucuk);
            Console.WriteLine("En büyük :{0}", enbuyuk);
        }
    }
}
