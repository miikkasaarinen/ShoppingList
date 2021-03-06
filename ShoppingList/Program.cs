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

            try
            {
                // Avataan tekstitiedosto käyttämällä stream readeriä.
                using (var sr = new StreamReader(@"C:\Users\Miikka\source\repos\ShoppingList\files\shoppingList.txt"))
                {
                    // Luetaan streami stringinä ja kirjoitetaan stringi konsoliin.
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Tiedostoa ei voitu lukea:");
                Console.WriteLine(e.Message);
            }


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