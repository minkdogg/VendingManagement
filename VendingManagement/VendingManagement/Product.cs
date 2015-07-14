using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    class Product
    {

        protected string name;
        protected float wholeSalePrice;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public float WholeSalePrice
        {
            get
            {
                return wholeSalePrice;
            }
            set
            {
                wholeSalePrice = value;
            }
        }

        public Product(string name, float wholeSalePrice)
        {
            this.name = name;
            this.wholeSalePrice = wholeSalePrice;
        }

    }
}
