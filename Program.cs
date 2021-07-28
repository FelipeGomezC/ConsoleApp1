using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string lecturaLineaConsola="";
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello World!");
            lecturaLineaConsola = Console.ReadLine();
            Console.WriteLine("El texto escrito fue: "+lecturaLineaConsola);
        }
    }
}
