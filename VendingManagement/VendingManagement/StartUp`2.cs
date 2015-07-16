﻿using System;
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
            data = this.database.SelectAllProduct();
            ProductWarehouseDataGrid.DataSource = data;
            ProductWarehouseDataGrid.Update();
            ProductWarehouseDataGrid.Refresh();
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

            List<Machine> data;
            data = this.database.SelectAllMachine();
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

        public void LoadMachineTypeDataGrid()
        {
            MachineTypeDataGrid.DataSource = null;
            MachineTypeDataGrid.Update();
            MachineTypeDataGrid.Refresh();

            List<Machine> data;
            data = this.database.SelectAllMachine();
            MachineTypeDataGrid.DataSource = data;
            MachineTypeDataGrid.Update();
            MachineTypeDataGrid.Refresh();
        }

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
        // Remove Button Interfaces
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
                        ProductIdToRemove.Add(row.Cells["Name"].Value.ToString());
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
                        ProductIdToRemove.Add(row.Cells["Name"].Value.ToString());
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

                    LoadVehiclesDataGrid();



                }

            }
        }







            







    }
}