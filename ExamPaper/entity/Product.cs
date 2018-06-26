using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPaper.entity
{
    class Product
    {

        private string productId;
        private string name;
        private string price;
                
       
        public string ProductId { get => productId; set => productId = value; }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }

        public Product()
        {
        }

        public Product(string productId, string name, string price)
        {
            this.ProductId = productId;
            this.Name = name;
            this.Price = price;
            
        }
    }
}
