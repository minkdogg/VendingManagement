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
        public StartUp()
        {
            InitializeComponent();
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

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                //BUSINESS
                case "Business":
                    MainField.SelectTab(MainTab1);
                    break;
                case "Employees":
                    MainField.SelectTab(MainTab1);
                    BusinessTabs.SelectTab(BusinessEmployees);
                    break;
                case "Vehicles":
                    MainField.SelectTab(MainTab1);
                    BusinessTabs.SelectTab(BusinessVehicles);
                    break;
                case "Transactions":
                    MainField.SelectTab(MainTab1);
                    BusinessTabs.SelectTab(BusinessTransactions);
                    break;

                //CITY
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
                
                //MACHINE
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
    }
}
