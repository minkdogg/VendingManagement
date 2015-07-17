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

        protected string machineID;
        protected string city;
        protected string location;
        protected float salePrice;
        protected int defaultMinStock = 5;        
        protected bool needService;
        protected bool needRestock = true;
        protected int maxCapacity;
        

        public Machine(string city, string location, string machineID)
        {
            this.city = city;
            this.location = location;
            this.machineID = machineID;
            this.maxCapacity = 25;
        }


        //Getter and Setter Section
        public string MachineID
        {
            get { return machineID; }
            set { machineID = value; }
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
            get { return needService; }
            set { needService = value; }
        }

        public bool NeedRestock
        {
            get { return needRestock; }
            set { needRestock = value; }
        }

        public int DefaultMinStock
        {
            get { return defaultMinStock; }
            set { defaultMinStock = value; }
        }
        public int MaxCapacity
        {
            get { return maxCapacity; }
            set { maxCapacity = value; }
        }
        //End of Setter/Getter Section


        // adds product to products list and if necessary adds type to productTypes
        // assigns min stock level to be defaultMinStock for type if necessary.
        public bool addProduct(Product product)
        {
            if (products.Count() < maxCapacity)
            {
                List<string> productNames = getProductTypeNames();
                string productName = product.Name;
                if (productNames.Contains(productName))
                {
                    products.Add(product);
                    List<string> checkRestockItems = getItemsRestock();
                    if (checkRestockItems.Count() > 0)
                    {
                        needRestock = true;
                    }
                    else
                    {
                        needRestock = false;
                    }
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
                    List<string> checkRestockItems = getItemsRestock();
                    if (checkRestockItems.Count() > 0)
                    {
                        needRestock = true;
                    }
                    else
                    {
                        needRestock = false;
                    }
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool addMultipleProduct(List<Product> multipleProduct)
        {
            int newProductCount = products.Count() + multipleProduct.Count();
            if (newProductCount < maxCapacity)
            {
                foreach (Product product in multipleProduct)
                {
                    addProduct(product);
                    List<string> checkRestockItems = getItemsRestock();
                    if (checkRestockItems.Count() > 0)
                    {
                        needRestock = true;
                    }
                    else
                    {
                        needRestock = false;
                    }

                }
                return true;
            }
            else
            {
                return false;
            }
        }


        // Return a list of all objects matching the ID
        public List<Product> selectAllProductByType(string id)
        {
            List<Product> multipleProductReturn = new List<Product>();
            
            foreach (Product product in this.products)
            {
                if (product.Name == id)
                {
                    multipleProductReturn.Add(product);
                }
            }
            return multipleProductReturn;
        }



        // removes product from product list. If there is no product left, then type is removed from product Type.
        public void removeProduct(Product product)
        {
            int getProductQuantity = getSingleQuantity(product.Name);
            if (getProductQuantity == 1)
            {
                removeProductType(product.Name);
            }
            products.Remove(product);
            List<string> checkRestockItems = getItemsRestock();
            if (checkRestockItems.Count() > 0)
            {
                needRestock = true;
            }
            else
            {
                needRestock = false;
            }
            
        }

        public void removeMultipleProduct(List<Product> multipleProduct)
        {
            foreach (Product product in multipleProduct)
            {
                this.removeProduct(product);
                 List<string> checkRestockItems = getItemsRestock();
                    if (checkRestockItems.Count() > 0)
                    {
                        needRestock = true;
                    }
                    else
                    {
                        needRestock = false;
                    }
            }
        }

        // removes productType based on type entered.
        public void removeProductType(string type)
        {
            List<string> productNames = getProductTypeNames();
            int indexName = productNames.IndexOf(type);
            productTypes.RemoveAt(indexName);
        }

        // adds new product type if necessary with new minStock level.
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


        //returns total count of product in machine
        public int getAllQuantity()
        {
            int countProduct = products.Count();
            return countProduct;
        }

        //returns single count of product based on type (i.e. how many "Snickers" bars in machine)
        public int getSingleQuantity(string type)
        {
            List<string> productNames = getProductNames();
            int groupCount = 0;

            var groupProduct = productNames.GroupBy(i => i);

            foreach (var grp in groupProduct)
            {
                if (grp.Key == type)
                {
                    groupCount = grp.Count();
                    return groupCount;
                }
            }

            return groupCount;
        }

        // returns list of items needed for restock
        public List<string> getItemsRestock()
        {

            List<string> restockItems = new List<string> { };
            List<int> restockMin = new List<int> { };
            List<string> productNames = getProductNames();
            List<string> uniqueProductNames = productNames.Distinct().ToList();

            var groupProduct = productNames.GroupBy(i => i);

            foreach (var list in productTypes)
            {
                if (uniqueProductNames.Contains(list[0]))
                {
                    int typeCount = getSingleQuantity(list[0]);
                    if (Convert.ToInt32(list[1]) > typeCount)
                    {
                        restockItems.Add(list[0]);
                    }
                }
            }

            return restockItems;
        }

        //checks to single item to see if it needs restock
        public bool checkSingleItemRestock(string type)
        {
            int restockMin = getSingleTypeMinStock(type);
            int typeCount = getSingleQuantity(type);
            if (typeCount < restockMin)
            {
                return true;
            }
            else
            {
                return false;
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

        
        //Start of Helper functions for class

        // returns list of all product names in product list
        public List<string> getProductNames()
        {
            List<string> productNames = new List<string> { };
            foreach (Product product in products)
            {
                productNames.Add(product.Name);
            }
            return productNames;
        }

        // returns list of all product types in product type list.
        public List<string> getProductTypeNames()
        {
            List<string> productNames = new List<string> { };

            foreach (List<string> product in productTypes)
            {
                productNames.Add(product[0]);
            }

            return productNames;
        }

        // retrieves product Type needed for restock
        public List<int> getProductTypeRestock()
        {
            List<int> productRestock = new List<int> { };

            foreach (List<string> product in productTypes)
            {
                productRestock.Add(Convert.ToInt32(product[1]));
            }

            return productRestock;
        }

        public int getSingleTypeMinStock(string type)
        {
            int minStock = 0;
            foreach (var list in productTypes)
            {
                if (list[0] == type)
                {
                    minStock = Convert.ToInt32(list[1]);
                    return minStock;
                }
            }
            return minStock;
        }


        
        
        //public void updateRetailPrice(string name, float price)
        //{
        //    foreach (Product product in products)
        //    {
        //        if (name == product.name)
        //        {
        //            product.retailPrice = price;
        //        }
        //    }
        //}




    }
}
