using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task03
{
    public class Electronic : Product, IDiscountable
    {
        // property
        public int WarrantyPeriod { get; set; }

        // constructor
        public Electronic(string name, decimal price, int warranty) : base(name, price)
        {
            // validate warranty argument
            if (warranty < 0) throw new ArgumentOutOfRangeException("Warranty Period can not be negative, buddy!");
            WarrantyPeriod = warranty;
        }

        // detail method that overrides the base class method to include warranty information
        public override string GetProductDetails() => $"{base.GetProductDetails()}, Warranty: {WarrantyPeriod} months";
        

        // Apply discount by mutating Price and return the new price
        public decimal ApplyDiscount(decimal percent)
        {
            // validate percent argument
            if (percent < 0 || percent > 100) throw new ArgumentOutOfRangeException("Percent must be between 0 and 100, friend!");
            // calculate the new price after applying the discount and round to 2 decimal places
            return Math.Round(Price * (1 - percent / 100m), 2); // m -> convert to decimal
        }
    }
}
