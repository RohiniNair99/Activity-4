using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4BL
{

    public class Category
    {
        public string categoryName; 
    }
     public class Product
        {

            private Category category;
            static int currentProductId;
            private string description;
            private double price;
            private string productId;
            private string productName;


            public string Description { get; set; }
            public double Price { get; set; }
            public string ProductId { get; set; }
            public string ProductName { get; set; }

            public Category Category
            {
                get; set;
            }

            static Product()
            {
                currentProductId = 1001;
            }
            public Product()
            {
            ProductId = "P" + currentProductId++;
             }
            public Product(string description, double price, string productName,Category category):this()
            {
                Description = description;
                Price = price;
                ProductName = productName;
                Category = category;
            }

            

        }
    }
