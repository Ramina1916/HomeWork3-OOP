using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task03
{
    public class Clothing : Product, IDiscountable
    {
        // properties for clothing size and material
        public string Size { get; set; } // s, m, l, xl, xxl, xxxl
        public string Material { get; set; }

        // constructor for clothing class that takes name, price, size, and material as parameters
        public Clothing(string name, decimal price, string size, string material) : base(name, price)
        {
            if(size == null && material == null) throw new ArgumentNullException("Size and Material cannot be null, buddy!");
            Material = material;
            Size = size;
        }

        // a method that overrides the base class method to include size and material information
        public override string GetProductDetails() => $"{base.GetProductDetails()}, Size: {Size}, Material: {Material}";
       

        // Apply discount by mutating Price and return the new price
        public decimal ApplyDiscount(decimal percent)
        {
            if (percent < 0 || percent > 100) throw new ArgumentOutOfRangeException("Percent must be between 0 and 100., friend!");
            // return discounted price without mutating the original Price
            return Math.Round(Price * (1 - percent / 100m), 2);
        }
    }
}
