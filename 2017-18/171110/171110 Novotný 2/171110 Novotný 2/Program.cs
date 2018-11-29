using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171110_Novotný_2
{
    class Program
    {
        static void Main(string[] args)
        {

                                //AHOJ"           
                                      
            // první úkol = zadej počáteční hodnotu a hodontu pro operaci
            // barva textu = bílá, písmo = černá, velikost kurzoru = 100
            //prní vytvořím text


            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //kurzor se dělá =
            Console.CursorSize = 100; 
            // základ


            Console.Write("Zadej počáteční číslo : ");
            // int = stejné jako string, ale číslo           int = číslo          string = text
            string pocatek = Console.ReadLine();     //string = vstup, který musím převést na INT, kretý je počáteční číslo
            int pocatecnicislo = Convert.ToInt32(pocatek);   //převod z string na int
            Console.WriteLine("Počáteční hodnota : " + pocatecnicislo);
            Console.Write("--------------------------------------------");
            Console.Write("\nZadej hodnotu pro operaci : ");
            string druhe = Console.ReadLine();
            int operacnicislo = Convert.ToInt32(druhe);
            Console.WriteLine("operační hodnota : " + operacnicislo);
            Console.Write("--------------------------------------------");
            //1. část za sebou 
            // první si vytvořím čtyři proměné
            int a = pocatecnicislo;
            int b = pocatecnicislo;
            int c = pocatecnicislo;
            decimal d = pocatecnicislo; // decimal použiju, protože číslo není celé 

            // teleport - dělám až po řádku 64, udělám jako "jméno+:
            teleport1:
            Console.WriteLine("\n přičítání po 1 = " + a);
            Console.WriteLine($"odčítání po {operacnicislo}= {b}");  // před uvozovky můžu dát $ = (alt + klávesa na levo od L)
            Console.WriteLine($"násobení po {operacnicislo}= {c}");
            Console.WriteLine($"děleno {operacnicislo}= {d}");
            Console.WriteLine("ODENTRUJ!!");   // dva vykřičníky a caps lock jsou více cool!        
            Console.ReadKey();  //readkey čeká na jedno písmeno                    //readline - můžeš toho napsat kolik chceš a musíš odentrovat
            Console.Write("--------------------------------");
            // console.writeline mám, teď musím udělat operace

            // přičítání
            a = a + 1;                //a++ = a+1 , kdybych sčítal a a operacnicislo = a+=operacnicislo;   
            // odčítání 
            b = b - operacnicislo;   //b-=operacnicislo;
            // násobení 
            c = c * operacnicislo;   //c*=operacnicislo;
            // dělení
            d = d / operacnicislo;   // d/=operacnicislo;

            //musím vypsat, takže použiju ,,teleporty" 
            // nejdříve si udělám výstup teleportu před řádkem 45 - pak to už domyslím :D 


       

            //teleport konec = udělám funkcí goto
            goto teleport1;

              // k tomuhle se přes teleport stejně nedostanu, tak to tu nechám XD
            Console.ReadLine();
 


            // ctrl S


        }
    }
}
