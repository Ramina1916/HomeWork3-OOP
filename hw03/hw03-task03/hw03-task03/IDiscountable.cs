using System;
using System.Collections.Generic;
using System.Text;

namespace hw03_task03
{
    // interface for products that can have discounts applied
    public interface IDiscountable
    {
        decimal ApplyDiscount(decimal percent);
    }
}
