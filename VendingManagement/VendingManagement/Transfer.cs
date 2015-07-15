using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    public class TransferManager
    {
        public void TransferToMachine(Machine machine, Product product, Database database)
        {
            // Find Largest Transaction ID number
            List<Transactions> tempTransactionList = database.SelectAllTransactions();
            int transactionID = 0;
            foreach (Transactions transaction in tempTransactionList)
            {
                if (transaction.TransactionID > transactionID)
                {
                    transactionID = transaction.TransactionID;
                }
            }

            transactionID++;
            machine.addProduct(product);
            database.Append(new Transactions(transactionID, DateTime.Now, "Checking", product.Name, product.WholeSalePrice));
            database.Append(new Transactions((transactionID + 1), DateTime.Now, machine.MachineID, product.Name, -product.WholeSalePrice));
            database.Remove(product);
        }
    }
}
