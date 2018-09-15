using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171124_Černý1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Odchytávání chyb";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Odchytávání chyb:");
                Console.Write("Číslo <0;255> a: ");
                string stringA = Console.ReadLine();
                Console.Write("Číslo <0;255> b: ");
                string stringB = Console.ReadLine();
                try
                {
                    byte byteA = Convert.ToByte(stringA);
                    byte byteB = Convert.ToByte(stringB);

                    decimal decA = Convert.ToDecimal(byteA);
                    decimal decB = Convert.ToDecimal(byteB);

                    Console.WriteLine("Dělení");
                    Console.WriteLine($"{decA} / {decB} = {decA / decB}");
                }
                catch (OverflowException oEx)
                {
                    vypsaniChyb(oEx, $"Chyba OverflowException! \n{stringA} nebo {stringB} je mimo interval <0;255> !");

                }
                catch (FormatException fEx)
                {
                    vypsaniChyb(fEx, $"Chyba FormatException! \n{stringA} nebo {stringB} nemá formát čísla !");
                }
                catch (DivideByZeroException dEx)
                {
                    vypsaniChyb(dEx, $"Chyba DivideByZeroException! \nNulou nelze dělit !");
                }

                Console.Write("Odenteruj!");
                Console.ReadLine();

                void vypsaniChyb(Exception e, string hlavniZprava)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n=========================================================-");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(hlavniZprava);

                    vypsaniDetailuChyby($"  {e.Data}", "e.Data > kolekce, které poskytuje další informace o výjimce, uživatelem definované");
                    vypsaniDetailuChyby($"  {e.HelpLink}", "e.HelpLink > odkaz na soubor nápovědy přidružené k této výjimce");
                    vypsaniDetailuChyby($"  {e.HResult}", "e.HResult > číselná hodnota, která je přiřazena k určité výjimce");
                    vypsaniDetailuChyby($"  {e.InnerException}", "e.InnerException > instance, která způsobila aktuální výjimku");
                    vypsaniDetailuChyby($"  {e.Message}", "e.Message > zpráva, která popisuje aktuální výjimku");
                    vypsaniDetailuChyby($"  {e.Source}", "e.Source > název aplikace nebo objektu, který způsobuje chybu");
                    vypsaniDetailuChyby($"  {e.StackTrace}", "e.StackTrace > řetězcová reprezentace chyby");
                    vypsaniDetailuChyby($"  {e.TargetSite}", "e.TargetSite > metoda, která vyvolala aktuální výjimku");
                    vypsaniDetailuChyby($"  {e}", "e > ");

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("=========================================================");
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                void vypsaniDetailuChyby(string chyba, string zpravaChyby)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("=========================================================");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(zpravaChyby);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(chyba);
                }
            }
        }
    }
}
