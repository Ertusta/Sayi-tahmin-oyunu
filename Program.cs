
using System;



namespace ProgramTest
{

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double a = random.Next(0, 101);
            Console.WriteLine("sayı gir ");
            Double b = Convert.ToDouble(Console.ReadLine());
            int tahmin = 1;

            while (a!=b)
            {

                if (a > b)
                {
                    Console.WriteLine("daha büyük bir sayı gir");
                    b = Convert.ToDouble(Console.ReadLine());
                    tahmin++;
                }
                else
                {
                    Console.WriteLine("daha küçük bir sayı gir");
                    b = Convert.ToDouble(Console.ReadLine());
                    tahmin++;
                }
            }
            Console.WriteLine("tahmin sayısı: " + tahmin);
            Console.WriteLine("doğru tahmin");






        }

        
    }
}