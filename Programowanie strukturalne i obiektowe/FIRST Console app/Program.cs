using System;

namespace FIRST_Console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number = 58;

            Console.Write("Wartość zmiennej to:");
            Console.WriteLine(number);

            Console.WriteLine("Wartość zmiennej to: " + number + " I koniec lekcji");
            Console.WriteLine($"Wartość zmiennej to: {number}, i koniec lekcji");

            Console.WriteLine("Prędkość to km\\h");
            Console.WriteLine(@"Prędkość to km\h");
            Console.WriteLine("C:\\Users\\Uczen\\Desktop\\AK");
            Console.WriteLine("C:/Users/Uczen/Desktop/AK");
            Console.WriteLine("C:/Users/Uczen/Desktop/AK");
            Console.WriteLine(@"C:/Users/Uczen/Desktop/AK");

            if (number == 5)
            {
                Console.WriteLine("Równe");
            }
            else
            {
                Console.WriteLine("Nie równa się");

                int number2 = number + 6;
            }
        }
    }
}
