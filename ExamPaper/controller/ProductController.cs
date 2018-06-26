using ExamPaper.entity;
using System;
using System.Collections.Generic;

namespace ExamPaper.controller
{
    class ProductController
    {
        private static List<Product> listProduct = new List<Product>();

        public static bool AddProduct()
        {
            var product = new Product();
            Console.WriteLine("Enter ProductId :");
            product.ProductId = Console.ReadLine();
            Console.WriteLine("Enter name:");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter price:");
            product.Price = Console.ReadLine();

            listProduct.Add(product);
            return true;
        }

        public static void DisplayList()
        {
            Console.WriteLine("{0, -20} {1, -20} {2, -20}", "ProductId", "Name", "Price");
            Console.WriteLine("------------------------------------------------");
            foreach (var product in listProduct)
            {
                Console.WriteLine("{0, -20} {1, -20} {2, -20}", product.ProductId, product.Name, product.Price);
            }
            Console.ReadLine();
        }

        public static bool DeleteById()
        {
            Console.WriteLine("Please enter Id to delete: ");
            var id = Console.ReadLine();

            Product idDelete = listProduct.Find(a => a.ProductId == id);
            listProduct.Remove(idDelete);
            return true;
        }
    }
}
