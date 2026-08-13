using System;
using System.Collections.Generic;
using Ecommerce;

namespace CollectionOfObjects
{
    internal class Display
    {

        public static void Main()
        {
            List<Product> products = new List<Product>();

            string choice;
            do
            {
                Console.WriteLine("Enter Product Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Product Price:");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Manufecture Date (YYYY-MM-DD):");
                DateTime date = DateTime.Parse(Console.ReadLine());


                Product product = new Product() { ProductId = id, ProductName = name, ProductPrice = price, ProductManufectureDate = date };
                products.Add(product);

                Console.WriteLine("Product Is Added !");
                Console.WriteLine("Do You Want To Add More ? Press Enter");

                choice = Console.ReadLine().ToUpper();
                
            } while (choice != "STOP");

            Console.WriteLine("\nProducts Are:");
            foreach(Product item in products)
            {
                Console.WriteLine("Product Id:"+item.ProductId);
                Console.WriteLine("Product Name:" + item.ProductName);
                Console.WriteLine("Product Price:" + item.ProductPrice);
                Console.WriteLine("Product Manufecture Date :" + item.ProductManufectureDate);
            }
        }
    }
}
