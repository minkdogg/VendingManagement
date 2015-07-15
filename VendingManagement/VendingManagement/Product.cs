using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    public class Product
    {

        public string name;
        protected float wholeSalePrice;
        public float retailPrice;
        protected List<string> productTypes = new List<string> { "Snickers", "Coke", "Milky Way", "Almond Joy", "Sprite", "Dr. Pepper", "Doritos", "Fritos", "Lays" };


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

        public void addType(string type)
        {
            productTypes.Add(type);
        }

        public Product(string name, float wholeSalePrice)
        {
            this.name = name;
            this.wholeSalePrice = wholeSalePrice;
            this.retailPrice = wholeSalePrice;
        }

    }
}
