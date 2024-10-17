namespace V42_Gruppuppgift
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
            foreach (string produkt in inventory)
            {
                Console.WriteLine(produkt);

            }
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
