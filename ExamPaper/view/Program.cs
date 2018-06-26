
using ExamPaper.controller;
using System;

namespace ExamPaper
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine("---------------Management Product---------------");
                Console.WriteLine("1. Add new product.");
                Console.WriteLine("2. Display list product.");
                Console.WriteLine("3. Delete product.");
                Console.WriteLine("4. Exit.");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Please enter your choice");
                var choice = Int16.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add Product.");
                        if (ProductController.AddProduct())
                        {
                            Console.WriteLine("Add success!!!");
                        }
                        else
                        {
                            Console.WriteLine("Failed. Please try again.");
                        }
                       
                        break;
                    case 2:
                        Console.WriteLine("List product.");
                        ProductController.DisplayList();
                        break;
                    case 3:
                        if (ProductController.DeleteById())
                        {
                            Console.WriteLine("Deleted success!");

                        }
                        else
                        {
                            Console.WriteLine("Failed. Please try again.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Good bye!!!");
                        Environment.Exit(2);
                        break;

                }
            }
        }
    }
}
