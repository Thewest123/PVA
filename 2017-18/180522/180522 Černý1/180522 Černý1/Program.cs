using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180522_Černý1
{
    class Program
    {
        static string _soubor = "t";
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            while (true)
            {
                Console.Clear();
                Console.Write($@"Menu:
soubor: {_soubor}.txt
k ~ konec
fe ~ změň _soubor? BEZ KONCOVKY!!!!
fc ~ vytvoř _soubor? BEZ KONCOVKY!!!!
we ~ přidej text na konec
ws ~ přidej!!!! text na začátek
ra ~ vypiš celý obsah souboru
rl ~ vypiš obsah souboru po řádcích
rf ~ vypiš obsah souboru první řádek a zbytek
Co chceš:");

                string vstup = Console.ReadLine();

                if (vstup == "k") break;
                if (vstup == "fe") ZmenSoubor();
                else if (vstup == "fc") VytvorSoubor();
                else if (vstup == "we") PridejTextNaKonec();
                else if (vstup == "ws") PridejTextNaZacatek();
                else if (vstup == "ra") VypisCelyObsah();
                else if (vstup == "rl") VypisObsahPoRadcich();
                else if (vstup == "rf") VypisPrvniRadekAZbytek();
                else Console.WriteLine("Neumím!");

                Console.WriteLine("Odenteruj!");
                Console.ReadLine();
            }
        }

        private static void ZmenSoubor()
        {
            Console.Write("Zadej adresu souboru: ");
            string vstup = Console.ReadLine();

            if (File.Exists(vstup + ".txt"))
            {
                Console.WriteLine($"Soubor {vstup}.txt existuje!");
                _soubor = vstup;
            }
            else
            {
                Console.WriteLine($"Soubor {vstup}.txt neexistuje!");
            }
        }

        private static void VytvorSoubor()
        {
            Console.Write("Zadej adresu souboru: ");
            string vstup = Console.ReadLine();

            if (!File.Exists(vstup + ".txt"))
            {
                Console.WriteLine($"Soubor {vstup}.txt NEexstiuje a je vytvořen!");
                File.Create(vstup + ".txt");
                _soubor = vstup;
            }
            else
            {
                Console.WriteLine($"Soubor {vstup}.txt již existuje!");
            }
        }

        private static void PridejTextNaKonec()
        {
            Console.Write("Zadej text: ");
            string vstup = Console.ReadLine();

            //var fs = new FileStream(_soubor + ".txt", FileMode.Append);
            //var sw = new StreamWriter(fs);

            //sw.WriteLine(vstup);

            //sw.Close();
            //fs.Close();

            //Jen jsem si chtěl místo toho zkusit using
            using (var sw = new StreamWriter(_soubor + ".txt", true))
            {
                sw.WriteLine(vstup);
            }
        }

        private static void PridejTextNaZacatek()
        {
            Console.Write("Zadej text: ");
            string vstup = Console.ReadLine();

            //var fs = new FileStream(_soubor + ".txt", FileMode.Open);
            //var sr = new StreamReader(fs);
            //var sw = new StreamWriter(fs);

            //string texToEnd = sr.ReadToEnd();
            //sw.WriteLine(vstup+"\n"+textToEnd);

            //sr.Close();
            //fs.Close();

            string textToEnd;

            using (var sr = new StreamReader(_soubor + ".txt"))
            {
                textToEnd = sr.ReadToEnd();
            }

            using (var sw = new StreamWriter(_soubor + ".txt", false))
            {
                sw.WriteLine(vstup+"\n"+textToEnd);
            }
        }

        private static void VypisCelyObsah()
        {
            var fs = new FileStream(_soubor + ".txt", FileMode.Open);
            var sr = new StreamReader(fs);

            Console.WriteLine(">>");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sr.ReadToEnd());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("<<");

            sr.Close();
            fs.Close();
        }

        private static void VypisObsahPoRadcich()
        {
            var fs = new FileStream(_soubor + ".txt", FileMode.Open);
            var sr = new StreamReader(fs);

            Console.WriteLine(">>");
            Console.ForegroundColor = ConsoleColor.Green;

            int i = 1;
            while (!sr.EndOfStream)
            {
                Console.WriteLine($"{i} ~ {sr.ReadLine()}");
                i++;
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("<<");

            sr.Close();
            fs.Close();
        }

        private static void VypisPrvniRadekAZbytek()
        {
            var fs = new FileStream(_soubor + ".txt", FileMode.Open);
            var sr = new StreamReader(fs);

            Console.WriteLine(">>");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(sr.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sr.ReadToEnd());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("<<");

            sr.Close();
            fs.Close();
        }
    }
}
