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
        public void BuyStock_UnitTest()
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
        public void TransferToMachine_UnitTest()
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
        public void TransferFromMachine_UnitTest()
        {
            // Init
            Database database = new Database();
            TransferManager transferManager = new TransferManager(database);
            transferManager.buyStock("Snickers", 5, .25f);
            List<Product> listProduct = database.SelectAllProduct();

            Machine machine = new Machine("Milwaukee", "", "M101");
            database.Append(machine);
            transferManager.TransferToMachine(machine, listProduct);
            Assert.AreEqual(machine.getSingleQuantity("Snickers"), 5);
            List<Product> transferList = machine.selectAllProductByType("Snickers");

            // Action
            transferManager.TransferFromMachine(machine, transferList);

            // Assert
            Assert.AreEqual(database.SelectAllProduct().Count, 5);
            Assert.AreEqual(machine.getSingleQuantity("Snickers"), 0);


            List<Transactions> listTransactions = database.SelectAllTransactions();
            Assert.AreEqual(listTransactions.Count, 5);
            Assert.AreEqual(listTransactions[4].Amount, 1.25f);
        }


        [TestMethod]
        public void MachineSale_UnitTest()
        {
            // Init
            Database database = new Database();
            TransferManager transferManager = new TransferManager(database);
            Machine machine = new Machine("Milwaukee", "The Mall", "M101");
            database.Append(machine);
            transferManager.buyStock("Snickers", 5, .25f);
            List<Product> listProduct = database.SelectAllProduct();
            transferManager.TransferToMachine(machine, listProduct);
            List<Product> listProductBefore = machine.selectAllProductByType("Snickers");
            int startingCount = listProductBefore.Count;

            // Action
            transferManager.machineSale(machine, listProductBefore[0]);

            // Assert
            List<Product> listProductAfter = machine.selectAllProductByType("Snickers");
            List<Transactions> listTransactionsAfter = database.SelectAllTransactions();
            int endingCount = listProductAfter.Count;
            int transactionCount = listTransactionsAfter.Count;
            Assert.AreEqual(startingCount - 1, endingCount);
            Assert.AreEqual(5, transactionCount);
            
        }

    }
}
