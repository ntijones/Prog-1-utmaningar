using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            meny();
            Console.ReadLine();
        }
        static void meny() //Skriver ut de alternativ som finns att välja på 
        {
            Console.WriteLine("Meningskonveryerare");
            Console.WriteLine("Välj 1 för att konvertera till stora bokstäver");
            Console.WriteLine("Välj 2 för att konvertera till små bokstäver");
            Console.Write("Ditt val:");
            string userInput = Console.ReadLine(); //Gör så att programmet inte kraschar

            switch (userInput) //Skapar en meny för de alternativ som finns, uppercase och lowercase.
            {
                case "1": //Caps
                    upperCase(); 
                    break;
                case "2": //Små bokstäver
                    lowerCase();
                    break;
                default:
                    Console.WriteLine("Felaktigt input, försök igen!"); meny(); //Om användaren skriver in fel, körs denna kod
                    break;
            }
        }
        static void upperCase() 
        {
            Console.Write("Skriv din mening: ");
            //Gör små bokstäver till caps
            string input = Console.ReadLine().ToUpper();
            Console.WriteLine("Din mening:" + input);
        }

        static void lowerCase()
        {
            Console.Write("Skriv din mening: ");
            //Gör om caps till små bokstäver
            string input = Console.ReadLine().ToLower();
            Console.WriteLine("Din mening:" + input);
        }
    }
}
