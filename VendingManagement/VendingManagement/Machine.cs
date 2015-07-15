using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    public class Machine
    {
        public List<Product> products = new List<Product> { };
        
        protected int maxCapacity;
        protected float salePrice;
        protected int minStockItem;
        protected string city;
        protected string location;
        protected bool needService;
        protected bool needRestock;
        protected int machineNum;

        public int MaxCapacity
        {
            get{ return maxCapacity; }
            set{ maxCapacity = value; }
        }

        public float SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public bool NeedService
        {
            get { return NeedService; }
            set { needService = value; }
        }

        public bool NeedRestock
        {
            get { return NeedRestock; }
            set { needRestock = value; }
        }

        public bool addProduct(Product product)
        {
            if (products.Count() < maxCapacity)
            {
                products.Add(product);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool removeProduct(Product product)
        {
            return products.Remove(product);
        }

        public int checkAllQuantity()
        {
            int countProduct = products.Count();
            return countProduct;
        }

        public int minStock
        {
            get { return minStock; }
            set { minStock = value; }
        }

        public int MachineNum
        {
            get { return machineNum; }
            set { machineNum = value; }
        }



        public List<string> getProductNames()
        {
            List<string> productNames = new List<string> { };

            foreach (Product product in products)
            {
                productNames.Add(product.Name);
            }

            return productNames;
        }

        public List<string> checkItemsRestock()
        {
            
            List<string> restockItems = new List<string> {};
            List<string> productNames = getProductNames();
            List<string> uniqueProductNames = productNames.Distinct().ToList();

            var groupProduct = productNames.GroupBy(i => i);

            foreach (var group in groupProduct)
            {
                
                restockItems.Add(group.Key);
            }

            return restockItems;
        }

        public void updateRetailPrice(string name, float price)
        {
            foreach (Product product in products)
            {
                if (name == product.name)
                {
                    product.retailPrice = price;
                }
            }
        }


        public int getMachineCount()
        {
            int count = Database.listMachine.Count();
            return count;
        }


        public Machine(string city, string location)
        {
            this.city = city;
            this.location = location;
            this.machineNum = getMachineCount()+ 1;
        }



    }
}
