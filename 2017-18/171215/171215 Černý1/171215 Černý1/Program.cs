using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;

namespace _171215_Černý1
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

                Console.WriteLine($"┌───────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"  MENU",-51}│");
                Console.WriteLine($"├──────────────────────────────┬────────────────────┤");
                Console.WriteLine($"│{ "RED",29} │ { "tmavě červená",-19}│");
                Console.WriteLine($"│{ "GREEN",29} │ { "tmavě zelená",-19}│");
                Console.WriteLine($"│{ "BLUE",29} │ { "tmavě modrá",-19}│");
                Console.WriteLine($"│{ "CYAN",29} │ { "tmavě tyrkysová",-19}│");
                Console.WriteLine($"│{ "MAGENTA",29} │ { "tmavě bordo",-19}│");
                Console.WriteLine($"│{ "YELLOW",29} │ { "tmavě žlutá",-19}│");
                Console.WriteLine($"│{ "GRAY",29} │ { "tmavě šedá",-19}│");
                Console.WriteLine($"├──────────────────────────────┼────────────────────┤");
                Console.WriteLine($"│{ "red│Red│rEd│reD│REd│ReD│rED",29} │ { "červená",-19}│");
                Console.WriteLine($"│{ "green│...│gREEN",29} │ { "zelená",-19}│");
                Console.WriteLine($"│{ "blue│...│bLUE",29} │ { "modrá",-19}│");
                Console.WriteLine($"│{ "cyan│...│cYAN",29} │ { "tyrkysová",-19}│");
                Console.WriteLine($"│{ "magenta│...│mAGENTA",29} │ { "bordo",-19}│");
                Console.WriteLine($"│{ "yellow│...│yELLOW",29} │ { "žlutá",-19}│");
                Console.WriteLine($"│{ "gray│...│gRAY",29} │ { "šedá",-19}│");
                Console.WriteLine($"├──────────────────────────────┼────────────────────┤");
                Console.WriteLine($"│{ "prázdný",29} │ { "znova",-19}│");
                Console.WriteLine($"├──────────────────────────────┼────────────────────┤");
                Console.WriteLine($"│{"k│K│e│E",29} │ {"konec",-19}│");
                Console.WriteLine($"└──────────────────────────────┴────────────────────┘");
                Console.Write($"Co chceš? ");

                string vstup = Console.ReadLine();
                if (vstup == "RED") VypisBarevnyVystup("Dark"+vstup);
                else if (vstup == "GREEN") VypisBarevnyVystup("Dark"+vstup);
                else if (vstup == "BLUE") VypisBarevnyVystup("Dark"+vstup);
                else if (vstup == "CYAN") VypisBarevnyVystup("Dark"+vstup);
                else if (vstup == "MAGENTA") VypisBarevnyVystup("Dark"+vstup);
                else if (vstup == "YELLOW") VypisBarevnyVystup("Dark"+vstup);
                else if (vstup == "GRAY") VypisBarevnyVystup("Dark"+vstup);
                else if (vstup.ToLower() == "red") VypisBarevnyVystup(vstup);
                else if (vstup.ToLower() == "green") VypisBarevnyVystup(vstup);
                else if (vstup.ToLower() == "blue") VypisBarevnyVystup(vstup);
                else if (vstup.ToLower() == "cyan") VypisBarevnyVystup(vstup);
                else if (vstup.ToLower() == "magenta") VypisBarevnyVystup(vstup);
                else if (vstup.ToLower() == "yellow") VypisBarevnyVystup(vstup);
                else if (vstup.ToLower() == "gray") VypisBarevnyVystup(vstup);
                else if (vstup.ToLower() == "k" || vstup.ToLower() == "e") break;
                else if (vstup == "") continue;
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{vstup} neumím!");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("Odenteruj!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Ahoj");
            Sleep(1000);
        }

        static void VypisBarevnyVystup(string barvaVstup)
        {
            //S Enum.Parse() poradil strýček Google ;)
            ConsoleColor barva = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), barvaVstup, true);

            Console.ForegroundColor = barva;
            Console.WriteLine($"Vybraná barva: {barva}");
            Console.Write("Odenteruj!");
            Console.ReadLine();
        }
    }
}
