using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _180913_Černý1
{
    class Program
    {
        static List<string> nickyList = new List<string>();
        static List<string> heslaList = new List<string>();

        static void Main(string[] args)
        {
            Vytvorit();
            NacistLoginy();
            OvereniLoginu();
        }

        static void Vytvorit()
        {
            if (!File.Exists("login.txt"))
            {
                using (var sw = new StreamWriter("login.txt"))
                {
                    sw.WriteLine("admin*admin");
                }
            }
        }

        static void NacistLoginy()
        {
            string[] radky = File.ReadAllLines("login.txt");

            nickyList.Clear();
            heslaList.Clear();

            foreach (string radek in radky)
            {
                int poziceHvezdicky = radek.IndexOf('*');

                string nick = radek.Substring(0, poziceHvezdicky);
                string heslo = radek.Substring(poziceHvezdicky + 1);

                nickyList.Add(nick);
                heslaList.Add(heslo);
            }
        }

        static void OvereniLoginu()
        {
            while (true)
            {
                Console.WriteLine("Zalogujte se");
                Console.WriteLine("------------------------------------------");

                Console.Write("Nick: ");
                string nick = Console.ReadLine();

                Console.Write("Heslo: ");
                string heslo = Console.ReadLine();

                if (nick != string.Empty && heslo != string.Empty)
                {
                    if (!nick.Contains('*') && !heslo.Contains('*'))
                    {
                        if (nickyList.Contains(nick) &&  nickyList.IndexOf(nick) == heslaList.IndexOf(heslo))
                        {
                            Console.WriteLine("Tento nick a heslo existuje!");
                            Menu();
                            break;
                        }
                        else Console.WriteLine("Nesprávný nick nebo heslo!");
                    }
                    else Console.WriteLine("Nick a heslo nesmí obsahovat hvězdičku (*)!");
                }
                else Console.WriteLine("Nick a heslo nesmí být prázdné!");

                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"{"w",15} ~ výpis nicků");
                Console.WriteLine($"{"Ctrl + Alt + w",15} ~ výpis nicků a hesel");
                Console.WriteLine($"{"n",15} ~ nový login");
                Console.WriteLine($"{"k",15} ~ konec");
                Console.WriteLine("------------------------------------------");
                Console.Write("Co si přejete: ");

                var cki = Console.ReadKey();
                Console.WriteLine();

                if (cki.Key == ConsoleKey.W && cki.Modifiers == 0) VypisNicku();
                else if (cki.Key == ConsoleKey.W && cki.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt)) VypisNickuAHesel();
                else if (cki.Key == ConsoleKey.N && cki.Modifiers == 0) NovyLogin();
                else if (cki.Key == ConsoleKey.K && cki.Modifiers == 0) break;
                else Console.WriteLine($"{cki.Modifiers} + {cki.Key} ~ {cki.KeyChar} >> Neexistuje!");
            }
        }

        static void VypisNicku()
        {
            NacistLoginy();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"*-----*-------------------------*");
            Console.WriteLine($"*{"Číslo",5}|{"Nick",-25}|");
            Console.WriteLine($"*-----*-------------------------*");
            for (int i = 0; i < nickyList.Count; i++)
            {                
                Console.WriteLine($"|{i+1,5:00}|{nickyList[i],-25}|");
            }
            Console.WriteLine($"*-----*-------------------------*");

            Console.ResetColor();
        }

        static void VypisNickuAHesel()
        {
            NacistLoginy();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"*-----*-------------------------*-------------------------*");
            Console.WriteLine($"|{"Číslo",5}|{"Nick",-25}|{"Heslo",-25}*");
            Console.WriteLine($"*-----*-------------------------*-------------------------*");
            for (int i = 0; i < nickyList.Count; i++)
            {
                Console.WriteLine($"|{i+1,5:00}|{nickyList[i],-25}|{heslaList[i],-25}|");
            }
            Console.WriteLine($"*-----*-------------------------*-------------------------*");

            Console.ResetColor();
        }

        static void NovyLogin()
        {
            Console.WriteLine("Zadejte:");
            Console.WriteLine("------------------------------------------");

            Console.Write("Nick: ");
            string nick = Console.ReadLine();

            Console.Write("Heslo: ");
            string heslo = Console.ReadLine();

            if (nick != string.Empty && heslo != string.Empty)
            {
                if (!nick.Contains('*') && !heslo.Contains('*'))
                {
                    if (!nickyList.Contains(nick))
                    {
                        using (var sw = new StreamWriter("login.txt", true))
                        {
                            sw.WriteLine($"{nick}*{heslo}");
                        }
                    }
                    else Console.WriteLine("Zadaný nick již v souboru existuje!");
                }
                else Console.WriteLine("Nick a heslo nesmí obsahovat hvězdičku (*)!");
            }
            else Console.WriteLine("Nick a heslo nesmí být prázdné!");
        }
    }
}
