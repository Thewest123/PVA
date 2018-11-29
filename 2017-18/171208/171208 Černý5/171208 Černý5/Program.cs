using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171208_Černý5
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
                Console.WriteLine($"{"k|K",-7} ~ konec");
                Console.WriteLine($"{"r|č",-7} ~ červená");
                Console.WriteLine($"{"g|z",-7} ~ zelená");
                Console.WriteLine($"{"b|mo",-7} ~ modrá");
                Console.WriteLine($"{"c|t",-7} ~ tyrkysová");
                Console.WriteLine($"{"m|bo",-7} ~ bordo");
                Console.WriteLine($"{"y|ž",-7} ~ žlutá");
                Console.WriteLine($"{"R|Č",-7} ~ tmavě červená");
                Console.WriteLine($"{"G|Z",-7} ~ tmavě zelená");
                Console.WriteLine($"{"B|MO|Mo",-7} ~ tmavě modrá");
                Console.WriteLine($"{"C|T",-7} ~ tmavě tyrkysová");
                Console.WriteLine($"{"M|BO|Bo",-7} ~ tmavě bordo");
                Console.WriteLine($"{"Y|Ž",-7} ~ tmavě žlutá");
                Console.WriteLine($"{"prázdný",-7} ~ znova");
                Console.WriteLine("---------------------------");
                Console.Write("Co chceš? ");
                string vstup = Console.ReadLine();

                if (vstup == "k" || vstup == "K")
                {
                    Console.WriteLine("Ahoj!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
                //Mala pismena
                else if (vstup == "r" || vstup == "č")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vybraná barva: Red");
                }
                else if (vstup == "g" || vstup == "z")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vybraná barva: Green");
                }
                else if (vstup == "b" || vstup == "mo")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Vybraná barva: Blue");
                }
                else if (vstup == "c" || vstup == "t")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Vybraná barva: Cyan");
                }
                else if (vstup == "m" || vstup == "bo")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Vybraná barva: Magenta");
                }
                else if (vstup == "y" || vstup == "ž")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Vybraná barva: Yellow");
                }
                //Velka pismena
                else if (vstup == "R" || vstup == "Č")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Vybraná barva: DarkRed");
                }
                else if (vstup == "G" || vstup == "Z")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Vybraná barva: DarkGreen");
                }
                else if (vstup == "B" || vstup == "Mo" || vstup == "MO")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Vybraná barva: DarkBlue");
                }
                else if (vstup == "C" || vstup == "T")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Vybraná barva: DarkCyan");
                }
                else if (vstup == "M" || vstup == "Bo" || vstup == "BO")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Vybraná barva: DarkMagenta");
                }
                else if (vstup == "Y" || vstup == "Ž")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Vybraná barva: DarkYellow");
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
