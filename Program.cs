using System;

namespace FirstGIthubProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę!");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę!");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( a + b );
            Console.WriteLine("eelo");
            Console.ReadKey();
        }
    }
}

