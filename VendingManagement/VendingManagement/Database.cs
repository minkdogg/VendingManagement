using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    class Database
    {
        List<Product> listProduct = new List<Product>();
        List<Machine> listMachine = new List<Machine>();
        List<City> listCity = new List<City>();
        List<Employee> listEmployee = new  List<Employee>();
        List<Vehicle> listVehicle = new List<Vehicle>();
        List<Transactions> listTransactions = new List<Transactions>();

        

        public void generateInitialData()
        {
            this.generateInitialProducts();
            this.generateInitialMachines();
            this.generateInitialCities();
            this.generateInitialEmployees();
            this.generateInitialVehicles();
            this.generateInitialTransactions();
        }

        //
        // Append Database Entries
        //
        public void Append(Product entry)
        {
            listProduct.Add(entry);
        }
        public void Append(Machine entry)
        {
            listMachine.Add(entry);
        }
        public void Append(City entry)
        {
            listCity.Add(entry);
        }
        public void Append(Employee entry)
        {
            listEmployee.Add(entry);
        }
        public void Append(Vehicle entry)
        {
            listVehicle.Add(entry);
        }
        public void Append(Transactions entry)
        {
            listTransactions.Add(entry);
        }

        //
        // Remove Database Entries
        //
        public void Remove(Product entry)
        {
            listProduct.Remove(entry);
        }
        public void Remove(Machine entry)
        {
            listMachine.Remove(entry);
        }
        public void Remove(City entry)
        {
            listCity.Remove(entry);
        }
        public void Remove(Employee entry)
        {
            listEmployee.Remove(entry);
        }
        public void Remove(Vehicle entry)
        {
            listVehicle.Remove(entry);
        }
        public void Remove(Transactions entry)
        {
            listTransactions.Remove(entry);
        }


        //
        // Select Single Database Entry
        //
        //public Product Select(string id)
        //{
        //    return null;
        //}



        //
        // SelectAll Matchuing Database Entries
        //
        public List<Product> SelectAll(string id)
        {
            List<Product> returnResult = new List<Product>();
            foreach (Product product in listProduct)
            {
                if (product.Name == id)
                {
                    returnResult.Add(product);
                }
            }
            return returnResult;
        }


        public void generateInitialProducts()
        {
            Product product1 = new Product("Snickers", .25f);
            Product product2 = new Product("Milky Way", .25f);
            Product product3 = new Product("Mounds", .25f);
            Product product4 = new Product("Almond Joy", .25f);
            Product product5 = new Product("Coke", .25f);
            Product product6 = new Product("Sprite", .25f);
            Product product7 = new Product("Dr. Pepper", .25f);
            Product product8 = new Product("Doritos", .25f);
            Product product9 = new Product("Fritos", .25f);
            Product product10 = new Product("Lays", .25f);

            listProduct.Add(product1);
            listProduct.Add(product2);
            listProduct.Add(product3);
            listProduct.Add(product4);
            listProduct.Add(product5);
            listProduct.Add(product6);
            listProduct.Add(product7);
            listProduct.Add(product8);
            listProduct.Add(product9);
            listProduct.Add(product10);

        }

        public void generateInitialMachines()
        {

        }


        public void generateInitialCities()
        {

        }



        public void generateInitialEmployees()
        {

        }


        public void generateInitialVehicles()
        {

        }


        public void generateInitialTransactions()
        {

        }



        

    }
}
