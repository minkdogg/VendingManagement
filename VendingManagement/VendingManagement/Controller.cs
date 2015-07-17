using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    class Controller
    {
        Database database;
        TransferManager transferManager;

        public Controller(Database database)
        {
            this.database = database;
            this.transferManager = new TransferManager(database);
        }



        //
        // Add Objects from Form
        //
        public bool AddProduct(string name, float wholeSalePrice, int quantity)
        {
            if (name != "" & name != null)
            {
                this.transferManager.buyStock(name, quantity, wholeSalePrice);
                return true;
            }
            else
            { return false; }
        }

        public bool AddMachine(string ID, string city, string location, int maxCapacity, int minimumStock, string productType)
        {
            if (ID != "" & ID != null & 
                city != "" & city != null &
                location != "" & location != null)
            {
                Machine machine = new Machine(city, location, ID);
                machine.MaxCapacity = maxCapacity;
                machine.DefaultMinStock = minimumStock;
                this.database.Append(machine);
                return true;
            }
            else
            { return false; }
        }

        public bool AddCity(string name, string location, string ID)
        {
            if (name != "" & name != null & location != "" & location != null & ID != "" & ID != null)
            {
                City city = new City(name, location, ID);
                this.database.Append(city);
                return true;
            }
            else
            { return false; }
        }

        public bool AddEmployee(string fName, string lName, string ID, string location, string position, float payrate, DateTime dateStarted)
        {
            if (fName != "" & fName != null &
                lName != "" & lName != null &
                ID != "" & ID != null &
                location != "" & location != null &
                position != "" & position != null &
                dateStarted != null)
            {
                Employee employee = new Employee(fName, lName, ID, location);
                employee.Position = position;
                employee.Payrate = payrate;
                employee.DateStarted = dateStarted;
                this.database.Append(employee);
                return true;
            }
            else
            { return false; }

        
        }

        public bool AddVehicle(string ID, int year, string make, string model, string location, int costPerMile)
        {
            if (ID != "" & ID != null & location != "" & location != null)
            {
                Vehicle vehicle = new Vehicle(ID, location, costPerMile);
                vehicle.Year = year;
                vehicle.Make = make;
                vehicle.Model = model;
                this.database.Append(vehicle);
                return true;
            }
            else
            { return false; }
        }





        //
        // Remove Product from Form
        //
        public bool RemoveProduct(string ID)
        {
            if (ID != "" & ID != null)
            {
                List<Product> product = database.SelectProduct(ID);
                if (product.Count > 0)
                {
                    database.Remove(product[0]);
                    return true;
                }
                else
                { return false; }
            }
            else
            { return false; }
        }

        // Remove Employee from Form
        public bool RemoveEmployee(string ID)
        {
            if (ID != "" & ID != null)
            {
                List<Employee> employee = database.SelectEmployee(ID);
                if (employee.Count == 1)
                {
                    database.Remove(employee[0]);
                    return true;
                }
                else
                { return false; }
            }
            else
            { return false; }
        }

        // Remove Vehicle from Form
        public bool RemoveVehicle(string ID)
        {
            if (ID != "" & ID != null)
            {
                List<Vehicle> vehicle = database.SelectVehicle(ID);
                if (vehicle.Count == 1)
                {
                    database.Remove(vehicle[0]);
                    return true;
                }
                else
                { return false; }
            }
            else
            { return false; }
        }

        // Remove City from Form
        public bool RemoveCity(string ID)
        {
            if (ID != "" & ID != null)
            {
                List<City> city = database.SelectCity(ID);
                if (city.Count == 1)
                {
                    database.Remove(city[0]);
                    return true;
                }
                else
                { return false; }
            }
            else
            { return false; }
        }

        // Remove Machine
        public bool RemoveMachine(string ID)
        {
            if (ID != "" & ID != null)
            {
                List<Machine> machine = database.SelectMachine(ID);
                if (machine.Count == 1)
                {
                    database.Remove(machine[0]);
                    return true;
                }
                else
                { return false; }
            }
            else
            { return false; }
        }



        //
        // Transfer Methods
        // 

        // Transfer into Machine
        public bool TransferWarehouseToMachine(string ID, int quantity, Machine machine)
        {
            if (ID != "" & ID != null & machine != null)
            {
                List<Product> product = database.SelectProduct(ID);
                if (quantity <= product.Count)
                {
                    List<Product> transferList = new List<Product>();
                    for (int i = 0; i < quantity; ++i)
                    {
                        transferList.Add(product[i]);
                    }
                    this.transferManager.TransferToMachine(machine, transferList);
                    return true;
                }
                else
                { return false; }
            }
            else
            { return false; }
        }

        // Trasfer out of Machine
        public bool TransferMachineToWarehouse(string ID, int quantity, Machine machine)
        {
            if (ID != "" & ID != null & machine != null)
            {
                List<Product> product = machine.selectAllProductByType(ID);
                if (quantity <= product.Count)
                {
                    List<Product> transferList = new List<Product>();
                    for (int i = 0; i < quantity; ++i)
                    {
                        transferList.Add(product[i]);
                    }
                    this.transferManager.TransferFromMachine(machine, transferList);
                    return true;
                }
                else
                { return false; }
            }
            else
            { return false; }
        }


        // Machine Sale
        public bool machineSale(Machine machine, string ID)
        {
            if (machine != null & ID != "" & ID != null)
            {
                List<Product> product = machine.selectAllProductByType(ID);
                if (product.Count > 0)
                {
                    this.transferManager.machineSale(machine, product[0]);
                    return true;
                }
                else
                { return false; }
            }
            else 
            { return false; }            
        }      
    }
}
