using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171208_Černý4
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
                Console.WriteLine("k|K ~ konec");
                Console.WriteLine("r|R ~ červená");
                Console.WriteLine("g|G ~ zelená");
                Console.WriteLine("b|B ~ modrá");
                Console.WriteLine("c|C ~ tyrkysová");
                Console.WriteLine("m|M ~ bordo");
                Console.WriteLine("y|Y ~ žlutá");
                Console.WriteLine("prázdný ~ znova");
                Console.WriteLine("---------------------------");
                Console.Write("Co chceš? ");
                string vstup = Console.ReadLine();
                string vstupMaly = vstup.ToLower();

                if (vstupMaly == "k")
                {
                    Console.WriteLine("Ahoj!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
                else if (vstupMaly == "r")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vybraná barva: Red");
                }
                else if (vstupMaly == "g")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vybraná barva: Green");
                }
                else if (vstupMaly == "b")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Vybraná barva: Blue");
                }
                else if (vstupMaly == "c")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Vybraná barva: Cyan");
                }
                else if (vstupMaly == "m")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Vybraná barva: Magenta");
                }
                else if (vstupMaly == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Vybraná barva: Yellow");
                }
                else if (vstupMaly == "") { continue; }
                //Continue; jsem si vygooglil. Snad nevadí :P
                //Zkoušel jsem celý program udělat bez použití návěstí.
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{vstupMaly} neumím!!");
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.Write("Odenteruj!");
                Console.ReadLine();
            }
        }
    }
}
