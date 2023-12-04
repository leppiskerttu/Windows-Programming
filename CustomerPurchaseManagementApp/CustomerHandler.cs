using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2; 

namespace Assignment2
{
    internal class CustomerHandler
    {
        public static void AddCustomer(Customer[] customers)
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            //lukee string name arvon käyttäjän antamasta

            Console.Write("Enter customer ID: ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            //yrittää muuttaa stringin intiksi ja palauttaa joko true tai false arvon
            //jos arvo on true id muuttuja arvo on se mitä käyttäjä antoi.
            {
                Console.WriteLine("Invalid ID format. Customer not added.");
                return;
            }

            Console.Write("Enter customer balance: ");
            decimal balance;
            if (!decimal.TryParse(Console.ReadLine(), out balance))
            {
                Console.WriteLine("Invalid balance format. Customer not added.");
                return;
            }

            Customer newCustomer = new Customer(name, id, balance);
            //Luodaan uusi asiakasolio newCustomer,
            //ja sille annetaan parametreina name (nimi), id (tunnus) ja balance (saldo).

            for (int i = 0; i < customers.Length; i++)
             //käydään läpi asiakastaulukko
            {
                if (customers[i] == null)
                    //jos paikka löytyy jossa ei ole asiakasta
                {
                    customers[i] = newCustomer;
                    //lisätään uusi asiakas siihen paikkaan
                    Console.WriteLine("New customer added successfully.");
                    return;
                }
            }

            Console.WriteLine("Customer array is full. Customer not added.");
        }

        public static void AddPurchase(Purchase[] purchases, Customer[] customers)
        {
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            Customer customer = Customer.SearchByName(customers, customerName);
            //Kutsuu Customer-luokan SearchByName-metodia, joka etsii asiakkaan nimen perusteella asiakastaulukosta.
            //Palauttaa löydetyn asiakkaan tai null, jos asiakasta ei löydy.

            if (customer == null)
            {
                Console.WriteLine("Customer not found. Purchase not added.");
                return;
            }

            Console.Write("Enter purchase ID: ");
            int purchaseId;
            if (!int.TryParse(Console.ReadLine(), out purchaseId))
                //yrittää muuttaa stringin intiksi ja palauttaa joko true tai false arvon
            {
                Console.WriteLine("Invalid purchase ID format. Purchase not added.");
                return;
            }

            Purchase newPurchase = new Purchase(purchaseId, DateTime.Now);
            //Luodaan uusi ostosolio newPurchase, ja sille annetaan parametreina purchaseId (ostoksen tunnus) ja DateTime.Now (ostoksen aikaleima).

            Console.Write("Product name: ");
            string productName = Console.ReadLine();

            Console.Write("Product ID: ");
            int productId;
            if (!int.TryParse(Console.ReadLine(), out productId))
                //yrittää muuttaa stringin intiksi ja palauttaa joko true tai false arvon
            {
                Console.WriteLine("Invalid product ID format. Product not added.");
            }
            else
            {
                Console.Write("Product price: ");
                decimal productPrice;
                if (!decimal.TryParse(Console.ReadLine(), out productPrice))
                {
                    Console.WriteLine("Invalid price format. Product not added.");
                }
                else
                {
                    newPurchase.AddProduct(productId, productName, productPrice);
                    //Kutsuu Purchase-luokan AddProduct-metodia, joka lisää tuotteen ostosolioon.
                    customer.AddPurchase(newPurchase);
                    //Kutsuu Customer-luokan AddPurchase-metodia, joka lisää ostoksen asiakkaan ostoslistaan.
                    Console.WriteLine("New purchase added successfully.");
                }
            }
        }

        public static void SearchAndDisplayCustomer(Customer[] customers)
        {
            Console.Write("Enter customer name: ");
            string searchName = Console.ReadLine();

            Customer foundCustomer = Customer.SearchByName(customers, searchName);
            //Kutsuu Customer-luokan SearchByName-metodia, joka etsii asiakkaan nimen perusteella asiakastaulukosta.

            if (foundCustomer != null)
            {
                Console.WriteLine($"Customer found: Name: {foundCustomer.Name}, ID: {foundCustomer.Id}, Credit: {foundCustomer.Credit}");
                //Tulostaa löydetyn asiakkaan tiedot.
                Console.WriteLine("Purchases:");

                foreach (Purchase purchase in foundCustomer.Purchases)
                    //käydään läpi löydetyn asiakkaan ostokset
                {
                    Console.WriteLine($"Purchase ID: {purchase.PurchaseId}, Purchase Date: {purchase.PurchaseDateTime}");
                    //Tulostaa ostoksen tiedot.
                    foreach (ProductItem product in purchase.Products)
                        //käydään läpi ostoksen tuotteet
                    {
                        Console.WriteLine($"Product: {product.ProductName}, Amount: {product.Amount}");
                        //Tulostaa tuotteen tiedot.
                    }
                }
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        public static void PrintAllCustomersAndPurchases(Customer[] customers)
        {
            Console.WriteLine("All Customers and Purchases:");
            foreach (Customer customer in customers)
                //käydään läpi asiakastaulukko
            {
                if (customer != null)
                {
                    Console.WriteLine($"Customer found: Name: {customer.Name}, ID: {customer.Id}, Credit: {customer.Credit}");
                    Console.WriteLine("Purchases:");
                    //Tulostaa asiakkaan tiedot ja ostokset.

                    foreach (Purchase purchase in customer.Purchases)
                    {
                        Console.WriteLine($"Purchase ID: {purchase.PurchaseId}, Purchase Date: {purchase.PurchaseDateTime}");
                        foreach (ProductItem product in purchase.Products)
                            //käydään läpi ostoksen tuotteet
                        {
                            Console.WriteLine($"Product: {product.ProductName}, Amount: {product.Amount}");
                            //Tulostaa tuotteen tiedot.
                        }
                    }
                }
            }
        }

        public static void SearchPurchaseById(Customer[] customers)
        {
            Console.Write("Enter purchase ID: ");
            int searchPurchaseId;

            if (int.TryParse(Console.ReadLine(), out searchPurchaseId))
                //yrittää muuttaa stringin intiksi ja palauttaa joko true tai false arvon
            {
                bool purchaseFound = false;
                //asetetaan purchaseFound arvo falseksi

                foreach (Customer customer in customers)
                {
                    if (customer != null)
                    {
                        foreach (Purchase purchase in customer.Purchases)
                            //käydään läpi asiakastaulukko
                        {
                            if (purchase != null && purchase.PurchaseId == searchPurchaseId)
                                //jos ostos löytyy asiakkaan ostoksista ja ostoksen id on sama kuin käyttäjän antama id 
                            {
                                Console.WriteLine("Purchase Details:");
                                Console.WriteLine($"Customer: {customer.Name}");
                                Console.WriteLine($"Purchase ID: {purchase.PurchaseId}, Purchase Date: {purchase.PurchaseDateTime}");
                                //Tulostaa ostoksen tiedot.

                                foreach (ProductItem product in purchase.Products)
                                {
                                    Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Amount: {product.Amount}");
                                } 
                                

                                purchaseFound = true;
                                //asetetaan purchaseFound arvo trueksi
                            }
                        }
                    }
                }

                if (!purchaseFound)
                {
                    Console.WriteLine("Purchase with the specified ID was not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric purchase ID.");
            }
        }
    }
}