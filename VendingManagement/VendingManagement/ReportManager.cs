using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace VendingManagement
{
    class ReportManager
    {
        public DataTable reportSalesByItem(List<Transactions> data)
        {

            DataTable table = new DataTable();
            DataColumn newColumn = new DataColumn("Product type", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Net Profit", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Total Sales", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Number of Sales", typeof(String));
            table.Columns.Add(newColumn);
            
            List<Transactions> sortedList = data.OrderBy(d => d.ProductID).ToList();
            var subtotals = from x in sortedList
                            group x by x.ProductID into g
                            select new { Type = g.Key, SubTotal = g.Sum(x => x.Amount), SalesTotal = g.Where(x => x.Amount > 0).Select(x => x.Amount).Sum(), SalesCount = g.Where(x => x.Amount > 0).Count() };
            
            foreach (var total in subtotals)
            {
                if (total.Type != "")
                {
                    table.Rows.Add(total.Type,total.SubTotal, total.SalesTotal, total.SalesCount);  
                } 
            }

            return table;

        }

        public DataTable reportInventoryCostItem(List<Product> data)
        {

            //List<List<string>> newData = new List<List<string>>();
            //List<string> productNames = new List<string>();
            DataTable table = new DataTable();
            DataColumn newColumn = new DataColumn("Product Type", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Cost In Inventory", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Number of Items", typeof(String));
            table.Columns.Add(newColumn);

            List<Product> sortedList = data.OrderBy(d => d.Name).ToList();
            var subtotals = from x in sortedList
                            group x by x.name into g
                            select new { Type = g.Key, SubTotal = g.Sum(x => x.WholeSalePrice), Count = g.Count() };

            foreach (var total in subtotals)
            {
                DataRow newRow = table.NewRow();
                newRow["Product Type"] = total.Type;
                newRow["Cost In Inventory"] = total.SubTotal;
                newRow["Number of Items"] = total.Count;
                table.Rows.Add(newRow);
            }

            return table;

        }

        public DataTable reportSalesByMachine(List<Transactions> data)
        {

            DataTable table = new DataTable();
            DataColumn newColumn = new DataColumn("Machine ID", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Location", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Total Sales", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Number of Sales", typeof(String));
            table.Columns.Add(newColumn);

            List<Transactions> sortedList = data.OrderBy(d => d.Account).ToList();
            var subtotals = from x in sortedList
                            group x by x.Account into g
                            select new { Type = g.Key, SubTotal = g.Sum(x => x.Amount), SalesTotal = g.Where(x => x.Amount > 0).Select(x => x.Amount).Sum(), SalesCount = g.Where(x => x.Amount > 0).Count() };

            foreach (var total in subtotals)
            {
                if (total.Type != "")
                {
                    table.Rows.Add(total.Type, total.SubTotal, total.SalesTotal, total.SalesCount);
                }
            }

            return table;

        }



    }
}
