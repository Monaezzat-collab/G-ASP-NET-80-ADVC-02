using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public class Product
    {
        #region 1. Product Model 
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

        #endregion

        #region 2.1  Print Reports
        public static void PrintReports(List<Product> ProductReportList, Action <Product> showReport) {
            foreach (Product product in ProductReportList) {
                showReport(product);
            }
        }
        #endregion

        #region 2.2 Transform Products 
        public static List<string> TransformProducts(List<Product> TransformList, Func<Product,string> transformDelegate) {

            List<string> result = new List<string>();
            foreach (Product product in TransformList) {
               result.Add(transformDelegate(product)) ;
            }
            return result ;
        }
        #endregion

        #region 2.3 Filter Products
        public static List<Product> FilterProducts(List<Product>filteredList,Predicate<Product> filterDelegate)
        {
            List<Product> result = new();

            foreach (Product product in filteredList)
            {
                if (filterDelegate(product)) {

                    result.Add(product);
                        }
            }
            return result;

        }
        #endregion

    }
}
