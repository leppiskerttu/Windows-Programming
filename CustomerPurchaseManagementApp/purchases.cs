using System;
using System.Collections.Generic;
using Assignment2;

namespace Assignment2
{
    public class Purchase
    {
        // Ominaisuudet
        public int PurchaseId { get; }
        public DateTime PurchaseDateTime { get; }
        public List<ProductItem> Products { get; } = new List<ProductItem>();

        //konstruktori
        public Purchase(int purchaseId, DateTime purchaseDateTime)
        {
            PurchaseId = purchaseId;
            PurchaseDateTime = purchaseDateTime;
        }

        // metodi jolla lisätään tuotteita ostokseen
        public void AddProduct(int productId, string productName, decimal amount)
        {
            Products.Add(new ProductItem(productId, productName, amount));
        }
    }

    
    public class ProductItem
    {
        // Ominaisuudet
        public int ProductId { get; }
        public string ProductName { get; }
        public decimal Amount { get; }
        // konstruktori
        public ProductItem(int productId, string productName, decimal amount)
        {
            ProductId = productId;
            ProductName = productName;
            Amount = amount;
        }
    }
}
