﻿namespace V42_Gruppuppgift
{
    using System;

    using System.Collections.Generic;

    class Program

    {

        static List<string> inventory = new List<string>();

        static void Main(string[] args)

        {

            Console.WriteLine("Välkommen till Fabrikshanteringssystemet!.");



            while (true)

            {

                Console.WriteLine("\nVälj en åtgärd:");

                Console.WriteLine("1. Lägg till produkt");

                Console.WriteLine("2. Visa inventarie");

                Console.WriteLine("3. Ta bort en produkt");

                Console.WriteLine("5. Avsluta");
                Console.WriteLine("4 Sök på produkt");

                Console.WriteLine("3. Avsluta");



                string val = Console.ReadLine();

                switch (val)

                {

                    case "1":

                        LäggTillProdukt();

                        break;

                    case "2":

                        VisaInventarie();

                        break;

                    case "3":

                        TaBortProdukt();

                        return;
                    case "4":
                        SökProduct();
                        break;
                        
                    default:

                        Console.WriteLine("Ogiltigt val. Försök igen.");

                        break;

                }

            }

        }

        static void LäggTillProdukt()

        {

            // TODO: Implementera metod för att lägga till produkt

        }

        static void VisaInventarie()

        {

            // TODO: Implementera metod för att visa inventarie

        }
        static void SökProduct()
        {
            Console.WriteLine("Sök i product");
            String sökval = Console.ReadLine();
            int productNr = 1;
            foreach (var product in inventory)
            {
                if (product.Contains(sökval))
                {
                    
                    Console.WriteLine($"{product}: {product}");
                    productNr++;
                    break;
                }
            }
            Console.WriteLine("Inga producter hittades");

        }

        static void TaBortProdukt()
        {
            Console.Write("Vilken produkt vill du ta bort? ");
            string sökord = Console.ReadLine();

            bool harSökord = inventory.Contains(sökord);
            
            if (harSökord)
            {
                inventory.Remove(sökord);
            }
        }
    }

}
