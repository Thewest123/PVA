using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171208_Černý3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Title = "Barvy";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("---------------------------");
                Console.WriteLine("k ~ konec");
                Console.WriteLine("r ~ červená");
                Console.WriteLine("g ~ zelená");
                Console.WriteLine("b ~ modrá");
                Console.WriteLine("c ~ tyrkysová");
                Console.WriteLine("m ~ bordo");
                Console.WriteLine("y ~ žlutá");
                Console.WriteLine("prázdný ~ znova");
                Console.WriteLine("---------------------------");
                Console.Write("Co chceš? ");
                string vstup = Console.ReadLine();

                if (vstup == "k")
                {
                    Console.WriteLine("Ahoj!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
                else if (vstup == "r")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vybraná barva: Red");
                }
                else if (vstup == "g")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vybraná barva: Green");
                }
                else if (vstup == "b")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Vybraná barva: Blue");
                }
                else if (vstup == "c")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Vybraná barva: Cyan");
                }
                else if (vstup == "m")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Vybraná barva: Magenta");
                }
                else if (vstup == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Vybraná barva: Yellow");
                }
                else if (vstup == "") { continue; }
                //Continue; jsem si vygooglil. Snad nevadí :P
                //Zkoušel jsem celý program udělat bez použití návěstí.
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{vstup} neumím!!");
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.Write("Odenteruj!");
                Console.ReadLine();
            }   
        }
    }
}
