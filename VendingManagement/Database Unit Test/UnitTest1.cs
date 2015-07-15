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
        public void Append_Select_Product()
        {
            Database database = new Database();
            Product product = new Product("This is Not a Product", 2.00f);
            database.Append(product);
            List<Product> productList = database.SelectAllProduct();
            Assert.AreSame(productList[0], product);
        }

        [TestMethod]
        public void Append_Select_Transaction()
        {
            Database database = new Database();
            Transactions transaction1 = new Transactions(1, DateTime.Now, 1, "Snickers", .25f, .50f); 
            database.Append(transaction1);
            List<Transactions> TransactionList = database.SelectAllTransactions();
            Assert.AreSame(TransactionList[0], transaction1);
        }
    }
}
