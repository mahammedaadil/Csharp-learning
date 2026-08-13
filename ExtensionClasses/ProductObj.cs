using System;
using ClassLibrary;
using ExtensionClasseEx;

namespace ExtensionClasses
{
    public class ProductObj
    {
        static void Main()
        {
            Product p = new Product() { ProductCost = 1000, ProductDiscount = 10 };
            Console.WriteLine(p.GetDiscount());
        }
    }
}
