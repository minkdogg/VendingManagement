using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    public class Database
    {
        protected Business business = new Business(); // Our company
        protected List<Product> listProduct = new List<Product>(); // equivalent to our bulk warehouse
        protected List<Machine> listMachine = new List<Machine>(); // equivalent to all our machines (incuding thier own inventory)
        protected List<City> listCity = new List<City>();
        protected List<Employee> listEmployee = new  List<Employee>();
        protected List<Vehicle> listVehicle = new List<Vehicle>();
        protected List<Transactions> listTransactions = new List<Transactions>();

        

        public void generateInitialData()
        {
            Transactions startupCash = new Transactions(0, DateTime.Now.AddMinutes(-3000), "Checking", "", 1000);
            this.Append(startupCash);
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
        public List<Machine> SelectMachine(string id)
        {
            List<Machine> returnResult = new List<Machine>();
            foreach (Machine machine in listMachine)
            {
                if (machine.MachineID == id)
                {
                    returnResult.Add(machine);
                }
            }
            return returnResult;
        }
        public List<City> SelectCity(string id)
        {
            List<City> returnResult = new List<City>();
            foreach (City city in listCity)
            {
                if (city.Name == id)
                {
                    returnResult.Add(city);
                }
            }
            return returnResult;
        }
        public List<Employee> SelectEmployee(string id)
        {
            List<Employee> returnResult = new List<Employee>();
            foreach (Employee employee in listEmployee)
            {
                if (employee.EmployeeID == id)
                {
                    returnResult.Add(employee);
                }
            }
            return returnResult;
        }
        public List<Vehicle> SelectVehicle(string id)
        {
            List<Vehicle> returnResult = new List<Vehicle>();
            foreach (Vehicle vehicle in listVehicle)
            {
                if (vehicle.VehicleID == id)
                {
                    returnResult.Add(vehicle);
                }
            }
            return returnResult;
        }
        public List<Transactions> SelectTransactions(int id)
        {
            List<Transactions> returnResult = new List<Transactions>();
            foreach (Transactions transaction in listTransactions)
            {
                if (transaction.TransactionID == id)
                {
                    returnResult.Add(transaction);
                }
            }
            return returnResult;
        }



        //
        // SelectAll Matching Database Entries
        //
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
            int transactionID = 1;
            for (int i = 0; i < 50; i++)
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

                Transactions transaction1 = new Transactions(++transactionID, DateTime.Now.AddMinutes(-2900), "Checking", "Snickers", -.25f);
                Transactions transaction2 = new Transactions(++transactionID, DateTime.Now.AddMinutes(-2900), "Checking", "Milky Way", -.25f);
                Transactions transaction3 = new Transactions(++transactionID, DateTime.Now.AddMinutes(-2900), "Checking", "Mounds", -.25f);
                Transactions transaction4 = new Transactions(++transactionID, DateTime.Now.AddMinutes(-2900), "Checking", "Almond Joy", -.25f);
                Transactions transaction5 = new Transactions(++transactionID, DateTime.Now.AddMinutes(-2900), "Checking", "Coke", -.25f);
                Transactions transaction6 = new Transactions(++transactionID, DateTime.Now.AddMinutes(-2900), "Checking", "Sprite", -.25f);
                Transactions transaction7 = new Transactions(++transactionID, DateTime.Now.AddMinutes(-2900), "Checking", "Dr. Pepper", -.25f);
                Transactions transaction8 = new Transactions(++transactionID, DateTime.Now.AddMinutes(-2900), "Checking", "Doritos", -.25f);
                Transactions transaction9 = new Transactions(++transactionID, DateTime.Now.AddMinutes(-2900), "Checking", "Fritos", -.25f);
                Transactions transaction10 = new Transactions(++transactionID, DateTime.Now.AddMinutes(-2900), "Checking", "Lays", -.25f);

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
            }
        }

        public void generateInitialMachines()
        {
            Machine machine1 = new Machine("Milwaukee", "Mayfair Mall", "M101");
            machine1.MaxCapacity = 100;
            business.Accounts.Add("M101");
            Machine machine2 = new Machine("Waukesha", "Downtown", "M102");
            machine2.MaxCapacity = 100;
            business.Accounts.Add("M102");
            Machine machine3 = new Machine("Brookfield", "Brookfield Square", "M103");
            machine3.MaxCapacity = 100;
            business.Accounts.Add("M103");
            Machine machine4 = new Machine("Milwaukee", "Downtown", "M104");
            machine4.MaxCapacity = 100;
            business.Accounts.Add("M104");
            Machine machine5 = new Machine("Brookfield", "Brookfield Square", "M105");
            machine5.MaxCapacity = 100;
            business.Accounts.Add("M105");

            // Pull inventory of warehouse
            List<Product> transferList = this.SelectAllProduct();
            TransferManager transferManager = new TransferManager(this);
            int index = 0;

            // Create Machines and transfer product into machine
            machine1.MaxCapacity = 10;
            //machine1.NeedRestock = false;
            //machine1.NeedService = true;
            machine1.DefaultMinStock = 1;

            transferManager.TransferToMachine(machine1, transferList[++index]);
            transferManager.TransferToMachine(machine1, transferList[++index]);
            transferManager.TransferToMachine(machine1, transferList[++index]);
            transferManager.TransferToMachine(machine1, transferList[++index]);
            transferManager.TransferToMachine(machine1, transferList[++index]);
            transferManager.TransferToMachine(machine1, transferList[++index]);
            transferManager.TransferToMachine(machine1, transferList[++index]);
            transferManager.TransferToMachine(machine1, transferList[++index]);
            transferManager.TransferToMachine(machine1, transferList[++index]);



            machine3.MaxCapacity = 5;
            //machine3.NeedRestock = true;
            //machine3.NeedService = true;
            machine3.DefaultMinStock = 1;
            transferManager.TransferToMachine(machine3, transferList[++index]);
            transferManager.TransferToMachine(machine3, transferList[++index]);

            machine4.MaxCapacity = 10;
            //machine4.NeedRestock = false;
            //machine4.NeedService = false;
            machine4.DefaultMinStock = 2;
            transferManager.TransferToMachine(machine4, transferList[++index]);
            transferManager.TransferToMachine(machine4, transferList[++index]);
            transferManager.TransferToMachine(machine4, transferList[++index]);
            transferManager.TransferToMachine(machine4, transferList[++index]);
            transferManager.TransferToMachine(machine4, transferList[++index]);
            transferManager.TransferToMachine(machine4, transferList[++index]);
            transferManager.TransferToMachine(machine4, transferList[++index]);
            transferManager.TransferToMachine(machine4, transferList[++index]);

            machine5.MaxCapacity = 20;
            //machine5.NeedRestock = true;
            //machine5.NeedService = true;
            machine5.DefaultMinStock = 2;
            transferManager.TransferToMachine(machine5, transferList[++index]);
            transferManager.TransferToMachine(machine5, transferList[++index]);
            transferManager.TransferToMachine(machine5, transferList[++index]);
            transferManager.TransferToMachine(machine5, transferList[++index]);
            transferManager.TransferToMachine(machine5, transferList[++index]);
            transferManager.TransferToMachine(machine5, transferList[++index]);
            transferManager.TransferToMachine(machine5, transferList[++index]);
            transferManager.TransferToMachine(machine5, transferList[++index]);
            transferManager.TransferToMachine(machine5, transferList[++index]);

            listMachine.Add(machine1);
            listMachine.Add(machine2);
            listMachine.Add(machine3);
            listMachine.Add(machine4);
            listMachine.Add(machine5);
        }


        public void generateInitialCities()
        {
            City city1 = new City("Milwaukee", "Wisconsin", "MKE");
            City city2 = new City("Brookfield", "Wisconsin", "BKFD");
            City city3 = new City("Waukesha", "Wisconsin", "WAUK");

            listCity.Add(city1);
            listCity.Add(city2);
            listCity.Add(city3);
        }



        public void generateInitialEmployees()
        {
            Employee employee1 = new Employee("Joe", "Schmoe", "E001","Milwaukee");
            Employee employee2 = new Employee("Joe", "Smith", "E002", "Milwaukee");
            Employee employee3 = new Employee("Jill", "Johnson", "E003", "Waukesha");
            Employee employee4 = new Employee("Bob", "Hope", "E004", "Milwaukee");
            Employee employee5 = new Employee("Jane", "Hope", "E005", "Brookfield");

            listEmployee.Add(employee1);
            listEmployee.Add(employee2);
            listEmployee.Add(employee3);
            listEmployee.Add(employee4);
            listEmployee.Add(employee5);
        }


        public void generateInitialVehicles()
        {
            Vehicle vehicle1 = new Vehicle("Truck1", "Milwaukee", 1);
            Vehicle vehicle2 = new Vehicle("Truck2", "Waukesha", 1);
            Vehicle vehicle3 = new Vehicle("Truck3", "Brookfield", 1);
            Vehicle vehicle4 = new Vehicle("Truck4", "Milwaukee", 1);

            listVehicle.Add(vehicle1);
            listVehicle.Add(vehicle2);
            listVehicle.Add(vehicle3);
            listVehicle.Add(vehicle4);
        }


        public void generateInitialTransactions()
        {
            // These are specifically Sales Transactions, the original business transactions are added in the creation of the machines
            DateTime date = DateTime.Now.AddMinutes(-2000);
            Transactions transaction1 = new Transactions(1, date.AddMinutes(100), "M101", "Snickers", .50f);
            Transactions transaction2 = new Transactions(2, date.AddMinutes(101), "M101", "Mounds", .50f);
            Transactions transaction3 = new Transactions(3, date.AddMinutes(102), "M101", "Snickers", .50f);
            Transactions transaction4 = new Transactions(4, date.AddMinutes(103), "M102", "Snickers", .50f);
            Transactions transaction5 = new Transactions(5, date.AddMinutes(104), "M103", "Snickers", .75f);
            Transactions transaction6 = new Transactions(6, date.AddMinutes(110), "M102", "Coke", .50f);
            Transactions transaction7 = new Transactions(7, date.AddMinutes(114), "M103", "Lays", .75f);
            Transactions transaction8 = new Transactions(8, date.AddMinutes(115), "M101", "Doritos", .50f);
            Transactions transaction9 = new Transactions(9, date.AddMinutes(116), "M101", "Lays", .50f);
            Transactions transaction10 = new Transactions(10, date.AddMinutes(225), "M103", "Mounds", .75f);
            Transactions transaction11 = new Transactions(11, date.AddMinutes(325), "M102", "Doritos", .50f);
            Transactions transaction12 = new Transactions(12, date.AddMinutes(425), "M103", "Mounds",  .75f);
            Transactions transaction13 = new Transactions(13, date.AddMinutes(525), "M101", "Fritos", .50f);
            Transactions transaction14 = new Transactions(14, date.AddMinutes(625), "M103", "Dr. Pepper", .75f);
            Transactions transaction15 = new Transactions(15, date.AddMinutes(725), "M102", "Almond Joy", .50f);
            Transactions transaction16 = new Transactions(16, date.AddMinutes(825), "M103", "Milky Way", .75f);
            Transactions transaction17 = new Transactions(17, date.AddMinutes(925), "M101", "Mounds", .50f);
            Transactions transaction18 = new Transactions(18, date.AddMinutes(1025), "M101", "Sprite", .50f);
            Transactions transaction19 = new Transactions(19, date.AddMinutes(1105), "M101", "Coke", .50f);
            Transactions transaction20 = new Transactions(20, date.AddMinutes(1125), "M101", "Fritos", .50f);
            Transactions transaction21 = new Transactions(21, date.AddMinutes(1135), "M102", "Almond Joy", .50f);
            Transactions transaction22 = new Transactions(22, date.AddMinutes(1155), "M103", "Coke",.75f);
            Transactions transaction23 = new Transactions(23, date.AddMinutes(1225), "M102", "Fritos", .50f);
            Transactions transaction24 = new Transactions(24, date.AddMinutes(1227), "M103", "Snickers", .75f);
            Transactions transaction25 = new Transactions(25, date.AddMinutes(1235), "M103", "Lays", .75f);
            Transactions transaction26 = new Transactions(26, date.AddMinutes(1325), "M102", "Coke", .50f);
            Transactions transaction27 = new Transactions(27, date.AddMinutes(1625), "M101", "Dr. Pepper",  .50f);
            Transactions transaction28 = new Transactions(28, date.AddMinutes(1725), "M103", "Doritos", .75f);
            Transactions transaction29 = new Transactions(29, date.AddMinutes(1825), "M103", "Sprite", .50f);
            Transactions transaction30 = new Transactions(30, date.AddMinutes(1925), "M103", "Mounds", .75f);

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
