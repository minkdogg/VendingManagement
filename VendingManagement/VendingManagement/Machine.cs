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
        public List<List<string>> productTypes = new List<List<string>>();
        
        protected int maxCapacity;
        protected float salePrice;
        protected int defaultMinStock = 5;
        protected string city;
        protected string location;
        protected bool needService;
        protected bool needRestock;
        protected string machineID;

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
                List<string> productNames = getProductTypeNames();
                string productName = product.Name;
                if (productNames.Contains(productName))
                {
                    products.Add(product);
                    return true;
                }
                else
                {
                    List<string> newProductType = new List<string>();
                    string productRestock = defaultMinStock.ToString();
                    newProductType.Add(productName);
                    newProductType.Add(productRestock);
                    productTypes.Add(newProductType);

                    products.Add(product);
                    return true;
                }  
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

        public void removeProductType(string type)
        {
            List<string> productNames = getProductTypeNames();
            int indexName = productNames.IndexOf(type);
            productTypes.RemoveAt(indexName);
        }

        public bool addProductType(string type, int minStock)
        {
            List<string> productNames = getProductTypeNames();

            if (productNames.Contains(type))
            {
                return true;
            }

            else
            {
                List<string> newProductType = new List<string>();
                newProductType.Add(type);
                newProductType.Add(minStock.ToString());
                productTypes.Add(newProductType);
                return true;
            }
        }



        public int checkAllQuantity()
        {
            int countProduct = products.Count();
            return countProduct;
        }

        public int DefaultMinStock
        {
            get { return defaultMinStock; }
            set { defaultMinStock = value; }
        }

        public string MachineID
        {
            get { return machineID; }
            set { machineID = value; }
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

        public List<string> getProductTypeNames()
        {
            List<string> productNames = new List<string> { };

            foreach (List<string> product in productTypes)
            {
                productNames.Add(product[0]);
            }

            return productNames;
        }

        public List<int> getProductTypeRestock()
        {
            List<int> productRestock = new List<int> { };

            foreach (List<string> product in productTypes)
            {
                productRestock.Add(Convert.ToInt32(product[1]));
            }

            return productRestock;
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

        public void updateMinStockType(string name, int minStock)
        {
            List<string> productNames = getProductTypeNames();
            if (productNames.Contains(name))
            {
                int index = productNames.IndexOf(name);
                productTypes[index][1] = minStock.ToString();
            }
        }


        


        public Machine(string city, string location, string machineID)
        {
            this.city = city;
            this.location = location;
            this.machineID = machineID;
            this.maxCapacity = 25;
        }



    }
}
