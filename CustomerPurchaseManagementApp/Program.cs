using System; 
using Assignment2; 

namespace Assignment2 
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            // Luodaan taulukko asiakasolioille
            Customer[] customers = new Customer[5];

            // Luodaan asiakasoliot ja lisätään ne taulukkoon
            customers[0] = new Customer("niko", 1, 1000);
            customers[1] = new Customer("kalevi", 2, 2000);

            // Otetaan asiakasoliot talteen muuttujiin
            Customer niko = customers[0];
            Customer kalevi = customers[1];

            // Luodaan taulukko ostosolioille
            Purchase[] purchases = new Purchase[2];

            // Luodaan ostosoliot ja lisätään ne taulukkoon
            Purchase purchase1 = new Purchase(1, DateTime.Now);
            purchase1.AddProduct(1, "Kalja", 50.0m);
            purchase1.AddProduct(2, "Ruoka", 30.0m);
            purchases[0] = purchase1;

            Purchase purchase2 = new Purchase(2, DateTime.Now);
            purchase2.AddProduct(3, "Maito", 50.0m);
            purchase2.AddProduct(4, "Leipä", 30.0m);
            purchases[1] = purchase2;

            // Lisätään ostokset asiakkaille
            niko.AddPurchase(purchase1);
            kalevi.AddPurchase(purchase2);

            bool exitProgram = false;
            // Luodaan muuttuja, joka määrittää ohjelman suorituksen jatkumisen

            // Luodaan CustomerHandler-olio
            CustomerHandler customerHandler = new CustomerHandler();

            // Käyttöliittymä, joka toistaa valintoja kunnes käyttäjä valitsee lopettaa
            while (!exitProgram)
            {
                Console.WriteLine("Menu:"); // Tulostetaan valikko
                // Näytetään valinnat
                Console.WriteLine("1. Search for a customer");
                Console.WriteLine("2. Add a new customer");
                Console.WriteLine("3. Print all customers and purchases");
                Console.WriteLine("4. Search for a purchase by ID");
                Console.WriteLine("5. Add a new purchase");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice (1, 2, 3, 4, 5, or 0): "); // Pyydetään käyttäjältä valinta

                int choice; // Muuttuja valinnan tallentamiseksi

                // Yritetään lukea käyttäjän syöte ja tulkita se numeroksi
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    // Suoritetaan toiminto valinnan perusteella
                    switch (choice)
                    {
                        case 1:
                            CustomerHandler.SearchAndDisplayCustomer(customers); // Etsi ja näytä asiakas
                            break;

                        case 2:
                            CustomerHandler.AddCustomer(customers); // Lisää uusi asiakas
                            break;

                        case 3:
                            CustomerHandler.PrintAllCustomersAndPurchases(customers); // Tulosta kaikki asiakkaat ja ostokset
                            break;

                        case 4:
                            CustomerHandler.SearchPurchaseById(customers); // Etsi ostos ID:n perusteella
                            break;

                        case 5:
                            CustomerHandler.AddPurchase(purchases, customers); // Lisää uusi ostos
                            break;

                        case 0:
                            exitProgram = true; // Lopeta ohjelma
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please provide 1, 2, 3, 4, 5, or 0 to exit."); // Virheellinen valinta
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number (1, 2, 3, 4, 5, or 0 to exit)."); // Virheellinen syöte
                }
            }
        }
    }
}

