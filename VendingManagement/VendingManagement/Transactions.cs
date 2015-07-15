using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    public class Transactions
    {   
        public Transactions (int id, DateTime date, int machineID, string productID, float SalePrice, float WholeSalePrice)
        {
            this.TransactionID = id;
            this.Date = date;
            this.ProductID = productID;
            this.SalePrice = SalePrice;
            this.WholeSalePrice = WholeSalePrice;
            this.MachineID = machineID;
        }

        //
        // Asseccors (Properties)
        //
        public int TransactionID { get; set; }
        public int MachineID { get; set; }
        public DateTime Date { get; set; }
        public String ProductID { get; set; }
        public float SalePrice { get; set; }
        public float WholeSalePrice { get; set; }

    }
}
