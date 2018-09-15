using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171208_Černý1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Základní nastavení
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            while (true)
            {
                Console.Clear();

                #region Výpis s formátováním čísel - formátování

                #region Jeden znak
                //Deklarace a inicializace
                int minInt = int.MinValue;
                int maxInt = int.MaxValue;
                Single minSingle = Single.MinValue;
                Single maxSingle = Single.MaxValue;
                Single xSingle = 0.0005F;

                //Nastavení barvy
                Console.ForegroundColor = ConsoleColor.Blue;

                //Výpis inicializace
                Console.WriteLine("Deklarováno a inicializováno");
                Console.WriteLine("────────────────────────────");
                Console.WriteLine("int minInt = int.MinValue;");
                Console.WriteLine("int maxInt = int.MaxValue;");
                Console.WriteLine("Single minSingle = Single.MinValue;");
                Console.WriteLine("Single maxSingle = Single.MaxValue;");
                Console.WriteLine("Single xSingle = 0.0005F;");

                //Výpis nadpisu
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Výpis s formátováním čísel - formátování (jeden znak!) ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ReadLine();

                //Nastavení barvy 2
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                //Výpis tabulky - c,C
                Console.WriteLine("- c,C <> Měna");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:c}",-65}│{"{Proměnná:c5}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"minInt",-15}│{minInt,-40}│{minInt,-65:c}│{minInt,-65:c5}│");
                Console.WriteLine($"│{"maxInt",-15}│{maxInt,-40}│{maxInt,-65:c}│{maxInt,-65:c5}│");
                Console.WriteLine($"│{"minSingle",-15}│{minSingle,-40}│{minSingle,-65:c}│{minSingle,-65:c5}│");
                Console.WriteLine($"│{"maxSingle",-15}│{maxSingle,-40}│{maxSingle,-65:c}│{maxSingle,-65:c5}│");
                Console.WriteLine($"│{"xSingle",-15}│{xSingle,-40}│{xSingle,-65:c}│{xSingle,-65:c5}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - d,D
                Console.WriteLine("- d,D <> Decimal");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:d}",-65}│{"{Proměnná:d5}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"minInt",-15}│{minInt,-40}│{minInt,-65:d}│{minInt,-65:d5}│");
                Console.WriteLine($"│{"maxInt",-15}│{maxInt,-40}│{maxInt,-65:d}│{maxInt,-65:d5}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - e,E
                Console.WriteLine("- e,E <> Exponenciální (vědecké)");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:e}",-65}│{"{Proměnná:e5}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"minInt",-15}│{minInt,-40}│{minInt,-65:e}│{minInt,-65:e5}│");
                Console.WriteLine($"│{"maxInt",-15}│{maxInt,-40}│{maxInt,-65:e}│{maxInt,-65:e5}│");
                Console.WriteLine($"│{"minSingle",-15}│{minSingle,-40}│{minSingle,-65:e}│{minSingle,-65:e5}│");
                Console.WriteLine($"│{"maxSingle",-15}│{maxSingle,-40}│{maxSingle,-65:e}│{maxSingle,-65:e5}│");
                Console.WriteLine($"│{"xSingle",-15}│{xSingle,-40}│{xSingle,-65:e}│{xSingle,-65:e5}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - f,F
                Console.WriteLine("- f,F <> S pevnou desetinnou čárkou");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:f}",-65}│{"{Proměnná:f5}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"minInt",-15}│{minInt,-40}│{minInt,-65:f}│{minInt,-65:f5}│");
                Console.WriteLine($"│{"maxInt",-15}│{maxInt,-40}│{maxInt,-65:f}│{maxInt,-65:f5}│");
                Console.WriteLine($"│{"minSingle",-15}│{minSingle,-40}│{minSingle,-65:f}│{minSingle,-65:f5}│");
                Console.WriteLine($"│{"maxSingle",-15}│{maxSingle,-40}│{maxSingle,-65:f}│{maxSingle,-65:f5}│");
                Console.WriteLine($"│{"xSingle",-15}│{xSingle,-40}│{xSingle,-65:f}│{xSingle,-65:f5}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - g,G
                Console.WriteLine("- g,G <> Obecné");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:g}",-65}│{"{Proměnná:g5}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"minInt",-15}│{minInt,-40}│{minInt,-65:g}│{minInt,-65:g5}│");
                Console.WriteLine($"│{"maxInt",-15}│{maxInt,-40}│{maxInt,-65:g}│{maxInt,-65:g5}│");
                Console.WriteLine($"│{"minSingle",-15}│{minSingle,-40}│{minSingle,-65:g}│{minSingle,-65:g5}│");
                Console.WriteLine($"│{"maxSingle",-15}│{maxSingle,-40}│{maxSingle,-65:g}│{maxSingle,-65:g5}│");
                Console.WriteLine($"│{"xSingle",-15}│{xSingle,-40}│{xSingle,-65:g}│{xSingle,-65:g5}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - n,N
                Console.WriteLine("- n,N <> Číslo");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:n}",-65}│{"{Proměnná:n5}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"minInt",-15}│{minInt,-40}│{minInt,-65:n}│{minInt,-65:n5}│");
                Console.WriteLine($"│{"maxInt",-15}│{maxInt,-40}│{maxInt,-65:n}│{maxInt,-65:n5}│");
                Console.WriteLine($"│{"minSingle",-15}│{minSingle,-40}│{minSingle,-65:n}│{minSingle,-65:n5}│");
                Console.WriteLine($"│{"maxSingle",-15}│{maxSingle,-40}│{maxSingle,-65:n}│{maxSingle,-65:n5}│");
                Console.WriteLine($"│{"xSingle",-15}│{xSingle,-40}│{xSingle,-65:n}│{xSingle,-65:n5}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - p,P
                Console.WriteLine("- p,P <> V procentech");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:p}",-65}│{"{Proměnná:p5}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"minInt",-15}│{minInt,-40}│{minInt,-65:p}│{minInt,-65:p5}│");
                Console.WriteLine($"│{"maxInt",-15}│{maxInt,-40}│{maxInt,-65:p}│{maxInt,-65:p5}│");
                Console.WriteLine($"│{"minSingle",-15}│{minSingle,-40}│{minSingle,-65:p}│{minSingle,-65:p5}│");
                Console.WriteLine($"│{"maxSingle",-15}│{maxSingle,-40}│{maxSingle,-65:p}│{maxSingle,-65:p5}│");
                Console.WriteLine($"│{"xSingle",-15}│{xSingle,-40}│{xSingle,-65:p}│{xSingle,-65:p5}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - x,X
                Console.WriteLine("- x,X <> Šestnáctkově");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:x}",-65}│{"{Proměnná:x5}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"minInt",-15}│{minInt,-40}│{minInt,-65:x}│{minInt,-65:x5}│");
                Console.WriteLine($"│{"maxInt",-15}│{maxInt,-40}│{maxInt,-65:x}│{maxInt,-65:x5}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();
                #endregion

                #region Více znaků
                //Nastavení barvy
                Console.ForegroundColor = ConsoleColor.Blue;

                //Výpis nadpisu
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Výpis s formátováním čísel - formátování (více znaků!) ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ReadLine();

                //Nastavení barvy 2
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                //Výpis tabulky - #.##
                Console.WriteLine("- #.## <> Vlastní měna");
                //{{512.345}} >> {{512.345:# zlatých.## stříbrných}} =>>= {512.345} >> {512.345:# zlatých.## stříbrných}
                Console.WriteLine("┌───────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"Proměnná:# zlatých. ## stříbrných",-65}│");
                Console.WriteLine("├───────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"512.345",-15}│{512.345,-65:# zlatých. ## stříbrných}│");
                Console.WriteLine("└───────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.ReadLine();
                #endregion

                #endregion

                #region Výpis s formátováním datumu - formátování

                #region Jeden znak

                //Deklarace a inicializace
                DateTime datumNow = DateTime.Now;
                DateTime datumToday = DateTime.Today;
                DateTime datumVlastní = new DateTime(1968, 3, 1, 1, 30, 45);

                //Nastavení barvy
                Console.ForegroundColor = ConsoleColor.Red;

                //Výpis inicializace
                Console.WriteLine("Deklarováno a inicializováno");
                Console.WriteLine("────────────────────────────");
                Console.WriteLine("DateTime datumNow = DateTime.Now;");
                Console.WriteLine("DateTime datumToday = DateTime.Today;");
                Console.WriteLine("DateTime datumVlastní = new DateTime(1968, 3, 1, 1, 30, 45);");

                //Výpis nadpisu
                Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Výpis s formátováním datumu - formátování (jeden znak!) ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
                Console.ReadLine();

                //Nastavení barvy 2
                Console.ForegroundColor = ConsoleColor.DarkRed;

                //Výpis tabulky - d
                Console.WriteLine("- d <> Vzor krátkého formátu data.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:d}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:d}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:d}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:d}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - D
                Console.WriteLine("- D <> Vzor dlouhého formátu data.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:D}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:D}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:D}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:D}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - f
                Console.WriteLine("- f <> Vzor úplné datum a čas (krátký čas).");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:f}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:f}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:f}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:f}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - F
                Console.WriteLine("- F <> Vzor úplné datum a čas (dlouhý čas).");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:F}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:F}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:F}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:F}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - g
                Console.WriteLine("- g <> Vzor Obecné datum a čas (krátký čas).");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:g}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:g}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:g}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:g}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - G
                Console.WriteLine("- G <> Vzor Obecné datum a čas (dlouhý čas).");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:G}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:G}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:G}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:G}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - M, m
                Console.WriteLine("- M, m <> Vzor měsíc a den.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:m}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:m}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:m}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:m}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - R, r
                Console.WriteLine("- R, r <> Vzor RFC1123");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:r}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:r}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:r}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:r}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - s
                Console.WriteLine("- s <> Vzor seřaditelné datum a čas.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:s}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:s}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:s}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:s}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - t
                Console.WriteLine("- t <> Vzor krátkého formátu času.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:t}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:t}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:t}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:t}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - T
                Console.WriteLine("- T <> Vzor dlouhého formátu času.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:T}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:T}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:T}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:T}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - u
                Console.WriteLine("- u <> Vzor Univerzální seřaditelné datum a čas.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:u}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:u}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:u}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:u}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - U
                Console.WriteLine("- U <> Vzor univerzální úplné datum a čas.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:U}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:U}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:U}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:U}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - Y, y
                Console.WriteLine("- Y, y <> Vzorek roku a měsíce.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:y}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:y}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:y}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:y}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();
                #endregion

                #region Vlastní formátování
                //Nastavení barvy
                Console.ForegroundColor = ConsoleColor.Red;

                //Výpis nadpisu
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Výpis s formátováním datumu - vlastní formátování (více znaků!) ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
                Console.ReadLine();

                //Nastavení barvy 2
                Console.ForegroundColor = ConsoleColor.DarkRed;

                //Výpis tabulky - d
                Console.WriteLine("- d <> Den v měsíci, od 1 do 31.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%d}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:%d}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:%d}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:%d}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - dd
                Console.WriteLine("- dd <> Den v měsíci, od 01 do 31.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:dd}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:dd}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:dd}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:dd}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - ddd
                Console.WriteLine("- ddd <> Zkrácený název dne v týdnu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:ddd}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:ddd}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:ddd}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:ddd}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - dddd
                Console.WriteLine("- dddd <> Úplný název dne v týdnu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:dddd}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:dddd}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:dddd}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:dddd}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - f
                Console.WriteLine("- f <> Desetiny sekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:f}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:f}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:f}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:f}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - ff
                Console.WriteLine("- ff <> Setiny sekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:ff}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:ff}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:ff}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:ff}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - fff
                Console.WriteLine("- fff <> Milisekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:fff}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:fff}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:fff}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:fff}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - ffff
                Console.WriteLine("- ffff <> Desetitisíciny sekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:ffff}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:ffff}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:ffff}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:ffff}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - fffff
                Console.WriteLine("- fffff <> Stotisíciny sekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:fffff}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:fffff}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:fffff}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:fffff}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - F
                Console.WriteLine("- F <> Pokud nenulová, desetiny sekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:F}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:F}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:F}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:F}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FF
                Console.WriteLine("- FF <> Pokud nenulová, setiny sekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:FF}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:FF}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:FF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FFF
                Console.WriteLine("- FFF <> Pokud nenulová, milisekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FFF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:FFF}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:FFF}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:FFF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FFFF
                Console.WriteLine("- FFFF <> Pokud nenulová, desetitisíciny sekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FFFF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:FFFF}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:FFFF}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:FFFF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FFFFF
                Console.WriteLine("- FFFFF <> Pokud nenulová, stotisíciny sekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FFFFF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:FFFFF}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:FFFFF}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:FFFFF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FFFFFF
                Console.WriteLine("- FFFFFF <> Pokud není nulová, miliontiny sekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FFFFFF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:FFFFFF}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:FFFFFF}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:FFFFFF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FFFFFFF
                Console.WriteLine("- FFFFFFF <> Pokud není nulová, desetimiliontiny sekundy v hodnotě data a času");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FFFFFFF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:FFFFFFF}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:FFFFFFF}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:FFFFFFF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - g, gg
                Console.WriteLine("- g, gg <> Období nebo éra");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%g}",-65}│{"{Proměnná:gg}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:%g}│{datumNow,-65:gg}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:%g}│{datumToday,-65:gg}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:%g}│{datumVlastní,-65:gg}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - h
                Console.WriteLine("- h <> Hodiny ve 12hodinovém formátu od 1 do 12.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%h}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:%h}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:%h}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:%h}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - hh
                Console.WriteLine("- hh <> Hodiny ve 12hodinovém formátu od 01 do 12.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:hh}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:hh}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:hh}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:hh}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - H
                Console.WriteLine("- H <> Hodiny ve 24Hodinovém formátu od 1 do 24.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%H}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:%H}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:%H}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:%H}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - HH
                Console.WriteLine("- HH <> Hodiny ve 12Hodinovém formátu od 01 do 24.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:HH}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:HH}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:HH}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:HH}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - K
                Console.WriteLine("- K <> Informace o časovém pásmu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%K}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:%K}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:%K}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:%K}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - m
                Console.WriteLine("- m <> Minuty, od 0 do 59.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%m}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:%m}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:%m}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:%m}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - mm
                Console.WriteLine("- mm <> Minuty, od 00 do 59.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:mm}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:mm}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:mm}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:mm}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - M
                Console.WriteLine("- M <> Měsíc, od 1 do 12.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%M}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:%M}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:%M}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:%M}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - MM
                Console.WriteLine("- MM <> Měsíc, od 01 do 12.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:MM}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:MM}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:MM}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:MM}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - MMM
                Console.WriteLine("- MMM <> Zkrácený název měsíce.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:MMM}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:MMM}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:MMM}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:MMM}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - MMMM
                Console.WriteLine("- MMMM <> Úplný název měsíce.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:MMMM}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:MMMM}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:MMMM}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:MMMM}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - s
                Console.WriteLine("- s <> Sekundy, od 0 do 59.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%s}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:%s}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:%s}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:%s}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - ss
                Console.WriteLine("- ss <> Sekundy, od 00 do 59.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:ss}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:ss}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:ss}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:ss}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - t
                Console.WriteLine("- t <> První znak označení dopoledne / odpoledne.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%t}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:%t}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:%t}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:%t}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - tt
                Console.WriteLine("- tt <> Označení dopoledne / odpoledne.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:tt}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:tt}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:tt}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:tt}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - y
                Console.WriteLine("- y <> Rok, od 0 do 99.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:y}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:y}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:y}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:y}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - yy
                Console.WriteLine("- yy <> Rok, od 00 do 99.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:yy}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:yy}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:yy}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:yy}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - yyy
                Console.WriteLine("- yyy <> Rok s nejméně třemi číslicemi.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:yyy}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:yyy}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:yyy}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:yyy}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - yyyy
                Console.WriteLine("- yyyy <> Rok jako čyřmístné číslo.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:yyyy}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:yyyy}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:yyyy}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:yyyy}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - yyyyy
                Console.WriteLine("- yyyyy <> Rok jako pětimístné číslo.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:yyyyy}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:yyyyy}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:yyyyy}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:yyyyy}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - z
                Console.WriteLine("- z <> Posun hodin od času UTC, bez počátečních nul.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%z}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:%z}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:%z}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:%z}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - zz
                Console.WriteLine("- zz <> Posun hodin od času UTC, s počáteční nulou pro jednocifernou hodnotu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:zz}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:zz}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:zz}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:zz}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - zzz
                Console.WriteLine("- zzz <> Posun hodin a minut od času UTC.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:zzz}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:zzz}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:zzz}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:zzz}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - :
                Console.WriteLine("- : <> Oddělovač času.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:h:m:s}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:h:m:s}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:h:m:s}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:h:m:s}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - /
                Console.WriteLine("- / <> Oddělovač času.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:/d/M/yy}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:d/M/yy}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:d/M/yy}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:d/M/yy}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - 'Řetězec'
                Console.WriteLine("- 'Řetězec' <> Oddělovač řetězcového literálu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:'moje datum:' dddd d. MMMM yyyy}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:'moje datum:' dddd d. MMMM yyyy}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:'moje datum:' dddd d. MMMM yyyy}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:'moje datum:' dddd d. MMMM yyyy}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - %
                Console.WriteLine("- % <> Definuje následující znak jako specifikátor vlastního formátu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%d}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:%d}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:%d}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:%d}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - \
                Console.WriteLine("- \\ <> Řídící znak.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:A\\hoj babi}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:A\\hoj babi}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:A\\hoj babi}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:A\\hoj babi}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - jiné
                Console.WriteLine("- Jakýkoli jiný znak<> Znak je zkopírován do výsledného řetězce beze změny.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:Ahoj babi}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"datumNow",-15}│{datumNow,-40}│{datumNow,-65:Ahoj babi}│");
                Console.WriteLine($"│{"datumToday",-15}│{datumToday,-40}│{datumToday,-65:Ahoj babi}│");
                Console.WriteLine($"│{"datumVlastní",-15}│{datumVlastní,-40}│{datumVlastní,-65:Ahoj babi}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                #endregion

                #endregion

                #region Výpis s formátováním času - formátování

                #region Jeden znak
                //Deklarace a inicializace
                TimeSpan časVlastní = new TimeSpan(1, 30, 55, 5, 10);

                //Nastavení barvy
                Console.ForegroundColor = ConsoleColor.Green;

                //Výpis inicializace
                Console.WriteLine("Deklarováno a inicializováno");
                Console.WriteLine("────────────────────────────");
                Console.WriteLine("TimeSpan časVlastní = new TimeSpan(1, 30, 55, 5, 10);;");

                //Výpis nadpisu
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Výpis s formátováním času - formátování (jeden znak!) ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ReadLine();

                //Nastavení barvy 2
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                //Výpis tabulky - c
                Console.WriteLine("- c <> Konstantní (neutrální) formát");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:c}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:c}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - g
                Console.WriteLine("- g <> Obecný krátký formát");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:g}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:g}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - G
                Console.WriteLine("- G <> Obecný dlouhý formát");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:G}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:G}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                #endregion

                #region Více znaků
                //Nastavení barvy
                Console.ForegroundColor = ConsoleColor.Green;

                //Výpis nadpisu
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Výpis s formátováním času - vlastní formátování (více znaků!) ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════╝");
                Console.ReadLine();

                //Nastavení barvy 2
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                //Výpis tabulky - d
                Console.WriteLine("- d, %d <> Počet celých dní v časovém intervalu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%d}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:%d}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - dd-dddddddd
                Console.WriteLine("- dd-dddddddd <> Počet celých dní v časovém intervalu, vyplní úvodními nulami podle potřeby.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:u}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:dd}│");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:ddd}│");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:dddd}│");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:ddddd}│");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:dddddd}│");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:ddddddd}│");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:dddddddd}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - h
                Console.WriteLine("- h, %h <> Počet celých hodin v časovém intervalu, který se počítají jako součást dnů. Hodiny nemají úvodní nulu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%h}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:%h}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - hh
                Console.WriteLine("- hh <> Počet celých hodin v časovém intervalu, který se počítají jako součást dnů. Jednociferné hodiny mají počáteční nulu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:hh}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:hh}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - m
                Console.WriteLine("- m, %m <> Počet celých minut v časovém intervalu, které nejsou součástí hodin nebo dnů. Řádu minut nemají úvodní nuly.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%m}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:%m}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - mm
                Console.WriteLine("- mm <> Počet celých minut v časovém intervalu, které nejsou součástí hodin nebo dnů. Jednociferné minut mají počáteční nuly.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:mm}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:mm}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - s
                Console.WriteLine("- s, %s <> Počet celých sekund v časovém intervalu, které nejsou součástí hodiny, dnů nebo minut. Řády sekund nemají úvodní nuly.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%s}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:%s}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - ss
                Console.WriteLine("- ss <> Počet celých sekund v časovém intervalu, které nejsou součástí hodiny, dnů nebo minut. Jednociferné sekund mají počáteční nuly.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:ss}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:ss}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - f
                Console.WriteLine("- f, %f <> Desetiny sekundy v určitém časovém intervalu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%f}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:%f}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - ff
                Console.WriteLine("- ff <> Setiny sekundy v určitém časovém intervalu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:ff}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:ff}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - fff
                Console.WriteLine("- fff <> Počet milisekund v určitém časovém intervalu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:fff}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:fff}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - ffff
                Console.WriteLine("- ffff <> Desetitisíciny sekundy v časovém intervalu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:ffff}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:ffff}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - fffff
                Console.WriteLine("- fffff <> Stotisíciny sekundy v časovém intervalu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:fffff}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:fffff}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - ffffff
                Console.WriteLine("- ffffff <> Miliontiny sekundy v určitém časovém intervalu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:ffffff}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:ffffff}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - fffffff
                Console.WriteLine("- fffffff <> Desetimiliontiny sekundy v určitém časovém intervalu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:fffffff}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:fffffff}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - F
                Console.WriteLine("- F, %F <> Desetiny sekundy v určitém časovém intervalu. Nezobrazí se žádná hodnota, pokud je číslice nula.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:%F}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:%F}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FF
                Console.WriteLine("- FF <> Setiny sekundy v určitém časovém intervalu. Jakékoli koncové nuly nebo dvě zlomkové nuly nejsou zahrnuty.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:FF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FFF
                Console.WriteLine("- FFF <> Počet milisekund v určitém časovém intervalu. Jakékoli zlomkové koncové nuly nejsou zahrnuty.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FFF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:FFF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FFFF
                Console.WriteLine("- FFFF <> Desetitisíciny sekundy v časovém intervalu. Jakékoli zlomkové koncové nuly nejsou zahrnuty.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FFFF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:FFFF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FFFFF
                Console.WriteLine("- FFFFF <> Stotisíciny sekundy v časovém intervalu. Jakékoli zlomkové koncové nuly nejsou zahrnuty.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FFFFF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:FFFFF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FFFFFF
                Console.WriteLine("- FFFFFF <> Miliontiny sekundy v určitém časovém intervalu. Jakékoli zlomkové koncové nuly nejsou zahrnuty.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FFFFFF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:FFFFFF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - FFFFFFF
                Console.WriteLine("- FFFFFFF <> Desetimiliontiny sekundy v určitém časovém intervalu. Jakékoli zlomkové koncové nuly nejsou zahrnuty.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:FFFFFFF}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:FFFFFFF}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - 'řetězec'
                Console.WriteLine("- 'řetězec' <> Oddělovač řetězcového literálu.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:'To jsou dny' d}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:'To jsou dny 'd}│");
                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                //Výpis tabulky - \
                Console.WriteLine("- \\ <> Řídící znak.");
                Console.WriteLine("┌───────────────┬────────────────────────────────────────┬─────────────────────────────────────────────────────────────────┐");
                Console.WriteLine($"│{"Proměnná",-15}│{"{Proměnná}",-40}│{"{Proměnná:\\T\\o\\ \\j\\s\\o\\u\\ \\d\\n\\y\\ d}",-65}│");
                Console.WriteLine("├───────────────┼────────────────────────────────────────┼─────────────────────────────────────────────────────────────────┤");
                Console.WriteLine($"│{"časVlastní",-15}│{časVlastní,-40}│{časVlastní,-65:\\T\\o\\ \\j\\s\\o\\u\\ \\d\\n\\y\\ d}│");

                Console.WriteLine("└───────────────┴────────────────────────────────────────┴─────────────────────────────────────────────────────────────────┘");
                Console.ReadLine();

                #endregion

                #endregion

            }
        }
    }
}