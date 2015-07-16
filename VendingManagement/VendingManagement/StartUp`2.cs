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

    }
}
