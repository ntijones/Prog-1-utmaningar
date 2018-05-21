using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tal___Pyramider
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resultat; //Gör så att resutlat bara kan vara true/false

            do //Skapar en do-while loop
            {
                resultat = Pyramid();
            }
            while (resultat == false);
        }
        static bool Pyramid()  
        {
            Console.Write("Skriv in ett tal: ");
            string input = Console.ReadLine(); 
            int tal1 = 0; // Ger "tal1" värdet 0

            bool r = int.TryParse(input, out tal1); //Om konverteringen lyckades så blir "r = true". Om den lyckades Parse'a så skickar den ut värdet till tal1      
            if (!r) // Om den inte lyckades konvertera kör den nedanstående kod
            {
                Console.WriteLine();
                Console.WriteLine("Felaktigt input");
            }

            for (int i = 0; i < tal1 + 1; i++) //Adderas vid varje loop
            {
               for (int a = 0; a < i; a++) 
                {
                    Console.Write(tal1); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("När du är färdig: ");
            Console.WriteLine("skriv exit för att stänga av programmet");
            Console.ReadLine(); //Gör så att programmet inte kraschar
            return true;
        }
    }
}
