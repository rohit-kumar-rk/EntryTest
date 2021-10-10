using System;
using System.Collections.Generic;
using System.Text;

namespace EntryTest
{
    public interface IPromotionalOffer
    {
        decimal GetPromotionalPrice(List<Product> Prod);
    }
}
