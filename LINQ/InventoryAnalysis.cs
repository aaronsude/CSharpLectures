using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InventoryAnalysis
    {
        public static void Start()
        {
            Console.WriteLine("===== PRODUCT INVENTORY ANALYSIS =====\n");

            List<Product> products = new List<Product>
                {
                    new Product { Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 5 },
                    new Product { Name = "Mouse", Category = "Accessories", Price = 25, Stock = 50 },
                    new Product { Name = "Keyboard", Category = "Accessories", Price = 75, Stock = 20 },
                    new Product { Name = "Monitor", Category = "Electronics", Price = 400, Stock = 8 },
                    new Product { Name = "Headset", Category = "Accessories", Price = 120, Stock = 12 }
                };

            // All products
            Console.WriteLine("All Products:");
            Console.WriteLine("──────────────");
            foreach (var p in products)
                p.PrintInfo();

            // 1. By Category
            Console.WriteLine("\n1. By Category:");
            var grouped = products.GroupBy(p => p.Category);
            foreach (var group in grouped)
            {
                Console.WriteLine($"   {group.Key}: {string.Join(", ", group.Select(p => p.Name))}");
            }

            // 2. Price > 100
            Console.WriteLine("\n2. Products > $100:");
            var expensiveProducts = products.Where(p => p.Price > 100);
            foreach (var p in expensiveProducts)
                Console.WriteLine($"   {p.Name} (${p.Price})");

            // 3. Top 3 Most Expensive
            Console.WriteLine("\n3. Top 3 Most Expensive:");
            var top3 = products.OrderByDescending(p => p.Price).Take(3);
            foreach (var p in top3)
                Console.WriteLine($"   {p.Name} (${p.Price})");

            // 4. Total Value
            decimal totalValue = products.Sum(p => p.Price * p.Stock);
            Console.WriteLine($"\n4. Total Inventory Value: ${totalValue}");

            // 5. Average Stock
            double averageStock = products.Average(p => p.Stock);
            Console.WriteLine($"\n5. Average Stock Level: {averageStock:F0} units");

            // 6. Low Stock
            Console.WriteLine("\n6. Low Stock (< 10):");
            var lowStock = products.Where(p => p.Stock < 10);
            foreach (var p in lowStock)
                Console.WriteLine($"   {p.Name} ({p.Stock} units)");
        }
    }

    public class Product
    {
        public string? Name { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} ({Category}) - ${Price}, Stock: {Stock}");
        }
    }

}
