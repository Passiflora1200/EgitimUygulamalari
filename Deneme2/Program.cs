using System;

namespace Deneme2
{
    class Program
    {
        public static bool Lütfen { get; private set; }
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc = 0;
            Console.Write("Birinci sayıyı girin:");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı girin:");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Toplama için\t---> t \nÇıkarma için\t---> ç \nÇarpma için\t---> x \nBölme için\t---> b tuşuna basınız.");
            string islem = Console.ReadLine();
            if (islem == "t")
                sonuc = sayi1 + sayi2;
            else if (islem == "ç")
                sonuc = sayi1 - sayi2;
            else if (islem == "x")
                sonuc = sayi1 * sayi2;
            else if (islem == "b")
                sonuc = sayi1 / sayi2;
            else
                Console.WriteLine("Yanlış bir tuşa bastınız.");
            Console.WriteLine("İşlemin Sonucu:" + sonuc);

            Console.ReadKey();
        }
    }
}
