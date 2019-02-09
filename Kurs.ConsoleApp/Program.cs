using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs.Primary;

namespace Kurs.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Console.Write("Podaj a: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Podaj b: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(a+" + "+b+" = "+(a+b));
            //Console.Write("Podaj swoje imie: ");
            //string imie = Console.ReadLine();
            //Console.Write("Podaj swoje nazwisko: ");
            //string nazwisko = Console.ReadLine();
            //Console.WriteLine("Witaj {0} {1} "
            //                  +DateTime.Now.Date.ToLongDateString(),imie,nazwisko); 
            #endregion


            Console.WriteLine("======= LICZBY PIERWSZE ================");
            Console.Write("Podaj do jakiej liczby szukac (wiecej niz 1): ");
            int limit = int.Parse(Console.ReadLine());
            PrimaryNumbers ps = new PrimaryNumbers(limit);
            Parzyste pp = new Parzyste(limit);
            Console.WriteLine("Liczby pierwsze:");
            foreach (int number in ps.GetNumbers())
            {
                Console.Write(number+" ");
            }
            Console.WriteLine("\nLiczby parzyste:");
            foreach (int number in pp.GetParzyste())
            {
                Console.Write(number + " ");
            }
            Console.ReadKey();
        }
    }
}
