using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170922_Černý3
{
    class Program
    {
        static void Main(string[] args)
        {

Console.Write(@"
    x
   xxx
  xxxxx
   xxx
  xxxxx
   xxx
 xxxxxxx
xxxxxxxxx
    x
    x
    x


");

            void VykresliStrom(int pocetMezer, int pocetListu, ConsoleColor barvaListu, ConsoleColor barvaPozadi)
            {
                Console.BackgroundColor = barvaPozadi;
                for (int i = 1; i <= pocetMezer; i++)
                {
                    Console.Write(" ");
                }


                Random rnd = new Random();
                for (int i = 1; i <= pocetListu; i++)
                {
                    int nahoda = rnd.Next(1, 10);
                    if (nahoda <= 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("x");
                    }
                    else
                    {
                        Console.BackgroundColor = barvaListu;
                        Console.ForegroundColor = barvaListu;
                        Console.Write("x");
                    } 
                }
                Console.Write("\n");
            }

            void VykresliKmen(int velikostKmene, ConsoleColor barvaListu, ConsoleColor barvaPozadi)
            {
                for (int k = 1; k <= velikostKmene; k++)
                {
                    Console.BackgroundColor = barvaPozadi;
                    for (int i = 1; i <= 4; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.BackgroundColor = barvaListu;
                    Console.ForegroundColor = barvaListu;
                    for (int i = 1; i <= 1; i++)
                    {
                        Console.Write("x");
                    }
                    Console.Write("\n");
                }
            }

            VykresliStrom(4, 1, ConsoleColor.Green, ConsoleColor.Black);
            VykresliStrom(3, 3, ConsoleColor.Green, ConsoleColor.Black);
            VykresliStrom(2, 5, ConsoleColor.Green, ConsoleColor.Black);
            VykresliStrom(3, 3, ConsoleColor.Green, ConsoleColor.Black);
            VykresliStrom(2, 5, ConsoleColor.Green, ConsoleColor.Black);
            VykresliStrom(3, 3, ConsoleColor.Green, ConsoleColor.Black);
            VykresliStrom(1, 7, ConsoleColor.Green, ConsoleColor.Black);
            VykresliStrom(0, 9, ConsoleColor.Green, ConsoleColor.Black);
            VykresliKmen(3, ConsoleColor.Gray, ConsoleColor.Black);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\nJan Černý\n27.09.2017");
            Console.ReadLine();

        }
    }
}