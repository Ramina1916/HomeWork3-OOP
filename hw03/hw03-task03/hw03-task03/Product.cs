using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task03
{
    public class Product
    {
        // properties for product name and price
        public string Name { get; set; }
        public decimal Price { get; set; }

        // constructor for product class that takes name and price as parameters
        public Product(string name, decimal price)
        {
            if (name == null) throw new ArgumentNullException("Product name can not be null, buddy!");
            if (price < 0) throw new ArgumentOutOfRangeException("Price cannot be negative, buddy!");
            else
            {
                Name = name;
                Price = price;
            }
        }

        // a virtual method to get product details, which can be overridden in derived classes
        public virtual string GetProductDetails() => $"Name: {Name}, Price: {Price:C}";

    }
}
