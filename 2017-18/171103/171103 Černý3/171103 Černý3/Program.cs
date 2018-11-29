using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _171103_Černý3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ve škole jsem ForegroundColor nastavovat nemusel, doma ale na novějším OS (Windows 10) byla barva šedivá, tak pro jistotu změna na černou. ;)
            Console.ForegroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Write("Zadej jméno: ");
            string jmeno = Console.ReadLine();

            Console.Write("Zadej co jsi (holka/kluk): ");
            string pohlavi = Console.ReadLine();

            Console.Write("Zadej oblíbený alkoholický nápoj: ");
            string alko = Console.ReadLine();

            Console.Write("Zadej oblíbený nealkoholický nápojo: ");
            string nealko = Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Vyhodnocuji: ");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");

            Console.BackgroundColor = ConsoleColor.White;

            Console.Write($"\nAhoj {jmeno}\nJsi {pohlavi} a máš rád {alko} a {nealko}!");

            Console.ReadLine();
        }
    }
}
