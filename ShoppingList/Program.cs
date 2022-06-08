using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ShoppingList
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Miikka\source\repos\ShoppingList\files\shoppingList.txt";

            while (true)
            {
                var tuotteet = new List<string>(); // Luodaan lista tuotteille


                Console.Write("Lisää tuote ostoslistaan: ");
                string tuote = Console.ReadLine();

                tuotteet.Add(tuote); // Lisää tuotteen listaan

                // Kirjoittaa tuotteen tiedostoon shoppingList.txt
                File.AppendAllLines(@"C:\Users\Miikka\source\repos\ShoppingList\files\shoppingList.txt", tuotteet);


                // Ohjelman jatkaminen tai lopettaminen
                Console.Write("Paina 'enter' jatkaakseni tai kirjoita 'exit' lopettaaksesi: ");
                string exit = Console.ReadLine();
                exit.ToLower();


                // Tyhjentää konsolin
                Console.Clear();

                if (exit == "exit")
                    break;
            }

        }
    }
}
