using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendingManagement;

namespace Database_Unit_Test
{
    [TestClass]
    public class TransferManager_Unit_Test
    {
        [TestMethod]
        public void BuyStock()
        {
            // Init
            Database database = new Database();
            TransferManager transferManager = new TransferManager(database);
            
            // Action
            transferManager.buyStock("Snickers", 5, .25f);
            
            // Assert
            List<Product> listProduct = database.SelectAllProduct();
            List<Transactions> listTransactions = database.SelectAllTransactions();
            Assert.AreEqual(listProduct.Count, 5);
            Assert.AreEqual(listProduct[0].Name, "Snickers");
            Assert.AreEqual(listTransactions.Count, 1);
            Assert.AreEqual(listTransactions[0].Amount, -1.25f);
        }

        [TestMethod]
        public void TransferToMachine()
        {
            // Init
            Database database = new Database();
            TransferManager transferManager = new TransferManager(database);
            transferManager.buyStock("Snickers", 5, .25f);
            List<Product> listProduct = database.SelectAllProduct();

            Machine machine = new Machine("Milwaukee", "", "M101");

            // Action
            transferManager.TransferToMachine(machine, listProduct);


            // Assert
            int SnickerQuantity = machine.getSingleQuantity("Snickers");
            int AllQuantity = machine.getAllQuantity();
            listProduct = database.SelectAllProduct();
            List<Transactions> listTransactions = database.SelectAllTransactions();
            Assert.AreEqual(listProduct.Count, 0);
            Assert.AreEqual(SnickerQuantity, 5);
            Assert.AreEqual(AllQuantity, 5);
            Assert.AreEqual(listTransactions.Count, 3);
            Assert.AreEqual(listTransactions[2].Amount, -1.25);
        }
        [TestMethod]
        public void TransferFromMachine()
        {
            // Init
            Database database = new Database();
            TransferManager transferManager = new TransferManager(database);
            transferManager.buyStock("Snickers", 5, .25f);
            List<Product> listProduct = database.SelectAllProduct();

            Machine machine = new Machine("Milwaukee", "", "M101");
            transferManager.TransferToMachine(machine, listProduct);
            Assert.AreEqual(machine.getSingleQuantity("Snickers"), 5);


            // Action
            //Product testProduct = machine.removeMultipleProduct();


            // Assert
            int SnickerQuantity = machine.getSingleQuantity("Snickers");
            int AllQuantity = machine.getAllQuantity();
            listProduct = database.SelectAllProduct();
            List<Transactions> listTransactions = database.SelectAllTransactions();
            Assert.AreEqual(listProduct.Count, 0);
            Assert.AreEqual(SnickerQuantity, 5);
            Assert.AreEqual(AllQuantity, 5);
            Assert.AreEqual(listTransactions.Count, 3);
            Assert.AreEqual(listTransactions[2].Amount, -1.25);
        }



    }
}
