using System;
using ClassLibrary;

namespace ExtensionClasseEx
{
    public static class ProductExtension
    {
        public static double GetDiscount(this Product product)
        {
            return product.ProductCost * product.ProductDiscount / 100;
        }
    }
}
