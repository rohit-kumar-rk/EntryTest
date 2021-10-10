using System;
using System.Collections.Generic;
namespace EntryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Checkout process");
        #region Console utility
            //un-commentBelow Code
        //reGenerate:
        //    Console.WriteLine("-----------------------------");
        //    Console.WriteLine("Number of unit of Product A:");
        //    Product product = new Product();
        //    List<Product> ProdList = new List<Product>();

        //    int noOfUnitA = Convert.ToInt32(Console.ReadLine());
        //    product.NoOfUnit = ValidateUnit(noOfUnitA);
        //    product.prodType = "A";
        //    ProdList.Add(product);
        //    product = new Product();

        //    Console.WriteLine("\nNumber of unit of Product B:");
        //    int noOfUnitB = Convert.ToInt32(Console.ReadLine());
        //    product.NoOfUnit = ValidateUnit(noOfUnitB);
        //    product.prodType = "B";
        //    ProdList.Add(product);
        //    product = new Product();

        //    Console.WriteLine("\nNumber of unit of Product C:");
        //    int noOfUnitC = Convert.ToInt32(Console.ReadLine());
        //    product.NoOfUnit = ValidateUnit(noOfUnitC);
        //    product.prodType = "C";
        //    ProdList.Add(product);
        //    product = new Product();

        //    Console.WriteLine("\nNumber of unit of Product D:");
        //    int noOfUnitD = Convert.ToInt32(Console.ReadLine());
        //    product.NoOfUnit = ValidateUnit(noOfUnitD);
        //    product.prodType = "D";
        //    ProdList.Add(product);

        //    IPromotionalOffer promotionalOffer = new PromotionalOffer();
        //    var totalCost = promotionalOffer.GetPromotionalPrice(ProdList);
        //    Console.WriteLine("Total Invoice Value: {0}", totalCost);
        //    Console.WriteLine("-----------------------------");
        //    Console.WriteLine("Do you want to Generate another Invoice (Y/N):");
        //    var response = Console.ReadLine().ToUpper();
        //    if (response == "Y")
        //        goto reGenerate;
            #endregion Console utility 
            Console.Read();
        }

        private static int ValidateUnit(int noOfUnit)
        {
            while (noOfUnit < 0)
            {
                Console.WriteLine("Please re-enter the Number of unit of Product(it can be zero or more):\n");
                noOfUnit = Convert.ToInt32(Console.ReadLine());
            }

            return noOfUnit;
        }
    }
}
