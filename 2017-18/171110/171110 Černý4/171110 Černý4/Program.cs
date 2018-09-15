using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171110_Černý4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.CursorSize = 100;
            while (true)
            {
                try
                {
                    Console.Write("Zadej číslo: ");
                    int vstup = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mocnina čísla: " + vstup);
                    int vysledek = vstup;
                    Console.WriteLine("             -------------------------------------");
                    Console.CursorVisible = false;

                    for (int i = 2; true; i++)
                    {
                        Console.WriteLine($"{vstup} na {i} = {vysledek *= vstup}");
                        Console.Write("Odenteruj!");
                        Console.ReadLine();
                        Console.WriteLine("-----------------");
                    }
                }
                catch (SystemException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Musíte zadat číslo!");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
        }
    }
}
