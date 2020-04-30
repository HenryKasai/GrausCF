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

            int celsius1 = Convert.ToInt32(celsius);
            string um = "1,8";
            decimal um1 = Convert.ToDecimal(um);
            decimal result = celsius1 * um1 + 32;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sua temperatura em fahrenheit é " + result + "°F." );
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;


        }
    }
}
