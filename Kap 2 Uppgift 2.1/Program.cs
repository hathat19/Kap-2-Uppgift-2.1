using System;
namespace Uppgift2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frågar efter favoritbok
            Console.WriteLine("Vad heter din favoritbok?");
            string favBook = Console.ReadLine();

            //Skriver ut namnet på boken
            Console.WriteLine($"Din favoritbok heter {favBook}!");
            Console.ReadKey();
        }
    }
}
