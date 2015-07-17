using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingManagement;

namespace Employee_Unit_Test
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestEmployeeFullName()
        {
            Database database = new Database();
            Employee employee1 = new Employee("Jeff", "Steiner", "EIO987", "Brookfield");

            database.Append(employee1);
            
            List<Employee> EmployeeList = database.SelectAllEmployee();
            Assert.AreEqual("Jeff Steiner", EmployeeList[0].FullName);
        }

        [TestMethod]
        public void TestEmployeeDateToday()
        {
            Database database = new Database();
            Employee employee1 = new Employee("Jeff", "Steiner", "EIO987", "Brookfield");

            database.Append(employee1);

            DateTime today = DateTime.Today;

            List<Employee> EmployeeList = database.SelectAllEmployee();
            Assert.AreEqual(today, EmployeeList[0].DateStarted);
        }

        [TestMethod]
        public void TestEmployeeDateType()
        {
            Database database = new Database();
            Employee employee1 = new Employee("Jeff", "Steiner", "EIO987", "Brookfield");

            database.Append(employee1);

            DateTime today = DateTime.Today;

            List<Employee> EmployeeList = database.SelectAllEmployee();
            Assert.IsInstanceOfType(EmployeeList[0].DateStarted, typeof(DateTime));
        }





    }
}
