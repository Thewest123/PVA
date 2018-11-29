using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171208_Černý2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Konverze a formátování";

            while (true)
            {
                Console.Clear();

                try
                {
                    Console.Write("Zadej celé číslo: ");
                    int cele = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Zadej desetinné číslo: ");
                    decimal desetinne = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine($@"Konverze a formátování:
┌────────────────────┬────────────────────┬────────────────────┐
│{"Typ formátování",20}│{"int",-20}│{"decimal",-20}│
├────────────────────┼────────────────────┼────────────────────┤
│{"měna",20}│{cele,-20:c}│{desetinne,-20:c}│
│{"exponenciální",20}│{cele,-20:e}│{desetinne,-20:e}│
│{"s desetinnou čárkou",20}│{cele,-20:f}│{desetinne,-20:f}│
│{"číslo",20}│{cele,-20:n}│{desetinne,-20:n}│
│{"procenta",20}│{cele,-20:p}│{desetinne,-20:p}│
│{"hexadecimal",20}│{cele,-20:x}│{"",-20}│
└────────────────────┴────────────────────┴────────────────────┘
");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Write("Odenteruj!");
                Console.ReadLine();
            }
        }
    }
}
