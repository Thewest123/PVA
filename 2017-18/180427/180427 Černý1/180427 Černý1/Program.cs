using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180427_Černý1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Vypisování nahraných hodnot, uložených v poli, pozpátku");
                Console.Write("Velikost nového pole <2;20>: ");

                bool parsovani = int.TryParse(Console.ReadLine(), out int velikostPole);

                object[] pole;
                if (parsovani && velikostPole >=2 && velikostPole <=20) pole = new object[velikostPole];
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Špatně zadáno, zadej znovu!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    continue;
                }

                for (int i = 0; i < velikostPole; i++)
                {
                    Console.Write($"pole[{i}]: ");
                    pole[i] = Console.ReadLine();
                }

                Console.WriteLine("----------------");

                for (int i = velikostPole-1; i >= 0; i--)
                {
                    Console.WriteLine($"pole[{i}]: {pole[i]}");
                }

                Console.WriteLine("Odenteruj!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
