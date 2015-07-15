using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    public class TransferManager
    {
        Database database;

        public TransferManager (Database database)
        {
            this.database = database;
        }


        //
        //Transfer product in bulk into machine
        //
        public void TransferToMachine(Machine machine, List<Product> productList)
        {
            int transactionID = this.newTransactionID();
            float totalCost = 0;
            string productName = productList[0].Name;
            foreach (Product product in productList)
            {
                totalCost += product.WholeSalePrice;
                machine.addProduct(product);
                this.database.Remove(product);
            }
            this.database.Append(new Transactions(transactionID, DateTime.Now, "Checking", productName, totalCost));
            this.database.Append(new Transactions((transactionID + 1), DateTime.Now, machine.MachineID, productName, -totalCost));
            
        }
        //Overload TransferIn method for single item
        public void TransferToMachine(Machine machine, Product product)
        {
            List<Product> productList = new List<Product>();
            productList.Add(product);
            this.TransferToMachine(machine, productList);
        }


        //
        // Transfer product in bulk out of Machine
        //
        public void TransferFromMachine(Machine machine, List<Product> productList)
        {
            int transactionID = this.newTransactionID();
            float totalCost = 0;
            string productName = productList[0].Name;
            foreach (Product product in productList)
            {
                totalCost += product.WholeSalePrice;
                this.database.Append(product);
                machine.removeProduct(product);
            }
            this.database.Append(new Transactions(transactionID, DateTime.Now, "Checking", productName, -totalCost));
            this.database.Append(new Transactions((transactionID + 1), DateTime.Now, machine.MachineID, productName, +totalCost));
        }
        //Overload TransferOut method for single item
        public void TransferFromMachine(Machine machine, Product product)
        {
            List<Product> productList = new List<Product>();
            productList.Add(product);
            this.TransferFromMachine(machine, productList);
        }



        //
        // Find Next Largest available ID in the database
        //
        protected int newTransactionID()
        {
            // Find Largest Transaction ID number
            List<Transactions> tempTransactionList = this.database.SelectAllTransactions();
            int transactionID = 0;
            foreach (Transactions transaction in tempTransactionList)
            {
                if (transaction.TransactionID > transactionID)
                {
                    transactionID = transaction.TransactionID;
                }
            }
            transactionID++;
            return transactionID;
        }

        public void buyStock(string name, int quantity, float price)
        {
            for (int i = 0; i < quantity; ++i)
            {
                this.database.Append(new Product(name, price));
            }
            int transactionID = this.newTransactionID();
            this.database.Append(new Transactions(transactionID, DateTime.Now, "Checking", name, -(price*quantity)));
        }
    }
}
