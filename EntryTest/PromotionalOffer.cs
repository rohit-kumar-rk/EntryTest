using System;
using System.Collections.Generic;
using System.Linq;

namespace EntryTest
{
    public class PromotionalOffer : IPromotionalOffer
    {
        public decimal GetPromotionalPrice(List<Product> Products)
        {
            decimal finalPriceA = 0;
            decimal finalPriceB = 0;
            decimal finalPriceC = 0;
            decimal finalPriceD = 0;
            foreach (Product product in Products)
            {
                switch (product.prodType.ToUpper())
                {
                    case "A":
                        finalPriceA = ((product.NoOfUnit / 3) * 130) + ((product.NoOfUnit % 3) * 50);
                        break;

                    case "B":
                        finalPriceB = ((product.NoOfUnit / 2) * 45) + ((product.NoOfUnit % 2) * 30);
                        break;
                }
            }

            Product prodC = Products.Where(x => x.prodType.ToUpper() == "C").FirstOrDefault();
            Product prodD = Products.Where(x => x.prodType.ToUpper() == "D").FirstOrDefault();

            if (prodC.NoOfUnit ==0 || prodD.NoOfUnit==0)
            {
                finalPriceC = prodC.NoOfUnit * 20;
                finalPriceD = prodD.NoOfUnit * 15;
            }
            else if (prodC.NoOfUnit < prodD.NoOfUnit)
            {
                finalPriceC = 0;
                finalPriceD = (prodC.NoOfUnit * 30) + ((prodD.NoOfUnit - prodC.NoOfUnit) * 15);
            }
            else if (prodD.NoOfUnit < prodC.NoOfUnit)
            {
                finalPriceD = 0;
                finalPriceC = (prodD.NoOfUnit * 30) + ((prodC.NoOfUnit - prodD.NoOfUnit) * 20);
            }
            else
            {
                finalPriceD = 0;
                finalPriceC = prodC.NoOfUnit * 30;
            }

            return (finalPriceA + finalPriceB + finalPriceC + finalPriceD);
        }
    }
}
