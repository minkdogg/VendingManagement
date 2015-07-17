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
    public partial class StartUp : Form
    {
        //
        // Load/Refresh Full Datagrid views
        //
        public void LoadProductWarehouseDataGrid()
        {
            ProductWarehouseDataGrid.DataSource = null;
            ProductWarehouseDataGrid.Update();
            ProductWarehouseDataGrid.Refresh();

            List<Product> data;
            ReportManager report = new ReportManager();
            data = this.database.SelectAllProduct();
            DataTable source = report.reportProductWarehouse(data);
            ProductWarehouseDataGrid.DataSource = source;
        }
                
        public void LoadTransactionsDataGrid()
        {
            TransactionsDataGrid.DataSource = null;
            TransactionsDataGrid.Update();
            TransactionsDataGrid.Refresh();

            List<Transactions> data;
            data = this.database.SelectAllTransactions();
            TransactionsDataGrid.DataSource = data;
            TransactionsDataGrid.Update();
            TransactionsDataGrid.Refresh();
        }

        public void LoadEmployeesDataGrid()
        {
            EmployeesDataGrid.DataSource = null;
            EmployeesDataGrid.Update();
            EmployeesDataGrid.Refresh();

            List<Employee> data;
            data = this.database.SelectAllEmployee();
            EmployeesDataGrid.DataSource = data;
            EmployeesDataGrid.Update();
            EmployeesDataGrid.Refresh();
        }

        public void LoadVehiclesDataGrid()
        {
            VehiclesDataGrid.DataSource = null;
            VehiclesDataGrid.Update();
            VehiclesDataGrid.Refresh();

            List<Vehicle> data;
            data = this.database.SelectAllVehicle();
            VehiclesDataGrid.DataSource = data;
            VehiclesDataGrid.Update();
            VehiclesDataGrid.Refresh();
        }
        
        public void LoadCityMachinesDataGrid()
        {
            CityMachinesDataGrid.DataSource = null;
            CityMachinesDataGrid.Update();
            CityMachinesDataGrid.Refresh();

            List<City> data;
            data = this.database.SelectAllCity();
            CityMachinesDataGrid.DataSource = data;
            CityMachinesDataGrid.Update();
            CityMachinesDataGrid.Refresh();
        }

        public void LoadCityTotalRevenueDataGrid()
        {
            CityTotalRevenueDataGrid.DataSource = null;
            CityTotalRevenueDataGrid.Update();
            CityTotalRevenueDataGrid.Refresh();

            List<Transactions> data;
            data = this.database.SelectAllTransactions();
            CityTotalRevenueDataGrid.DataSource = data;
            CityTotalRevenueDataGrid.Update();
            CityTotalRevenueDataGrid.Refresh();
        }

        public void LoadCitySalesByItemDataGrid()
        {
            CitySalesByItemDataGrid.DataSource = null;
            CitySalesByItemDataGrid.Update();
            CitySalesByItemDataGrid.Refresh();

            List<Transactions> data;
            data = this.database.SelectAllTransactions();
            CitySalesByItemDataGrid.DataSource = data;
            CitySalesByItemDataGrid.Update();
            CitySalesByItemDataGrid.Refresh();
        }

        public void LoadMachineListAllDataGrid()
        {
            MachineListAllDataGrid.DataSource = null;
            MachineListAllDataGrid.Update();
            MachineListAllDataGrid.Refresh();

            List<Machine> data;
            data = this.database.SelectAllMachine();
            MachineListAllDataGrid.DataSource = data;
            MachineListAllDataGrid.Update();
            MachineListAllDataGrid.Refresh();
        }

        //public void LoadMachineTypeDataGrid()
        //{
        //    MachineTypeDataGrid.DataSource = null;
        //    MachineTypeDataGrid.Update();
        //    MachineTypeDataGrid.Refresh();

        //    List<Machine> data;
        //    data = this.database.SelectAllMachine();
        //    MachineTypeDataGrid.DataSource = data;
        //    MachineTypeDataGrid.Update();
        //    MachineTypeDataGrid.Refresh();
        //}

        public void LoadMachineProductItemsDataGrid()
        {
            MachineProductItemsDataGrid.DataSource = null;
            MachineProductItemsDataGrid.Update();
            MachineProductItemsDataGrid.Refresh();

            List<Machine> data;
            data = this.database.SelectAllMachine();
            MachineProductItemsDataGrid.DataSource = data;
            MachineProductItemsDataGrid.Update();
            MachineProductItemsDataGrid.Refresh();
        }


        //
        // Remove Button Control Methods
        //

        // Product Remove Button
        private void button3_Click_1(object sender, EventArgs e)
        {
            List<string> ProductIdToRemove = new List<string>();
            List<int> rowsProcessedAlready = new List<int>();
            if (ProductWarehouseDataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in ProductWarehouseDataGrid.SelectedRows)
                {
                    if (!rowsProcessedAlready.Contains(row.Index))
                    {
                        ProductIdToRemove.Add(row.Cells["Product Type"].Value.ToString());
                        rowsProcessedAlready.Add(row.Index);
                    }
                }

            }
            else if (ProductWarehouseDataGrid.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in ProductWarehouseDataGrid.SelectedCells)
                {
                    DataGridViewRow row = ProductWarehouseDataGrid.Rows[cell.RowIndex];
                    if (!rowsProcessedAlready.Contains(row.Index))
                    {
                        ProductIdToRemove.Add(row.Cells["Product Type"].Value.ToString());
                        rowsProcessedAlready.Add(row.Index);
                    }
                }
            }

            foreach (string ID in ProductIdToRemove)
            {
                //DialogResult confirm = MessageBox.Show("Are you sure you want to Delete product ID " + ID,
                //    "Confirm Delete",
                //    MessageBoxButtons.YesNo,
                //    MessageBoxIcon.Exclamation,
                //    MessageBoxDefaultButton.Button2);

                //if (confirm == DialogResult.Yes)
                if (true)
                {
                    Controller controller = new Controller(database);
                    controller.RemoveProduct(ID);
                    this.LoadProductWarehouseDataGrid();
                }
            }
        }


        // Remove Vehicle Button
        private void button7_Click(object sender, EventArgs e)
        {
            List<string> VehicleIdToRemove = new List<string>();
            if (VehiclesDataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in VehiclesDataGrid.SelectedRows)
                {
                    if (!VehicleIdToRemove.Contains(row.Cells["VehicleID"].Value.ToString()))
                    {
                        VehicleIdToRemove.Add(row.Cells["VehicleID"].Value.ToString());
                    }
                }

            }
            else if (VehiclesDataGrid.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in VehiclesDataGrid.SelectedCells)
                {
                    DataGridViewRow row = VehiclesDataGrid.Rows[cell.RowIndex];
                    if (!VehicleIdToRemove.Contains(row.Cells["VehicleID"].Value.ToString()))
                    {
                        VehicleIdToRemove.Add(row.Cells["VehicleID"].Value.ToString());
                    }
                }
            }

            foreach (string ID in VehicleIdToRemove)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to Delete vehicle ID# " + ID,
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                if (confirm == DialogResult.Yes)
                {
                    Controller controller = new Controller(database);
                    controller.RemoveVehicle(ID);
                    this.LoadVehiclesDataGrid();
                }
            }
        }


        // Remove City Button
        private void button9_Click(object sender, EventArgs e)
        {
            List<string> CityIdToRemove = new List<string>();
            if (CityMachinesDataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in CityMachinesDataGrid.SelectedRows)
                {
                    if (!CityIdToRemove.Contains(row.Cells["Name"].Value.ToString()))
                    {
                        CityIdToRemove.Add(row.Cells["Name"].Value.ToString());
                    }
                }

            }
            else if (CityMachinesDataGrid.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in CityMachinesDataGrid.SelectedCells)
                {
                    DataGridViewRow row = CityMachinesDataGrid.Rows[cell.RowIndex];
                    if (!CityIdToRemove.Contains(row.Cells["Name"].Value.ToString()))
                    {
                        CityIdToRemove.Add(row.Cells["Name"].Value.ToString());
                    }
                }
            }

            foreach (string ID in CityIdToRemove)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to Delete City ID# " + ID,
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                if (confirm == DialogResult.Yes)
                {
                    Controller controller = new Controller(database);
                    controller.RemoveCity(ID);
                    this.LoadCityMachinesDataGrid();
                }
            }
        }


        // Remove Machine Button
        private void button15_Click(object sender, EventArgs e)
        {
            List<string> MachineIdToRemove = new List<string>();
            if (MachineListAllDataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in MachineListAllDataGrid.SelectedRows)
                {
                    if (!MachineIdToRemove.Contains(row.Cells["MachineID"].Value.ToString()))
                    {
                        MachineIdToRemove.Add(row.Cells["MachineID"].Value.ToString());
                    }
                }

            }
            else if (MachineListAllDataGrid.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in MachineListAllDataGrid.SelectedCells)
                {
                    DataGridViewRow row = MachineListAllDataGrid.Rows[cell.RowIndex];
                    if (!MachineIdToRemove.Contains(row.Cells["MachineID"].Value.ToString()))
                    {
                        MachineIdToRemove.Add(row.Cells["MachineID"].Value.ToString());
                    }
                }
            }

            foreach (string ID in MachineIdToRemove)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to Delete Machine ID# " + ID,
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                if (confirm == DialogResult.Yes)
                {
                    Controller controller = new Controller(database);
                    controller.RemoveMachine(ID);
                    this.LoadMachineListAllDataGrid();
                }
            }
        }



        // Update Machine Button
        private void button10_Click(object sender, EventArgs e)
        {
            List<string> MachineToModify = new List<string>();
            if (MachineListAllDataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in MachineListAllDataGrid.SelectedRows)
                {
                    if (!MachineToModify.Contains(row.Cells["MachineID"].Value.ToString()))
                    {
                        MachineToModify.Add(row.Cells["MachineID"].Value.ToString());
                    }
                }

            }
            else if (MachineListAllDataGrid.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in MachineListAllDataGrid.SelectedCells)
                {
                    DataGridViewRow row = MachineListAllDataGrid.Rows[cell.RowIndex];
                    if (!MachineToModify.Contains(row.Cells["MachineID"].Value.ToString()))
                    {
                        MachineToModify.Add(row.Cells["MachineID"].Value.ToString());
                    }
                }
            }

            if (MachineToModify.Count == 1)
            {
                string machineID = MachineToModify[0];
                List<Machine> machineList = this.database.SelectMachine(machineID);
                MachineStockAdjust machineStockAdjust = new MachineStockAdjust(database, this, machineList[0]);
                machineStockAdjust.Show();
            }
            else
            {
                MessageBox.Show("Please select a single machine.");
            }
            
        }

  
    }
}
