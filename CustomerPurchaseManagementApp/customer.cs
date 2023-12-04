using System;
using System.Collections.Generic;

namespace Assignment2
{
    internal class Customer
    {
        // Ominaisuudet (properties) asiakkaan tiedoille
        public string Name { get; }  // Asiakkaan nimi, luettavissa ulkopuolelta.
        public int Id { get; }       // Asiakkaan id, luettavissa ulkopuolelta.
        public decimal Credit { get; }  // Asiakkaan luottoraja, luettavissa ulkopuolelta.

        // Yksityinen lista ostoksille
        public List<Purchase> Purchases { get; } = new List<Purchase>();

        // Konstruktori, joka ottaa asiakkaan tiedot parametreina
        public Customer(string name, int id, decimal credit)
        {
            Name = name;
            Id = id;
            Credit = credit;
        }

        // Metodi, joka etsii asiakkaan nimen perusteella
        public static Customer SearchByName(Customer[] customers, string searchName)
        {
            foreach (Customer customer in customers)
                //jokainen asiakas asiakas arrayssa
            {
                if (customer != null && customer.Name == searchName)
                    //jos nimi löytyy arraysta palauttaa customer
                {
                    return customer;
                }
            }
            return null; // Palauta null, jos asiakasta ei löydy etsityllä nimellä.
        }

        // Sisäinen metodi, joka lisää ostoksen asiakkaan ostoslistaan
        internal void AddPurchase(Purchase purchase)
        {
            Purchases.Add(purchase);
            //lisää ostoksen asiakkaan ostoslistaan
        }
    }
}
