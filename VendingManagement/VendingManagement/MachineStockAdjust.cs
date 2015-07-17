using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingManagement
{
    public partial class MachineStockAdjust : Form
    {
        Database database;
        StartUp parent;
        Machine machine;
        Controller controller;


        public MachineStockAdjust(Database database, StartUp parent, Machine machine)
        {
            InitializeComponent();
            this.database = database;
            this.parent = parent;
            this.machine = machine;
            this.controller = new Controller(database);

        }

        private void MachineStockAdjust_Load(object sender, EventArgs e)
        {
            LoadMachineDataHeader();
            LoadWarehouseTransferGridView();
            LoadMachineTransferGridView();            
        }


        private void LoadMachineDataHeader()
        {
            tbMachineID.Text = this.machine.MachineID;
            tbCity.Text = this.machine.City;
            tbLocation.Text = this.machine.Location;
            tbMinimimStock.Text = Convert.ToString(this.machine.DefaultMinStock);
            tbMaximumStock.Text = Convert.ToString(this.machine.MaxCapacity);
            cbRestock.Checked = this.machine.NeedRestock;
            cbService.Checked = this.machine.NeedService;
        }




        public void LoadWarehouseTransferGridView()
        {
            WarehouseTransferGridView.DataSource = null;
            WarehouseTransferGridView.Update();
            WarehouseTransferGridView.Refresh();

            List<Product> data;
            ReportManager report = new ReportManager();
            data = this.database.SelectAllProduct();
            DataTable source = report.reportProductWarehouse(data);
            WarehouseTransferGridView.DataSource = source;
        }

        public void LoadMachineTransferGridView()
        {
            MachineTransferGridView.DataSource = null;
            MachineTransferGridView.Update();
            MachineTransferGridView.Refresh();

            List<Machine> data = new List<Machine>();
            data.Add(machine);
            ReportManager report = new ReportManager();
            DataTable source = report.reportProductByMachine(data);
            MachineTransferGridView.DataSource = source;
        }

        // On Warehouse gridview select, choose which object is being selected.
        private void WarehouseTransferGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> ProductId = new List<string>();
            List<int> rowsProcessedAlready = new List<int>();
            if (WarehouseTransferGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in WarehouseTransferGridView.SelectedRows)
                {
                    if (!rowsProcessedAlready.Contains(row.Index))
                    {
                        ProductId.Add(row.Cells["Product Type"].Value.ToString());
                        rowsProcessedAlready.Add(row.Index);
                    }
                }

            }
            else if (WarehouseTransferGridView.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in WarehouseTransferGridView.SelectedCells)
                {
                    DataGridViewRow row = WarehouseTransferGridView.Rows[cell.RowIndex];
                    if (!rowsProcessedAlready.Contains(row.Index))
                    {
                        ProductId.Add(row.Cells["Product Type"].Value.ToString());
                        rowsProcessedAlready.Add(row.Index);
                    }
                }
            }

            if (ProductId.Count == 1)
            {
                tbProductTrasnferToMachine.Text = ProductId[0];
            }
        }


        // On Machine gridview select, choose which object is being selected.
        private void MachineTransferGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> ProductId = new List<string>();
            List<int> rowsProcessedAlready = new List<int>();
            if (MachineTransferGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in MachineTransferGridView.SelectedRows)
                {
                    if (!rowsProcessedAlready.Contains(row.Index))
                    {
                        ProductId.Add(row.Cells["Product Type"].Value.ToString());
                        rowsProcessedAlready.Add(row.Index);
                    }
                }

            }
            else if (MachineTransferGridView.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in MachineTransferGridView.SelectedCells)
                {
                    DataGridViewRow row = MachineTransferGridView.Rows[cell.RowIndex];
                    if (!rowsProcessedAlready.Contains(row.Index))
                    {
                        ProductId.Add(row.Cells["Product Type"].Value.ToString());
                        rowsProcessedAlready.Add(row.Index);
                    }
                }
            }

            if (ProductId.Count == 1)
            {
                tbProductTrasnferToWarehouse.Text = ProductId[0];
            }
        }

        // Close Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        // Transfer Between Grids
        //

        // Transfer from Warehouse to Machine
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string quantityString = tbQuantityTransferToMachine.Text;
            string product = tbProductTrasnferToMachine.Text;
            try
            {
                if (quantityString != "" & quantityString != null &
                    product != "" & product != null)
                {
                    int quantity = int.Parse(quantityString);
                    if (quantity > 0)
                    {
                        List<Product> stockList =  database.SelectProduct(product);
                        int stockQuantity = stockList.Count;
                        if (quantity <= stockQuantity)
                        {
                            int machineMaxStock = machine.MaxCapacity;
                            int machineCurrentStock = machine.products.Count;
                            int maxTransferCapacity = machineMaxStock - machineCurrentStock;
                            if (quantity <= maxTransferCapacity)
                            {
                                this.controller.TransferWarehouseToMachine(product, quantity, machine);

                                LoadMachineDataHeader();
                                LoadWarehouseTransferGridView();
                                LoadMachineTransferGridView();
                                this.parent.LoadMachineListAllDataGrid();
                            }
                            else
                            {
                                MessageBox.Show("There is only enough room for " + Convert.ToString(maxTransferCapacity) + " in the machine. Adjusting Quantity.");
                                tbQuantityTransferToMachine.Text = Convert.ToString(maxTransferCapacity);
                            }

                        }
                        else
                        {
                            MessageBox.Show("There are only " + Convert.ToString(stockQuantity) + " in stock. Adjusting Quantity.");
                            tbQuantityTransferToMachine.Text = Convert.ToString(stockQuantity);
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Please enter a quantity greater than 0.");
                    }                    
                }
                else
                {
                    MessageBox.Show("Please select a product and enter a quantity.");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Entry - Please select a product and enter a quantity.");
            }
        }

        // Transfer from Machine to Warehouse
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                string quantityString = tbQuantityTransferToWarehouse.Text;
                string product = tbProductTrasnferToWarehouse.Text;
                try
                {
                    if (quantityString != "" & quantityString != null &
                        product != "" & product != null)
                    {
                        int quantity = int.Parse(quantityString);
                        if (quantity > 0)
                        {
                            List<Product> stockList = machine.selectAllProductByType(product);
                            int stockQuantity = stockList.Count;
                            if (quantity <= stockQuantity)
                            {
                                this.controller.TransferMachineToWarehouse(product, quantity, machine);

                                LoadMachineDataHeader();
                                LoadWarehouseTransferGridView();
                                LoadMachineTransferGridView();
                                this.parent.LoadMachineListAllDataGrid();
                            }
                            else
                            {
                                MessageBox.Show("There are only " + Convert.ToString(stockQuantity) + " in stock. Adjusting Quantity.");
                                tbQuantityTransferToMachine.Text = Convert.ToString(stockQuantity);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a quantity greater than 0.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a product and enter a quantity.");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Entry - Please select a product and enter a quantity.");
                }
            }

        }
    }
}
