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
            this.generateInitialCities();
            this.generateInitialMachines();            
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
        public List<Product> SelectProduct(string id)
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
        //public List<Machine> SelectMachine(string id)
        //{
        //    List<Machine> returnResult = new List<Machine>();
        //    foreach (Machine machine in listMachine)
        //    {
        //        if (machine.id == id)
        //        {
        //            returnResult.Add(product);
        //        }
        //    }
        //    return returnResult;
        //}
        //public List<City> SelectCity(string id)
        //{
        //    List<City> returnResult = new List<City>();
        //    foreach (City city in listCity)
        //    {
        //        if (city.Name == id)
        //        {
        //            returnResult.Add(city);
        //        }
        //    }
        //    return returnResult;
        //}




        //
        // SelectAll Matching Database Entries
        public List<Product> SelectAllProduct()
        {
            return listProduct;
        }
        public List<Machine> SelectAllMachine()
        {
            return listMachine;
        }
        public List<City> SelectAllCity()
        {
            return listCity;
        }
        public List<Employee> SelectAllEmployee()
        {
            return listEmployee;
        }
        public List<Vehicle> SelectAllVehicle()
        {
            return listVehicle;
        }
        public List<Transactions> SelectAllTransactions()
        {
            return listTransactions;
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
            Machine machine1 = new Machine("Milwaukee", "");
            Machine machine2 = new Machine("Waukesha","");
            Machine machine3 = new Machine("Brookfield", "");
            Machine machine4 = new Machine("Milwaukee", "");
            Machine machine5 = new Machine("Brookfield", "");

            machine1.MaxCapacity = 10;
            machine1.NeedRestock = false;
            machine1.NeedService = true;
            machine1.minStock = 1;
            machine1.addProduct(new Product("Snickers", .25f));
            machine1.addProduct(new Product("Snickers", .25f));
            machine1.addProduct(new Product("Snickers", .25f));
            machine1.addProduct(new Product("Mounds", .25f));
            machine1.addProduct(new Product("Mounds", .25f));
            machine1.addProduct(new Product("Mounds", .25f));
            machine1.addProduct(new Product("Snickers", .25f));
            machine1.addProduct(new Product("Snickers", .25f));

            machine2.MaxCapacity = 10;
            machine2.NeedRestock = false;
            machine2.NeedService = false;
            machine2.minStock = 1;
            machine2.addProduct(new Product("Coke", .25f));
            machine2.addProduct(new Product("Coke", .25f));
            machine2.addProduct(new Product("Sprite", .25f));
            machine2.addProduct(new Product("Sprite", .25f));
            machine2.addProduct(new Product("Dr. Pepper", .25f));
            machine2.addProduct(new Product("Dr. Pepper", .25f));
            machine2.addProduct(new Product("Fritos", .25f));
            machine2.addProduct(new Product("Fritos", .25f));

            machine3.MaxCapacity = 5;
            machine3.NeedRestock = true;
            machine3.NeedService = true;
            machine3.minStock = 1;
            machine3.addProduct(new Product("Coke", .25f));

            machine4.MaxCapacity = 10;
            machine4.NeedRestock = false;
            machine4.NeedService = false;
            machine4.minStock = 4;
            machine4.addProduct(new Product("Coke", .25f));
            machine4.addProduct(new Product("Coke", .25f));
            machine4.addProduct(new Product("Sprite", .25f));
            machine4.addProduct(new Product("Sprite", .25f));
            machine4.addProduct(new Product("Dr. Pepper", .25f));
            machine4.addProduct(new Product("Dr. Pepper", .25f));
            machine4.addProduct(new Product("Fritos", .25f));
            machine4.addProduct(new Product("Fritos", .25f));

            machine5.MaxCapacity = 20;
            machine5.NeedRestock = true;
            machine5.NeedService = true;
            machine5.minStock = 4;
            machine5.addProduct(new Product("Coke", .25f));
            machine5.addProduct(new Product("Coke", .25f));
            machine5.addProduct(new Product("Sprite", .25f));
            machine5.addProduct(new Product("Sprite", .25f));
            machine5.addProduct(new Product("Dr. Pepper", .25f));
            machine5.addProduct(new Product("Dr. Pepper", .25f));
            machine5.addProduct(new Product("Fritos", .25f));
            machine5.addProduct(new Product("Fritos", .25f));

            listMachine.Add(machine1);
            listMachine.Add(machine2);
            listMachine.Add(machine3);
            listMachine.Add(machine4);
            listMachine.Add(machine5);
        }


        public void generateInitialCities()
        {
            City city1 = new City();
            City city2 = new City();
            City city3 = new City();

            listCity.Add(city1);
            listCity.Add(city2);
            listCity.Add(city3);
        }



        public void generateInitialEmployees()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();

            listEmployee.Add(employee1);
            listEmployee.Add(employee2);
            listEmployee.Add(employee3);
            listEmployee.Add(employee4);
            listEmployee.Add(employee5);
        }


        public void generateInitialVehicles()
        {
            Vehicle vehicle1 = new Vehicle();
            Vehicle vehicle2 = new Vehicle();
            Vehicle vehicle3 = new Vehicle();
            Vehicle vehicle4 = new Vehicle();

            listVehicle.Add(vehicle1);
            listVehicle.Add(vehicle2);
            listVehicle.Add(vehicle3);
            listVehicle.Add(vehicle4);
        }


        public void generateInitialTransactions()
        {
            DateTime date = DateTime.Now.AddMinutes(-2000);
            Transactions transaction1 = new Transactions(1, date.AddMinutes(100), 1, "Snickers", .25f, .50f);
            Transactions transaction2 = new Transactions(2, date.AddMinutes(101), 1, "Mounds", .25f, .50f);
            Transactions transaction3 = new Transactions(3, date.AddMinutes(102), 1, "Snickers", .25f, .50f);
            Transactions transaction4 = new Transactions(4, date.AddMinutes(103), 2, "Snickers", .25f, .50f);
            Transactions transaction5 = new Transactions(5, date.AddMinutes(104), 3, "Snickers", .25f, .75f);
            Transactions transaction6 = new Transactions(6, date.AddMinutes(110), 2, "Coke", .35f, .50f);
            Transactions transaction7 = new Transactions(7, date.AddMinutes(114), 3, "Lays", .25f, .75f);
            Transactions transaction8 = new Transactions(8, date.AddMinutes(115), 1, "Doritos", .25f, .50f);
            Transactions transaction9 = new Transactions(9, date.AddMinutes(116), 1, "Lays", .25f, .50f);
            Transactions transaction10 = new Transactions(10, date.AddMinutes(225), 3, "Mounds", .25f, .75f);
            Transactions transaction11 = new Transactions(11, date.AddMinutes(325), 2, "Doritos", .25f, .50f);
            Transactions transaction12 = new Transactions(12, date.AddMinutes(425), 3, "Mounds", .25f, .75f);
            Transactions transaction13 = new Transactions(13, date.AddMinutes(525), 1, "Fritos", .25f, .50f);
            Transactions transaction14 = new Transactions(14, date.AddMinutes(625), 3, "Dr. Pepper", .25f, .75f);
            Transactions transaction15 = new Transactions(15, date.AddMinutes(725), 2, "Almond Joy", .25f, .50f);
            Transactions transaction16 = new Transactions(16, date.AddMinutes(825), 3, "Milky Way", .25f, .75f);
            Transactions transaction17 = new Transactions(17, date.AddMinutes(925), 1, "Mounds", .25f, .50f);
            Transactions transaction18 = new Transactions(18, date.AddMinutes(1025), 1, "Sprite", .25f, .50f);
            Transactions transaction19 = new Transactions(19, date.AddMinutes(1105), 1, "Coke", .35f, .50f);
            Transactions transaction20 = new Transactions(20, date.AddMinutes(1125), 1, "Fritos", .25f, .50f);
            Transactions transaction21 = new Transactions(21, date.AddMinutes(1135), 2, "Almond Joy", .25f, .50f);
            Transactions transaction22 = new Transactions(22, date.AddMinutes(1155), 3, "Coke", .35f, .75f);
            Transactions transaction23 = new Transactions(23, date.AddMinutes(1225), 2, "Fritos", .25f, .50f);
            Transactions transaction24 = new Transactions(24, date.AddMinutes(1227), 3, "Snickers", .25f, .75f);
            Transactions transaction25 = new Transactions(25, date.AddMinutes(1235), 3, "Lays", .25f, .75f);
            Transactions transaction26 = new Transactions(26, date.AddMinutes(1325), 2, "Coke", .35f, .50f);
            Transactions transaction27 = new Transactions(27, date.AddMinutes(1625), 1, "Dr. Pepper", .25f, .50f);
            Transactions transaction28 = new Transactions(28, date.AddMinutes(1725), 3, "Doritos", .25f, .75f);
            Transactions transaction29 = new Transactions(29, date.AddMinutes(1825), 4, "Sprite", .25f, .50f);
            Transactions transaction30 = new Transactions(30, date.AddMinutes(1925), 5, "Mounds", .25f, .75f);

            listTransactions.Add(transaction1);
            listTransactions.Add(transaction2);
            listTransactions.Add(transaction3);
            listTransactions.Add(transaction4);
            listTransactions.Add(transaction5);
            listTransactions.Add(transaction6);
            listTransactions.Add(transaction7);
            listTransactions.Add(transaction8);
            listTransactions.Add(transaction9);
            listTransactions.Add(transaction10);
            listTransactions.Add(transaction11);
            listTransactions.Add(transaction12);
            listTransactions.Add(transaction13);
            listTransactions.Add(transaction14);
            listTransactions.Add(transaction15);
            listTransactions.Add(transaction16);
            listTransactions.Add(transaction17);
            listTransactions.Add(transaction18);
            listTransactions.Add(transaction19);
            listTransactions.Add(transaction20);
            listTransactions.Add(transaction21);
            listTransactions.Add(transaction22);
            listTransactions.Add(transaction23);
            listTransactions.Add(transaction24);
            listTransactions.Add(transaction25);
            listTransactions.Add(transaction26);
            listTransactions.Add(transaction27);
            listTransactions.Add(transaction28);
            listTransactions.Add(transaction29);
            listTransactions.Add(transaction30);
        }



        

    }
}
