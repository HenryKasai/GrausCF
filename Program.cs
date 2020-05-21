using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Insira uma temperatura em graus Celsius e veja esta temperatura em fahrenheit. ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string celsius = Console.ReadLine();

            double celsius1 = Convert.ToDouble(celsius);
            double result = celsius1 * 1.8 + 32;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sua temperatura em fahrenheit é " + result + "°F." );
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;


        }
    }
}
