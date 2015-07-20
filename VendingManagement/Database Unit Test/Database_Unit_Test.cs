using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingManagement;

namespace Database_Unit_Test
{
    [TestClass]
    public class Database_Unit_Test
    {
        [TestMethod]
        public void Append_SelectAll_Product_UnitTest()
        {
            Database database = new Database();
            Product product1 = new Product("This is Not a Product", .25f);
            Product product2 = new Product("This is Not a Product2", .25f);
            database.Append(product1);
            database.Append(product2);
            List<Product> productList = database.SelectAllProduct();
            Assert.AreSame(productList[0], product1);
            Assert.AreSame(productList[1], product2);
        }

        [TestMethod]
        public void Append_SelectAll_Machine_UnitTest()
        {
            Database database = new Database();
            Product product1 = new Product("This is Not a Product", .25f);
            Product product2 = new Product("This is Not a Product2", .25f);
            database.Append(product1);
            database.Append(product2);
            List<Product> productList = database.SelectAllProduct();
            Assert.AreSame(productList[0], product1);
            Assert.AreSame(productList[1], product2);
            Assert.AreEqual(productList[0].WholeSalePrice, .25f);
        }

        [TestMethod]
        public void Append_SelectAll_City_UnitTest()
        {
            Database database = new Database();
            City city1 = new City("Milwaukee", "WI", "MKE-WI");
            City city2 = new City("Waukesha", "WI", "WAU-WI");
            database.Append(city1);
            database.Append(city2);
            List<City> cityList = database.SelectAllCity();
            Assert.AreSame(cityList[0], city1);
            Assert.AreSame(cityList[1], city2);
            Assert.AreEqual(cityList[0].ID, "MKE-WI");
        }

        [TestMethod]
        public void Append_SelectAll_Employee_UnitTest()
        {
            Database database = new Database();
            Employee employee1 = new Employee("Bob", "Hope", "E1001", "Milwaukee");
            Employee employee2 = new Employee("Joe", "Schmoe", "E1002", "Waukesha");
            database.Append(employee1);
            database.Append(employee2);
            List<Employee> EmployeeList = database.SelectAllEmployee();
            Assert.AreSame(EmployeeList[0], employee1);
            Assert.AreSame(EmployeeList[1], employee2);
            Assert.AreEqual(EmployeeList[0].EmployeeID, "E1001");
        }

        [TestMethod]
        public void Append_SelectAll_Vehicle_UnitTest()
        {
            Database database = new Database();
            Vehicle vehicle1 = new Vehicle("Truck1", "Milwaukee", 1);
            Vehicle vehicle2 = new Vehicle("Truck2", "Milwaukee", 1);
            database.Append(vehicle1);
            database.Append(vehicle2);
            List<Vehicle> vehicleList = database.SelectAllVehicle();
            Assert.AreSame(vehicleList[0], vehicle1);
            Assert.AreSame(vehicleList[1], vehicle2);
            Assert.AreEqual(vehicleList[0].VehicleID, "Truck1");
        }

        [TestMethod]
        public void Append_SelectAll_Transaction_UnitTest()
        {
            Database database = new Database();
            Transactions transaction1 = new Transactions(1, DateTime.Now, "Checking", "Snickers", .50f);
            Transactions transaction2 = new Transactions(2, DateTime.Now, "Checking", "Snickers", .50f);
            database.Append(transaction1);
            database.Append(transaction2);
            List<Transactions> TransactionList = database.SelectAllTransactions();
            Assert.AreSame(TransactionList[0], transaction1);
            Assert.AreSame(TransactionList[1], transaction2);
        }


    }
}
