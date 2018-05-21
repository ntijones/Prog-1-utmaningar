using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplikationstabbellen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriver ut till programmet.
            Console.WriteLine("Multiplikationstabeller");
            Console.Write("Skriv in ett heltal:");
            //Ger userInput ett värde sedan gör int.Parse så att programmet inte stänger ner sig. 
            int userInput = int.Parse(Console.ReadLine());
            //Ger räknaren variblen i och ett värde.
            for (int i = 1; i < 11; i++)
            {
                //Multiplicerar int produkt, (användarens värde) och räknaren
                int produkt = userInput * i;
                Console.WriteLine(produkt);
            }
            Console.ReadLine();
        }
    }
}