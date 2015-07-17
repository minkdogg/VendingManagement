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

        public DataTable reportProductWarehouse(List<Product>data)
        {
            DataTable table = new DataTable();
            DataColumn newColumn = new DataColumn("Product Type", typeof(String));
            table.Columns.Add(newColumn);


            newColumn = new DataColumn("Number of Items", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Wholesale Cost", typeof(String));
            table.Columns.Add(newColumn);

            List<Product> sortedList = data.OrderBy(d => d.Name).ToList();
            var subtotals = from x in sortedList
                            group x by x.name into g
                            select new { Type = g.Key, Count = g.Count(), Price = g.Sum(x => x.WholeSalePrice) };

            foreach (var total in subtotals)
            {
                DataRow newRow = table.NewRow();
                decimal newTotal = Convert.ToDecimal(total.Price);
                string stringTotal = String.Format("{0:C}", newTotal);
                newRow["Product Type"] = total.Type;
                newRow["Number of Items"] = total.Count;
                newRow["Wholesale Cost"] = stringTotal; 
                table.Rows.Add(newRow);
            }

            return table;
            
        }
        
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
                decimal newTotal = Convert.ToDecimal(total.SubTotal);
                string stringTotal = String.Format("{0:C}", newTotal);
                newRow["Product Type"] = total.Type;
                newRow["Cost In Inventory"] = stringTotal;
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

            newColumn = new DataColumn("Total Sales", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Number of Sales", typeof(String));
            table.Columns.Add(newColumn);

            List<Transactions> sortedList = data.OrderBy(d => d.Account).ToList();
            var subtotals = from x in sortedList
                            group x by x.Account into g
                            select new { Type = g.Key, SalesTotal = g.Where(x => x.Amount > 0).Select(x => x.Amount).Sum(), SalesCount = g.Where(x => x.Amount > 0).Count() };

            foreach (var total in subtotals)
            {
                if (total.Type != "Checking")
                {
                    table.Rows.Add(total.Type, total.SalesTotal, total.SalesCount);
                }
            }
            return table;
        }

        public DataTable reportSalesByProductPerMachine(List<Transactions> data, List<Machine> machines)
        {

            DataTable table = new DataTable();
            DataColumn newColumn = new DataColumn("Machine ID", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Product Type", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Sales Total", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Sales Count", typeof(String));
            table.Columns.Add(newColumn);


            foreach(Machine machine in machines)
            {
                table.Rows.Add(machine.MachineID, "", "");
                List<Transactions> sortedList = data.OrderBy(d => d.ProductID).ToList();
                var subtotals = from x in sortedList
                                group x by x.ProductID into g
                                select new { Type = g.Key, SalesTotal = g.Where(x => x.Amount > 0 && x.Account == machine.MachineID).Select(x => x.Amount).Sum(), SalesCount = g.Where(x => x.Amount > 0 && x.Account == machine.MachineID).Count() };
                float salesTotalAmount = 0;
                int salesTotalCount = 0;
                foreach (var total in subtotals)
                {
                    if (total.Type != "")
                    {
                        table.Rows.Add("",total.Type, total.SalesTotal, total.SalesCount);
                    }
                    salesTotalAmount += total.SalesTotal;
                    salesTotalCount += total.SalesCount;
                }
                table.Rows.Add("Total", "", salesTotalAmount, salesTotalCount);
                table.Rows.Add("", "", "","");
            }

            return table;
        }

        public DataTable reportSalesByCity(List<Transactions> data, List<Machine> machines, List<City> cities)
        {

            DataTable table = new DataTable();
            DataColumn newColumn = new DataColumn("City", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Machine ID", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Sales Total", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Sales Count", typeof(String));
            table.Columns.Add(newColumn);


            foreach (City city in cities)
            {
                table.Rows.Add(city.Name);
                List<string> cityMachineList = new List<string> {};
                foreach(Machine machine in machines)
                {
                    if (machine.City == city.Name)
                    {
                        cityMachineList.Add(machine.MachineID);
                        
                    }
                }

                float salesTotalAmount = 0;
                int salesTotalCount = 0;
                foreach (string machine in cityMachineList)
                {
                    
                    List<Transactions> sortedList = data.OrderBy(d => d.ProductID).ToList();
                    var filteredItems = sortedList.Where(p => p.Account == machine);
                    
                    if(filteredItems.Count() == 0)
                    {
                        table.Rows.Add("", machine, 0, 0);
                    }

                    var subtotals = from x in filteredItems
                                    group x by x.Account into g
                                    select new { Type = g.Key, SalesTotal = g.Where(x => x.Amount >= 0 && x.Account == machine).Select(x => x.Amount).Sum(), SalesCount = g.Where(x => x.Amount >= 0 && x.Account == machine).Count() };
                    
                    foreach (var total in subtotals)
                    {
                        if (total.Type != "Checking")
                        {
                            table.Rows.Add("", total.Type, total.SalesTotal, total.SalesCount);
                        }
                        salesTotalAmount += total.SalesTotal;
                        salesTotalCount += total.SalesCount;
                    }
                    
                }
                table.Rows.Add("Total", "", salesTotalAmount, salesTotalCount);
                table.Rows.Add("", "", "", "");

            }

            return table;
        }


        public DataTable reportProductByMachine(List<Machine> machines)
        {

            DataTable table = new DataTable();
            DataColumn newColumn = new DataColumn("Machine ID", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Product Type", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Product Count", typeof(String));
            table.Columns.Add(newColumn);


            foreach (Machine machine in machines)
            {
                table.Rows.Add(machine.MachineID, "", "");
                List<Product> machineProducts = machine.products;
                List<Product> sortedList = machineProducts.OrderBy(d => d.Name).ToList();
                var subtotals = from x in sortedList
                                group x by x.Name into g
                                select new { Type = g.Key, SalesCount = g.Count() };
                foreach (var total in subtotals)
                {
                  
                        table.Rows.Add("", total.Type, total.SalesCount);
                }
                
                table.Rows.Add("", "", "");
            }

            return table;
        }


        public DataTable reportRevenueByCity(List<Transactions> data, List<Machine> machines, List<City> cities)
        {

            DataTable table = new DataTable();
            DataColumn newColumn = new DataColumn("City", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Sales Profit", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Sales Total", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Sales Count", typeof(String));
            table.Columns.Add(newColumn);




            foreach (City city in cities)
            {
                table.Rows.Add(city.Name);
                List<string> cityMachineList = new List<string> { };
                foreach (Machine machine in machines)
                {
                    if (machine.City == city.Name)
                    {
                        cityMachineList.Add(machine.MachineID);

                    }
                }

                float salesTotalProfit = 0;
                float salesTotalAmount = 0;
                int salesTotalCount = 0;
                foreach (string machine in cityMachineList)
                {

                    List<Transactions> sortedList = data.OrderBy(d => d.ProductID).ToList();
                    var filteredItems = sortedList.Where(p => p.Account == machine);

                    var subtotals = from x in filteredItems
                                    group x by x.Account into g
                                    select new { Type = g.Key, SalesProfit = g.Where(x => x.Account == machine).Select(x => x.Amount).Sum(), SalesTotal = g.Where(x => x.Amount >= 0 && x.Account == machine).Select(x => x.Amount).Sum(), SalesCount = g.Where(x => x.Amount >= 0 && x.Account == machine).Count() };

                    foreach (var total in subtotals)
                    {
                        if (total.Type != "Checking")
                        {
                            table.Rows.Add("", total.SalesProfit, total.SalesTotal, total.SalesCount);
                        }
                        salesTotalProfit += total.SalesProfit;
                        salesTotalAmount += total.SalesTotal;
                        salesTotalCount += total.SalesCount;
                    }

                }
                table.Rows.Add("Total", salesTotalProfit, salesTotalAmount, salesTotalCount);
                table.Rows.Add("", "", "", "");

            }

            return table;
        }

       public DataTable reportSalesByCityAndItem(List<Transactions> data, List<City> cities, List<Machine> machines)
        {

            DataTable table = new DataTable();
            DataColumn newColumn = new DataColumn("City", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Sales Item", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Sales Total", typeof(String));
            table.Columns.Add(newColumn);

            newColumn = new DataColumn("Sales Count", typeof(String));
            table.Columns.Add(newColumn);


            foreach (City city in cities)
            {
                
                table.Rows.Add(city.Name);
                List<string> cityMachineList = new List<string> { };
                foreach (Machine machine in machines)
                {
                    if (machine.City == city.Name)
                    {
                        cityMachineList.Add(machine.MachineID);

                    }
                }
                float salesTotalAmount = 0;
                int salesTotalCount = 0;
                foreach (string machine in cityMachineList)
                {
                    List<Transactions> sortedList = data.OrderBy(d => d.ProductID).ToList();
                    var filteredItems = sortedList.Where(p => p.Account == machine);
                    var subtotals = from x in filteredItems
                                    group x by x.ProductID into g
                                    select new { Type = g.Key, SalesTotal = g.Where(x => x.Amount >= 0).Select(x => x.Amount).Sum(), SalesCount = g.Where(x => x.Amount >= 0).Count() };

                    foreach (var total in subtotals)
                    {
                        if (total.Type != "" && total.SalesTotal != 0)
                        {
                            table.Rows.Add("", total.Type, total.SalesTotal, total.SalesCount);
                            salesTotalAmount += total.SalesTotal;
                            salesTotalCount += total.SalesCount;
                        }

                    }
                }
                    table.Rows.Add("Total", "", salesTotalAmount, salesTotalCount);
                    table.Rows.Add("", "", "", "");
            }
            

            return table;
        }

       public DataTable reportRestockByMachine(List<Machine> machines)
       {

           DataTable table = new DataTable();
           DataColumn newColumn = new DataColumn("Machine ID", typeof(String));
           table.Columns.Add(newColumn);

           newColumn = new DataColumn("Restock Product Type", typeof(String));
           table.Columns.Add(newColumn);

           newColumn = new DataColumn("Current Quantity", typeof(String));
           table.Columns.Add(newColumn);

           newColumn = new DataColumn("Restock Min", typeof(String));
           table.Columns.Add(newColumn);




           foreach (Machine machine in machines)
           {
               table.Rows.Add(machine.MachineID, "", "");
               List<string> machineProducts = machine.getItemsRestock();

               foreach (string item in machineProducts)
               {
                   int productCount = machine.getSingleQuantity(item);
                   table.Rows.Add("", item, productCount, machine.DefaultMinStock);
               }

               table.Rows.Add("", "", "");
           }

           return table;
       }



    }
}
