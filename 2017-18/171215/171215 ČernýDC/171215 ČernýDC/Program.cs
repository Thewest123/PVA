using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;

namespace _171215_ČernýDC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Menu";

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"┌───────────────────────────────────────────┐");
                Console.WriteLine($"│{"Menu:",-42} │");
                Console.WriteLine($"├───────────┬───────────────────────────────┤");
                Console.WriteLine($"│{"k nebo K",10} │ {"Konec",-30}│");
                Console.WriteLine($"│{"prázdný",10} │ {"Začátek",-30}│");

                Console.WriteLine($"│{"malé p",10} │ {"Přičítání po jedné",-30}│");
                Console.WriteLine($"│{"velké P",10} │ {"Příčítání po zadaném č.",-30}│");

                Console.WriteLine($"│{"malé o",10} │ {"Odečítání po jedné",-30}│");
                Console.WriteLine($"│{"velké O",10} │ {"Odečítání po zadaném č.",-30}│");

                Console.WriteLine($"│{"malé n",10} │ {"Násobení po jedné",-30}│");
                Console.WriteLine($"│{"velké N",10} │ {"Násobení po zadaném č.",-30}│");
                
                Console.WriteLine($"│{"malé d",10} │ {"Dělení po jedné",-30}│");
                Console.WriteLine($"│{"velké D",10} │ {"Dělení po zadaném č.",-30}│");

                Console.WriteLine($"└───────────┴───────────────────────────────┘");

                Console.Write($"\nCo si přeješ: ");
                string vstup = Console.ReadLine();

                if (vstup.ToLower() == "k") break;
                if (vstup == "") continue;

                if (vstup == "p") PricitejPoJedne();
                else if (vstup == "P") PricitejPoZadanem();
                else if (vstup == "o") OdecitejPoJedne();
                else if (vstup == "O") OdecitejPoZadanem();
                else if (vstup == "n") NasobPoJedne();
                else if (vstup == "N") NasobPoZadanem();
                else if (vstup == "d") DelPoJedne();
                else if (vstup == "D") DelPoZadanem();
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write($"{vstup} neumím!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Sleep(2000);
                }

            }
            Console.WriteLine("\nAhoj!");
            Sleep(1000);
        }

        #region Pricitani
        static void PricitejPoJedne()
        {
            //Celý loop, kvůli podmínce pocatecni<konecna
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"┌────────────────────────────────────────┐");
                Console.WriteLine($"│{"Přičítání po jedné",-40}│");
                Console.WriteLine($"└────────────────────────────────────────┘");

                int pocatecni;
                int konecna;

                //Loop pro počáteční hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro počáteční hodnotu <-100;100>: ");
                    try
                    {
                        pocatecni = Convert.ToInt32(Console.ReadLine());

                        if (pocatecni <= 100 && pocatecni >= -100)
                        {
                            break;
                        }

                        Console.Write("Počáteční hodnota musí být v z intervalu <-100;100>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                //Loop pro konečnou hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro konečnou hodnotu <-100;100>: ");

                    try
                    {
                        konecna = Convert.ToInt32(Console.ReadLine());

                        if (konecna <= 100 && konecna >= -100)
                        {
                            break;
                        }

                        Console.Write("Konečná hodnota musí být v z intervalu <-100;100>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Kontrola hodnot
                if (pocatecni < konecna)
                {
                    Console.WriteLine();

                    for (int i = pocatecni+1; i <= konecna; i++)
                        //(pocatecni+1 pro vynechani prvniho nuloveho pricitani)
                    {
                        Console.WriteLine($" >> {pocatecni} + {i-pocatecni} = {i}");
                    }

                    Console.WriteLine();
                    Console.Write("Odenteruj!");
                    Console.ReadLine();
                    break;
                }

                Console.Write("Počáteční hodnota je větší než konečná!");
                Console.ReadLine();

            }
        }

        static void PricitejPoZadanem()
        {
            //Celý loop, kvůli podmínce pocatecni<konecna
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"┌────────────────────────────────────────┐");
                Console.WriteLine($"│{"Přičítání po zadané hodnotě",-40}│");
                Console.WriteLine($"└────────────────────────────────────────┘");

                int pocatecni;
                int konecna;
                int pricitani;

                //Loop pro počáteční hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro počáteční hodnotu <-100;100>: ");
                    try
                    {
                        pocatecni = Convert.ToInt32(Console.ReadLine());

                        if (pocatecni <= 100 && pocatecni >= -100)
                        {
                            break;
                        }
                        Console.Write("Počáteční hodnota musí být v z intervalu <-100;100>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                
                //Loop pro konečnou hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro konečnou hodnotu <-100;100>: ");

                    try
                    {
                        konecna = Convert.ToInt32(Console.ReadLine());

                        if (konecna <= 100 && konecna >= -100)
                        {
                            break;
                        }
                        Console.Write("Konečná hodnota musí být v z intervalu <-100;100>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Loop pro honotu přičítání
                while (true)
                {
                    Console.Write("Zadej číslo pro hodnotu příčítání <2;50>: ");
                    try
                    {
                        pricitani = Convert.ToInt32(Console.ReadLine());

                        if (pricitani <= 50 && pricitani >= 2)
                        {
                            break;
                        }
                        Console.Write("Přičítací hodnota musí být v z intervalu <2;50>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Kontrola hodnot
                if (pocatecni < konecna)
                {
                    //Kontrola, jestli jde přičítat zadané číslo
                    if (pricitani <= (konecna - pocatecni))
                    {
                        Console.WriteLine($"\nVýpis od {pocatecni} do {konecna} po {pricitani}:");

                        int vysledna = pocatecni;
                        for (int i = pocatecni+1; i <= konecna; i += pricitani)
                        {
                            Console.WriteLine($" >> {pocatecni} + {i-pocatecni} = {vysledna+1}");
                            vysledna += pricitani;
                        }

                        Console.WriteLine();
                        Console.Write("Odenteruj!");
                        Console.ReadLine();
                        break;
                    }
                    Console.Write("Přičítací hodnota je moc velká pro zadaná čísla!");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("Počáteční hodnota je větší než konečná!");
                    Console.ReadLine();
                }
            }
        }
        #endregion

        #region Odecitani
        static void OdecitejPoJedne()
        {
            //Celý loop, kvůli podmínce pocatecni<konecna
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"┌────────────────────────────────────────┐");
                Console.WriteLine($"│{"Odečítání po jedné",-40}│");
                Console.WriteLine($"└────────────────────────────────────────┘");

                int pocatecni;
                int konecna;

                //Loop pro počáteční hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro počáteční hodnotu <-100;100>: ");
                    try
                    {
                        pocatecni = Convert.ToInt32(Console.ReadLine());

                        if (pocatecni <= 100 && pocatecni >= -100)
                        {
                            break;
                        }

                        Console.Write("Počáteční hodnota musí být v z intervalu <-100;100>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                //Loop pro konečnou hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro konečnou hodnotu <-100;100>: ");

                    try
                    {
                        konecna = Convert.ToInt32(Console.ReadLine());

                        if (konecna <= 100 && konecna >= -100)
                        {
                            break;
                        }

                        Console.Write("Konečná hodnota musí být v z intervalu <-100;100>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Kontrola hodnot
                if (pocatecni > konecna)
                {
                    Console.WriteLine();

                    for (int i = pocatecni - 1; i >= konecna; i--)
                    //(pocatecni+1 pro vynechani prvniho nuloveho odecitani)
                    {
                        Console.WriteLine($" >> {pocatecni} - {pocatecni-i} = {i}");
                    }

                    Console.WriteLine();
                    Console.Write("Odenteruj!");
                    Console.ReadLine();
                    break;
                }

                Console.Write("Počáteční hodnota je menší než konečná!");
                Console.ReadLine();

            }
        }

        static void OdecitejPoZadanem()
        {
            //Celý loop, kvůli podmínce pocatecni<konecna
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"┌────────────────────────────────────────┐");
                Console.WriteLine($"│{"Odečítání po zadané hodnotě",-40}│");
                Console.WriteLine($"└────────────────────────────────────────┘");

                int pocatecni;
                int konecna;
                int pricitani;

                //Loop pro počáteční hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro počáteční hodnotu <-100;100>: ");
                    try
                    {
                        pocatecni = Convert.ToInt32(Console.ReadLine());

                        if (pocatecni <= 100 && pocatecni >= -100)
                        {
                            break;
                        }
                        Console.Write("Počáteční hodnota musí být v z intervalu <-100;100>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Loop pro konečnou hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro konečnou hodnotu <-100;100>: ");

                    try
                    {
                        konecna = Convert.ToInt32(Console.ReadLine());

                        if (konecna <= 100 && konecna >= -100)
                        {
                            break;
                        }
                        Console.Write("Konečná hodnota musí být v z intervalu <-100;100>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Loop pro honotu odečítání
                while (true)
                {
                    Console.Write("Zadej číslo pro hodnotu odečítání <2;50>: ");
                    try
                    {
                        pricitani = Convert.ToInt32(Console.ReadLine());

                        if (pricitani <= 50 && pricitani >= 2)
                        {
                            break;
                        }
                        Console.Write("Odečítací hodnota musí být v z intervalu <2;50>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Kontrola hodnot
                if (pocatecni > konecna)
                {
                    //Kontrola, jestli jde odečítat zadané číslo
                    if (pricitani <= (pocatecni - konecna))
                    {
                        Console.WriteLine($"\nVýpis od {pocatecni} do {konecna} po {pricitani}:");

                        int vysledna = pocatecni;
                        for (int i = pocatecni - 1; i >= konecna; i -= pricitani)
                        {
                            Console.WriteLine($" >> {pocatecni} - {pocatecni-i} = {vysledna - 1}");
                            vysledna -= pricitani;
                        }

                        Console.WriteLine();
                        Console.Write("Odenteruj!");
                        Console.ReadLine();
                        break;
                    }
                    Console.Write("Odečítací hodnota je moc velká pro zadaná čísla!");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("Počáteční hodnota je menší než konečná!");
                    Console.ReadLine();
                }
            }
        }
        #endregion

        #region Nasobeni
        static void NasobPoJedne()
        {
            //Celý loop, kvůli podmínce pocatecni<konecna
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"┌────────────────────────────────────────┐");
                Console.WriteLine($"│{"Násobení po jedné",-40}│");
                Console.WriteLine($"└────────────────────────────────────────┘");

                int pocatecni;
                int konecna;

                //Loop pro počáteční hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro počáteční hodnotu <2;50>: ");
                    try
                    {
                        pocatecni = Convert.ToInt32(Console.ReadLine());

                        if (pocatecni <= 50 && pocatecni >= 2)
                        {
                            break;
                        }

                        Console.Write("Počáteční hodnota musí být v z intervalu <2;50>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                //Loop pro konečnou hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro konečnou hodnotu <4;1000>: ");

                    try
                    {
                        konecna = Convert.ToInt32(Console.ReadLine());

                        if (konecna <= 1000 && konecna >= 4)
                        {
                            break;
                        }

                        Console.Write("Konečná hodnota musí být v z intervalu <4;1000>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Kontrola hodnot
                if (pocatecni < konecna)
                {
                    Console.WriteLine($"\nVýpis od {pocatecni} do {konecna} po jedné:\n");

                    int vysledek=0;
                    for (int i = pocatecni; vysledek < konecna; i++)
                    //(pocatecni+1 pro vynechani prvniho nuloveho pricitani)
                    {
                        vysledek = pocatecni * i;
                        Console.WriteLine($" >> {pocatecni} * {i} = {vysledek}");
                    }

                    Console.WriteLine();
                    Console.Write("Odenteruj!");
                    Console.ReadLine();
                    break;
                }

                Console.Write("Počáteční hodnota je větší než konečná!");
                Console.ReadLine();

            }
        }

        static void NasobPoZadanem()
        {
            //Celý loop, kvůli podmínce pocatecni<konecna
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"┌────────────────────────────────────────┐");
                Console.WriteLine($"│{"Přičítání po zadané hodnotě",-40}│");
                Console.WriteLine($"└────────────────────────────────────────┘");

                int pocatecni;
                int konecna;
                int krokovani;

                //Loop pro počáteční hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro počáteční hodnotu <2;50>: ");
                    try
                    {
                        pocatecni = Convert.ToInt32(Console.ReadLine());

                        if (pocatecni <= 50 && pocatecni >= 2)
                        {
                            break;
                        }
                        Console.Write("Počáteční hodnota musí být v z intervalu <2;50>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Loop pro konečnou hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro konečnou hodnotu <4;1000>: ");

                    try
                    {
                        konecna = Convert.ToInt32(Console.ReadLine());

                        if (konecna <= 1000 && konecna >= 4)
                        {
                            break;
                        }
                        Console.Write("Konečná hodnota musí být v z intervalu <4;1000>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Loop pro honotu přičítání
                while (true)
                {
                    Console.Write("Zadej číslo pro hodnotu kroku <2;50>: ");
                    try
                    {
                        krokovani = Convert.ToInt32(Console.ReadLine());

                        if (krokovani <= 50 && krokovani >= 2)
                        {
                            break;
                        }
                        Console.Write("Hodnota kroku musí být v z intervalu <2;50>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Kontrola hodnot
                if (pocatecni < konecna)
                {
                    Console.WriteLine($"\nVýpis od {pocatecni} do {konecna} po {krokovani}:\n");

                    for (int i = 2; i * pocatecni < konecna; i+=krokovani)
                    {
                        Console.WriteLine($" >> {pocatecni} * {i} = {i * pocatecni}");
                    }

                    Console.WriteLine();
                    Console.Write("Odenteruj!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Write("Počáteční hodnota je větší než konečná!");
                    Console.ReadLine();
                }
            }
        }
        #endregion

        #region Deleni
        static void DelPoJedne()
        {
            //Celý loop, kvůli podmínce pocatecni<konecna
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"┌────────────────────────────────────────┐");
                Console.WriteLine($"│{"Dělení po jedné",-40}│");
                Console.WriteLine($"└────────────────────────────────────────┘");

                double pocatecni;
                double konecna;

                //Loop pro počáteční hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro počáteční hodnotu <1;10>: ");
                    try
                    {
                        pocatecni = Convert.ToDouble(Console.ReadLine());

                        if (pocatecni <= 10 && pocatecni >= 1)
                        {
                            break;
                        }

                        Console.Write("Počáteční hodnota musí být v z intervalu <1;10>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                //Loop pro konečnou hodnotu
                while (true)
                {
                    Console.Write("Zadej desetinné číslo pro konečnou hodnotu <0,1;0,01>: ");

                    try
                    {
                        konecna = Convert.ToDouble(Console.ReadLine());

                        if (konecna.CompareTo(0.1) <= 0 && konecna.CompareTo(0.01) >= 0)
                        {
                            break;
                        }

                        Console.Write("Konečná hodnota musí být v z intervalu <0,1;0,01>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Kontrola hodnot
                if (pocatecni > konecna)
                {
                    Console.WriteLine($"\nVýpis od {pocatecni} do {konecna} po jedné:\n");

                    for (double i = 2; pocatecni / i >= konecna; i++)
                    {
                        Console.WriteLine($" >> {pocatecni} / {i} = {pocatecni / i:0.#######}");
                    }

                    Console.WriteLine();
                    Console.Write("Odenteruj!");
                    Console.ReadLine();
                    break;
                }

                Console.Write("Počáteční hodnota je menší než konečná!");
                Console.ReadLine();

            }
        }

        static void DelPoZadanem()
        {
            //Celý loop, kvůli podmínce pocatecni<konecna
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"┌────────────────────────────────────────┐");
                Console.WriteLine($"│{"Dělení po zadané hodnotě",-40}│");
                Console.WriteLine($"└────────────────────────────────────────┘");

                double pocatecni;
                double konecna;
                double krokovani;

                //Loop pro počáteční hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro počáteční hodnotu <1;10>: ");
                    try
                    {
                        pocatecni = Convert.ToDouble(Console.ReadLine());

                        if (pocatecni <= 10 && pocatecni >= 1)
                        {
                            break;
                        }
                        Console.Write("Počáteční hodnota musí být v z intervalu <1;10>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Loop pro konečnou hodnotu
                while (true)
                {
                    Console.Write("Zadej číslo pro konečnou hodnotu <0,1;0,01>: ");

                    try
                    {
                        konecna = Convert.ToDouble(Console.ReadLine());

                        if (konecna.CompareTo(0.1) <= 0 && konecna.CompareTo(0.01) >= 0)
                        {
                            break;
                        }
                        Console.Write("Konečná hodnota musí být v z intervalu <0,1;0,01>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Loop pro honotu přičítání
                while (true)
                {
                    Console.Write("Zadej číslo pro hodnotu kroku <2;5>: ");
                    try
                    {
                        krokovani = Convert.ToDouble(Console.ReadLine());

                        if (krokovani <= 5 && krokovani >= 2)
                        {
                            break;
                        }
                        Console.Write("Hodnota kroku musí být v z intervalu <2;5>");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                //Kontrola hodnot
                if (pocatecni > konecna)
                {
                    Console.WriteLine($"\nVýpis od {pocatecni} do {konecna} po {krokovani}:\n");

                    for (double i = 2; pocatecni / i >= konecna; i+=krokovani)
                    {
                        Console.WriteLine($" >> {pocatecni} / {i} = {pocatecni / i:0.#######}");
                    }

                    Console.WriteLine();
                    Console.Write("Odenteruj!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Write("Počáteční hodnota je menší než konečná!");
                    Console.ReadLine();
                }
            }
        }
        #endregion
    }
}