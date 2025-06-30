using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestProject
{
    public class DiscountService
    {
        public decimal ApplyDiscount(decimal price, decimal discountPercent)
        {
            if (discountPercent < 0 || discountPercent > 100)
                throw new ArgumentOutOfRangeException(nameof(discountPercent));

            return price * (1 - discountPercent / 100);
        }
    }
}
