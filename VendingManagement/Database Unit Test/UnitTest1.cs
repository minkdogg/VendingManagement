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
        public void Append_SelectAll_Product()
        {
            Database database = new Database();
            Product product1 = new Product("This is Not a Product");
            Product product2 = new Product("This is Not a Product2");
            database.Append(product1);
            database.Append(product2);
            List<Product> productList = database.SelectAllProduct();
            Assert.AreSame(productList[0], product1);
            Assert.AreSame(productList[1], product2);
        }

        //[TestMethod]
        //public void Append_SelectAll_Machine()
        //{
        //    Database database = new Database();
        //    Product product1 = new Product("This is Not a Product");
        //    Product product2 = new Product("This is Not a Product2");
        //    database.Append(product1);
        //    database.Append(product2);
        //    List<Product> productList = database.SelectAllProduct();
        //    Assert.AreSame(productList[0], product1);
        //    Assert.AreSame(productList[1], product2);
        //}

        [TestMethod]
        public void Append_SelectAll_Transaction()
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
