using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingManagement;

namespace Machine_Unit_Test
{
    [TestClass]
    public class MachineTest
    {
        [TestMethod]
        public void MachineTestObjectAdded()
        {
            Database database = new Database();
            Machine machine1 = new Machine("Hartford", "Downtown", "M100");
            

            database.Append(machine1);

            List<Machine> MachineList = database.SelectAllMachine();

            Assert.AreEqual(machine1, MachineList[0]);
        }

        [TestMethod]
        public void MachineNeedRestockInitial()
        {
            Database database = new Database();
            Machine machine1 = new Machine("Hartford", "Downtown", "M100");


            database.Append(machine1);

            List<Machine> MachineList = database.SelectAllMachine();

            Assert.AreEqual(true, MachineList[0].NeedRestock);
        }

        [TestMethod]
        public void MachineCheckProductSingleQuantity()
        {
            Database database = new Database();
            Machine machine1 = new Machine("Hartford", "Downtown", "M100");

            Product product1 = new Product("coke", .75f);
            Product product2 = new Product("snickers", .75f);

            machine1.addProduct(product1);
            machine1.addProduct(product2);

            database.Append(machine1);

            List<Machine> MachineList = database.SelectAllMachine();
            
            Assert.AreEqual(1, MachineList[0].getSingleQuantity("coke"));
        }

        [TestMethod]
        public void MachineCheckProductTypeNames()
        {
            Database database = new Database();
            Machine machine1 = new Machine("Hartford", "Downtown", "M100");

            Product product1 = new Product("coke", .75f);
            Product product2 = new Product("snickers", .75f);

            machine1.addProduct(product1);
            machine1.addProduct(product2);
            List<string> expected = new List<string> { "coke", "snickers" };


            database.Append(machine1);

            List<Machine> MachineList = database.SelectAllMachine();

            CollectionAssert.AreEqual(expected, MachineList[0].getProductNames());
        }

        [TestMethod]
        public void MachineUpdateRetailPrice()
        {
            Database database = new Database();
            Machine machine1 = new Machine("Hartford", "Downtown", "M100");

            Product product1 = new Product("coke", .75f);
            Product product2 = new Product("snickers", .75f);

            machine1.addProduct(product1);
            machine1.addProduct(product2);
            machine1.updateRetailPrice("coke", 2.00f);
            float expected = 2.00f;


            database.Append(machine1);

            List<Machine> MachineList = database.SelectAllMachine();

            Assert.AreEqual(expected, product1.RetailPrice);
        }








    }
}
