namespace OrderProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We need this system to be flexible, making the system easy to extend without modification. >> Use Delegate
            #region Starter Code: Data Models & Product Catalog 
            //Product class and product catalog

            List<Product> catalog = new()
            {
                new Product {Id=1,Name="Laptop",Category="Electronics",Price=1200,Stock=10},

                new Product {Id=2,Name="Phone",Category="Electronics",Price=800,Stock=25},

                new Product {Id=3,Name="T-Shirt",Category="Clothing",Price=30,Stock=100},

                new Product {Id=4,Name="Jeans",Category="Clothing",Price=60,Stock=50},

                new Product {Id=5,Name="Chocolate",Category="Food",Price=5,Stock=200},

                new Product {Id=6, Name="Coffee Beans",Category="Food",Price=15,Stock=80},

                new Product{Id=7, Name="C# Book",Category="Books",Price=45,Stock=30},

                new Product{Id=8, Name="Novel",Category="Books",Price=20,Stock=60},

                new Product{Id=9, Name="Headphones",Category="Electronics",Price=150,Stock=40},

                new Product{Id=10, Name="Jacket",Category="Clothing",Price=120,Stock=15},





            };

            #endregion

            #region Task 01 : Smart Product Search

            //List<Product> electronics = Product.SearchProducts(catalog, item => item.Category == "Electronics");
            //List<Product> cheap = Product.SearchProducts(catalog, item => item.Price < 50);
            //List<Product> inStock = Product.SearchProducts(catalog, item => item.Stock > 0);
            //List<Product> cheapClothing = Product.SearchProducts(catalog, item => item.Category == "Clothing" && item.Price < 100);

            ////1. All Electronics products 

            //Console.WriteLine("----- Electronics  ----- ");
            //foreach (Product product in electronics)
            //{
            //    Console.WriteLine($"{product.Name} - ${product.Price} -[Stock: {product.Stock}]");
            //}
            ////2. Products cheaper than $50 

            //Console.WriteLine("----- Under $50 -----");
            //foreach (Product product in cheap)
            //{
            //    Console.WriteLine($"{product.Name} - ${product.Price} -[Stock: {product.Stock}]");

            //}

            ////3. Products that are in stock (Stock > 0) 
            //Console.WriteLine("----- In Stock -----");
            //foreach (Product product in inStock)
            //{
            //    Console.WriteLine($"{product.Name} - ${product.Price} -[Stock: {product.Stock}]");

            //}

            ////4. Clothing products under $100
            //Console.WriteLine("------- Clothing Under $100 -------");
            //foreach (Product product in cheapClothing)
            //{
            //    Console.WriteLine($"{product.Name} - ${product.Price} -[Stock: {product.Stock}]");

            //}
            #endregion

            #region Task 02 : Custom Report Generator

            #region 2.1  Print Reports 
            ////Scenario 1  Short Report: Print each product as Name - $Price 
            //Console.WriteLine("--- Short Report ---");
            //Product.PrintReports(catalog, product => Console.WriteLine($"{product.Name} - ${product.Price}"));

            ////Scenario 2  Detailed Report: Print each product as [Category] Name | Price: $X | Stock: Y 
            //Console.WriteLine("\n--- Detailed Report ---");
            //Product.PrintReports(catalog, product => Console.WriteLine($"[{product.Category}]  {product.Name} | ${product.Price} | Stock: {product.Stock}"));

            #endregion

            #region 2.2 Transform Products 
            ////Scenario 3 Summary List: Transform each product into a string like "Laptop ($1200)". Print all results. 
            //Console.WriteLine("--- Summary List ---");
            //List<string> summaryList = Product.TransformProducts(catalog, product => $"{product.Name} (${product.Price})");

            //foreach (string summary in summaryList)
            //{
            //    Console.WriteLine(summary);
            //}

            ////Scenario 4 - Price Label

            //Console.WriteLine("\n--- Price Label ---");
            //List<string> priceLabels = Product.TransformProducts(catalog, product =>
            //$"{product.Name}: {(product.Price > 100 ? "Expensive!" : "Affordabel!")}");
            //foreach (string priceLabel in priceLabels)
            //{
            //    Console.WriteLine(priceLabel);
            //}
            #endregion

            #region 2.3 Filter Products
            //Scenario 5  Low-Stock Alert: Find products with Stock < 20 and print an alert for each in the format: [LOW STOCK] Name: only X left!

            Console.WriteLine("\n --- Low-Stock Alert ---");
            List<Product> LowStock = Product.FilterProducts(catalog, product => product.Stock < 20);

            foreach (Product product in LowStock) {

            Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");

            }
            #endregion

            #endregion


        }
    }
    }

