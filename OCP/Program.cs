using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductType1 type1 = new ProductType1();
            type1.Name = "Product1";
            type1.Price = 20000;
            Console.WriteLine($"Discount = {type1.GetDiscount()} , Your finally check: {type1.Price - type1.GetDiscount()}");
        }
    }
}
