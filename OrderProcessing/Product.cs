using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public class Product
    {
    
        //public Product(int id, string? name, string? category, double price, int stock)
        //{
        //    Id = id;
        //    Name = name;
        //    Category = category;
        //    Price = price;
        //    Stock = stock;
        //}

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> condition)
            
        {
            List<Product> result = new List<Product>();

            foreach (Product product in products) {
                if (condition(product)) {
                    result.Add(product);
                }  
            }
            return result;
        }

    }
}
