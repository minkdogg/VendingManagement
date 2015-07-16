﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    class Controller
    {
        Database database;

        public Controller(Database database)
        {
            this.database = database;
        }



        //
        // Add Objects from Form
        //
        public bool AddProduct(string name, float wholeSalePrice)
        {
            if (name != "" & name != null)
            {
                Product product = new Product(name, wholeSalePrice);
                this.database.Append(product);
                return true;
            }
            else
            { return false; }
        }

        public bool AddMachine(string ID, string city, string location)
        {
            if (ID != "" & ID != null & 
                city != "" & city != null &
                location != "" & location != null)
            {
                Machine machine = new Machine(city, location, ID);
                this.database.Append(machine);
                return true;
            }
            else
            { return false; }
        }

        public bool AddCity(string name, string location)
        {
            if (name != "" & name != null & location != "" & location != null)
            {
                City city = new City(name, location);
                this.database.Append(city);
                return true;
            }
            else
            { return false; }
        }

        public bool AddEmployee(string fName, string lName, string ID, string location, string position, float payrate, DateTime dateStarted)
        {
            if (fName != "" & fName != null &
                lName != "" & lName != null &
                ID != "" & ID != null &
                location != "" & location != null &
                position != "" & position != null &
                dateStarted != null)
            {
                Employee employee = new Employee(fName, lName, ID, location);
                employee.Position = position;
                employee.Payrate = payrate;
                employee.DateStarted = dateStarted;
                this.database.Append(employee);
                return true;
            }
            else
            { return false; }

        
        }

        public bool AddVehicle(string ID, string location, int costPerMile)
        {
            if (ID != "" & ID != null & location != "" & location != null)
            {
                Vehicle vehicle = new Vehicle(ID, location, costPerMile);
                this.database.Append(vehicle);
                return true;
            }
            else
            { return false; }
        }





        //
        // Remove Object from Form
        //
        public bool RemoveEmployee(string ID)
        {
            if (ID != "" & ID != null)
            {
                List<Employee> employee = database.SelectEmployee(ID);
                if (employee.Count == 1)
                {
                    database.Remove(employee[0]);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }





        //private void button5_Click(object sender, EventArgs e)
        //{
        //    List<string> employeeIdToRemove = new List<string>();
        //    if (EmployeesDataGrid.SelectedRows.Count > 0)
        //    {
        //        foreach (DataGridViewRow row in EmployeesDataGrid.SelectedRows)
        //        {
        //            //MessageBox.Show( row.Cells["EmployeeID"].Value.ToString());
        //            if (!employeeIdToRemove.Contains(row.Cells["EmployeeID"].Value.ToString()))
        //            {
        //                employeeIdToRemove.Add(row.Cells["EmployeeID"].Value.ToString());
        //            }
        //        }

        //    }
        //    else if (EmployeesDataGrid.SelectedCells.Count > 0)
        //    {
        //        foreach (DataGridViewCell cell in EmployeesDataGrid.SelectedCells)
        //        {
        //            DataGridViewRow row = EmployeesDataGrid.Rows[cell.RowIndex];
        //            //MessageBox.Show(row.Cells["EmployeeID"].Value.ToString());
        //            if (!employeeIdToRemove.Contains(row.Cells["EmployeeID"].Value.ToString()))
        //            {
        //                employeeIdToRemove.Add(row.Cells["EmployeeID"].Value.ToString());
        //            }
        //        }
        //    }

        //    foreach (string ID in employeeIdToRemove)
        //    {
        //        DialogResult confirm = MessageBox.Show("Are you sure you want to Delete employee ID# " + ID,
        //            "Confirm Delete",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Exclamation,
        //            MessageBoxDefaultButton.Button2);

        //        if (confirm == DialogResult.Yes)
        //        {
        //            Controller controller = new Controller(database);
        //            controller.RemoveEmployee(ID);

        //            EmployeesDataGrid.DataSource = null;
        //            EmployeesDataGrid.Update();
        //            EmployeesDataGrid.Refresh();

        //            List<Employee> data;
        //            data = this.database.SelectAllEmployee();
        //            EmployeesDataGrid.DataSource = data;
        //            EmployeesDataGrid.Update();
        //            EmployeesDataGrid.Refresh();

        //        }

        //    }
        //}
    }
}
