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
        protected List<string> productTypes = new List<string> { "Snickers", "Coke", "Milky Way", "Almond Joy", "Sprite", "Dr. Pepper", "Doritos", "Fritos", "Lays" };

        public Product(string name, float wholeSalePrice)
        {
            this.name = name;
            this.wholeSalePrice = wholeSalePrice;
        }


        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }

        public float WholeSalePrice
        {
            get{ return wholeSalePrice; }
            set{ wholeSalePrice = value; }
        }

        public void addType(string type)
        {
            productTypes.Add(type);
        }


    }
}
