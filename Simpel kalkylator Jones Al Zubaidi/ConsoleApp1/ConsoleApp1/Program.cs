using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        
        
        static void Main(string[] args)
        {
            while (true) //Skapar en while-loop. 
            {
                Menu();
                int val = GetInput();
                Räkna(val);
                Console.WriteLine();
            }
        }

        static void Menu() // Skriver ut text och alternativen som finns att välja på 
        {
            Console.WriteLine("Simpel kalkylator");
            Console.WriteLine("Välj vilket räknesätt du vill använda");
            Console.WriteLine("Räknesätt:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtration");
            Console.WriteLine("3. Multiplikation");
            Console.Write("Ditt val: "); //Användaren får skriva in ett alternativ (Addition, subration och multiplikation)
        }

        static int GetInput() 
        {
            // Översätter sträng till en int och returnerar värdet
            return int.Parse(Console.ReadLine());
        }

        private static void Räkna(int val)
        {
            switch(val) 
            { //Koden känner efter vilket tal användaren har angett. 
                case 1:
                    Console.WriteLine(Addition()); //
                    break;

                case 2:
                    Console.WriteLine(Subration()); // 
                    break;

                case 3:
                    Console.WriteLine(Multiplikation()); // 
                    break;

                default:
                    Console.WriteLine("Felaktigt input"); //
                    break;
            }
                
        }

        static int Addition() //Skapar sektion för addition
        {
            Console.Write("Tal 1: ");
            int tal1 = GetInput();
            Console.Write("Tal 2: ");
            int tal2 = GetInput();
            Console.Write("Summan blir: ");
            return tal1 + tal2;
        }

        static int Subration() //Skapar sektion för subration
        {
            Console.Write("Tal 1: ");
            int tal1 = GetInput();
            Console.Write("Tal 2: ");
            int tal2 = GetInput();
            Console.Write("Summan blir: ");
            return tal1 - tal2;
        }

        static int Multiplikation() //Skapar sektion för multiplikation 
        {
            Console.Write("Tal 1: ");
            int tal1 = GetInput();
            Console.Write("Tal 2: ");
            int tal2 = GetInput();
            Console.Write("Summan blir: ");
            return tal1 * tal2;
            
        }



    }
}
