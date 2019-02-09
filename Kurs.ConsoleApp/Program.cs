using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a+" + "+b+" = "+(a+b));
            Console.Write("Podaj swoje imie: ");
            string imie = Console.ReadLine();
            Console.Write("Podaj swoje nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Witaj {0} {1} "
                              +DateTime.Now.Date.ToLongDateString(),imie,nazwisko);
            Console.ReadKey();
        }
    }
}
