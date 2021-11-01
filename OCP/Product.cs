using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ProductType { get; set; }


        public virtual double GetDiscount()
        {
            return 0;
        }

    }


    public class ProductType1 : Product
    {
        public override double GetDiscount()
        {
            return (Price/100)*5;
        }
    }

    public class ProductType2 : Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 10;
        }
    }

    public class ProductType3 : Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 15;
        }
    }
}
