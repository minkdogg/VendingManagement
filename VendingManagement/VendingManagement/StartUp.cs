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
        Database database = new Database();
        protected bool businessVisited = false;
        protected bool cityVisited = false;
        protected bool machineVisited = false;
        
        public StartUp()
        {
            InitializeComponent();
            this.database.generateInitialData();
            BusinessTabs.SelectedIndexChanged += new EventHandler(BusinessTabs_SelectedIndexChanged);
            CityTabs.SelectedIndexChanged += new EventHandler(CityTabs_SelectedIndexChanged);
            MachineTabs.SelectedIndexChanged += new EventHandler(MachineTabs_SelectedIndexChanged);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MainField.SelectTab(MainTab1);
            BusinessTabs.SelectTab(BusinessEmployees);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Header_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainField.SelectTab(MainTab3);
        }

        private void Business_Click(object sender, EventArgs e)
        {
            MainField.SelectTab(MainTab1);
        }

        private void City_Click(object sender, EventArgs e)
        {
            MainField.SelectTab(MainTab2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainField.SelectTab(MainTab4);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Reports":
                    MainField.SelectTab(MainTab4);
                    break;
                case "Total Profit":
                    MainField.SelectTab(MainTab4);
                    ReportTabs.SelectTab(ReportsTotalProfit);
                    break;
                case "Top Selling Items":
                    MainField.SelectTab(MainTab4);
                    ReportTabs.SelectTab(ReportsTopSellingItems);
                    break;
                case "Profit Margin by Item":
                    MainField.SelectTab(MainTab4);
                    ReportTabs.SelectTab(ReportsProfitMarginByItem);
                    break;
                case "Sales by City":
                    MainField.SelectTab(MainTab4);
                    ReportTabs.SelectTab(ReportsSalesByCity);
                    break;
            }
        }


        //SIDEBAR TREE VIEW NAVIGATION
        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                //Business
                case "Business":
                    MainField.SelectTab(MainTab1);
                    break;
                case "Product Warehouse":
                    MainField.SelectTab(MainTab1);
                    BusinessTabs.SelectTab(BusinessProductWarehouse);
                    break;
                case "Transactions":
                    MainField.SelectTab(MainTab1);
                    BusinessTabs.SelectTab(BusinessTransactions);
                    break;
                case "Employees":
                    MainField.SelectTab(MainTab1);
                    BusinessTabs.SelectTab(BusinessEmployees);
                    break;
                case "Vehicles":
                    MainField.SelectTab(MainTab1);
                    BusinessTabs.SelectTab(BusinessVehicles);
                    break;

                //City
                case "City":
                    MainField.SelectTab(MainTab2);
                    break;
                case "Machines":
                    MainField.SelectTab(MainTab2);
                    CityTabs.SelectTab(CityMachines);
                    break;
                case "Total Revenue":
                    MainField.SelectTab(MainTab2);
                    CityTabs.SelectTab(CityTotalRevenue);
                    break;
                case "Sales by Item":
                    MainField.SelectTab(MainTab2);
                    CityTabs.SelectTab(CitySalesByItem);
                    break;
                
                //Machine
                case "Machine":
                    MainField.SelectTab(MainTab3);
                    break;
                case "List All":
                    MainField.SelectTab(MainTab3);
                    MachineTabs.SelectTab(MachineListAll);
                    break;
                case "Type":
                    MainField.SelectTab(MainTab3);
                    MachineTabs.SelectTab(MachineType);
                    break;
                case "Product Items":
                    MainField.SelectTab(MainTab3);
                    MachineTabs.SelectTab(MachineProductItems);
                    break;
            }
        }


        //BUSINESS TABS ==> load data on tab change
        private void BusinessTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BusinessTabs.SelectedTab == BusinessProductWarehouse)
            {
                List<Product> data;
                data = this.database.SelectAllProduct();
                ProductWarehouseDataGrid.DataSource = data;
            }
            else if (BusinessTabs.SelectedTab == BusinessTransactions)
            {
                List<Transactions> data;
                data = this.database.SelectAllTransactions();
                TransactionsDataGrid.DataSource = data;
            }
            else if (BusinessTabs.SelectedTab == BusinessEmployees)
            {
                List<Employee> data;
                data = this.database.SelectAllEmployee();
                EmployeesDataGrid.DataSource = data;
            }
            else if (BusinessTabs.SelectedTab == BusinessVehicles)
            {
                List<Vehicle> data;
                data = this.database.SelectAllVehicle();
                VehiclesDataGrid.DataSource = data;
            }
        }


        //CITY TABS ==> load data on tab change
        private void CityTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CityTabs.SelectedTab == CityMachines)
            {
                List<Machine> data;
                data = this.database.SelectAllMachine();
                CityMachinesDataGrid.DataSource = data;
            }
            else if (CityTabs.SelectedTab == CityTotalRevenue)
            {
                List<Transactions> data;
                data = this.database.SelectAllTransactions();
                CityTotalRevenueDataGrid.DataSource = data;
            }
            else if (CityTabs.SelectedTab == CitySalesByItem)
            {
                List<Transactions> data;
                data = this.database.SelectAllTransactions();
                CitySalesByItemDataGrid.DataSource = data;
            }
        }


        //MACHINE TABS ==> load data on tab change
        private void MachineTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MachineTabs.SelectedTab == MachineListAll)
            {
                List<Machine> data;
                data = this.database.SelectAllMachine();
                MachineListAllDataGrid.DataSource = data;
            }
            else if (MachineTabs.SelectedTab == MachineType)
            {
                List<Machine> data;
                data = this.database.SelectAllMachine();
                MachineTypeDataGrid.DataSource = data;
            }
            else if (MachineTabs.SelectedTab == MachineProductItems)
            {
                List<Machine> data;
                data = this.database.SelectAllMachine();
                MachineProductItemsDataGrid.DataSource = data;
            }
        }
    }
}
