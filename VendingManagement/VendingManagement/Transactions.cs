using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    public class Transactions
    {   
        public Transactions (int id, DateTime date, string account, string productID, float amount)
        {
            this.TransactionID = id;
            this.Date = date;
            this.ProductID = productID;
            this.Amount = amount;
            this.Account = account;
        }

        //
        // Asseccors (Properties)
        //
        public int TransactionID { get; set; }
        public string Account { get; set; }
        public DateTime Date { get; set; }
        public String ProductID { get; set; }
        public float Amount { get; set; }

    }
}
