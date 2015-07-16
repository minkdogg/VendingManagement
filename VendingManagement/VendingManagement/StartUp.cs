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
                case "City List":
                    MainField.SelectTab(MainTab2);
                    CityTabs.SelectTab(CityList);
                    break;
                case "Revenue by City":
                    MainField.SelectTab(MainTab2);
                    CityTabs.SelectTab(RevenueByCity);
                    break;
                case "Item Sales by City":
                    MainField.SelectTab(MainTab2);
                    CityTabs.SelectTab(ItemSalesByCity);
                    break;
                
                //Machine
                case "Machine":
                    MainField.SelectTab(MainTab3);
                    break;
                case "All Machines":
                    MainField.SelectTab(MainTab3);
                    MachineTabs.SelectTab(AllMachines);
                    break;
                case "Product Type":
                    MainField.SelectTab(MainTab3);
                    MachineTabs.SelectTab(ProductType);
                    break;
                case "Items by Machine":
                    MainField.SelectTab(MainTab3);
                    MachineTabs.SelectTab(ItemsByMachine);
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
            if (CityTabs.SelectedTab == CityList)
            {
                List<Machine> data;
                data = this.database.SelectAllMachine();
                CityMachinesDataGrid.DataSource = data;
            }
            else if (CityTabs.SelectedTab == RevenueByCity)
            {
                List<Transactions> data;
                data = this.database.SelectAllTransactions();
                CityTotalRevenueDataGrid.DataSource = data;
            }
            else if (CityTabs.SelectedTab == ItemSalesByCity)
            {
                List<Transactions> data;
                data = this.database.SelectAllTransactions();
                CitySalesByItemDataGrid.DataSource = data;
            }
        }


        //MACHINE TABS ==> load data on tab change
        private void MachineTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MachineTabs.SelectedTab == AllMachines)
            {
                List<Machine> data;
                data = this.database.SelectAllMachine();
                MachineListAllDataGrid.DataSource = data;
            }
            else if (MachineTabs.SelectedTab == ProductType)
            {
                List<Machine> data;
                data = this.database.SelectAllMachine();
                MachineTypeDataGrid.DataSource = data;
            }
            else if (MachineTabs.SelectedTab == ItemsByMachine)
            {
                List<Machine> data;
                data = this.database.SelectAllMachine();
                MachineProductItemsDataGrid.DataSource = data;
            }
        }

        private void MainField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> employeeIdToRemove = new List<string>();
            if (EmployeesDataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in EmployeesDataGrid.SelectedRows)
                {
                    //MessageBox.Show( row.Cells["EmployeeID"].Value.ToString());
                    if (!employeeIdToRemove.Contains(row.Cells["EmployeeID"].Value.ToString()))
                    {
                        employeeIdToRemove.Add(row.Cells["EmployeeID"].Value.ToString());
                    }
                }

            }
            else if (EmployeesDataGrid.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in EmployeesDataGrid.SelectedCells)
                {
                    DataGridViewRow row = EmployeesDataGrid.Rows[cell.RowIndex];
                    //MessageBox.Show(row.Cells["EmployeeID"].Value.ToString());
                    if (!employeeIdToRemove.Contains(row.Cells["EmployeeID"].Value.ToString()))
                    {
                        employeeIdToRemove.Add(row.Cells["EmployeeID"].Value.ToString());
                    }
                }
            }

            foreach (string ID in employeeIdToRemove)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to Delete employee ID# " + ID,
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                if (confirm == DialogResult.Yes)
                {
                    Controller controller = new Controller(database);
                    controller.RemoveEmployee(ID);

                    EmployeesDataGrid.DataSource = null;
                    EmployeesDataGrid.Update();
                    EmployeesDataGrid.Refresh();

                    List<Employee> data;
                    data = this.database.SelectAllEmployee();
                    EmployeesDataGrid.DataSource = data;
                    EmployeesDataGrid.Update();
                    EmployeesDataGrid.Refresh();

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }
    }
}
