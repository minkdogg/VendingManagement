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
    public partial class AddEmployee : Form
    {
        Database database;
        StartUp parent;

        public AddEmployee(Database database, StartUp parent)
        {
            InitializeComponent();
            this.database = database;
            this.parent = parent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Prebuild Existing Employee ID list for comparison
                List<string> existingIDList = new List<string>();
                foreach (Employee employee in database.SelectAllEmployee())
                {
                    existingIDList.Add(employee.EmployeeID);
                }

                string fName = textBox1.Text;
                string lName = textBox2.Text;
                string position = textBox3.Text;
                string location = textBox4.Text;
                string payRateString = textBox5.Text;
                string employeeID = textBox6.Text;
                string dateTimeString = textBox7.Text;

                if (!existingIDList.Contains(employeeID))
                {
                    if (fName != "" & fName != null &
                        lName != "" & lName != null &
                        position != "" & position != null &
                        location != "" & location != null &
                        employeeID != "" & employeeID != null)
                    {
                        float payRate = float.Parse(payRateString);
                        DateTime dateStarted = DateTime.Parse(dateTimeString);

                        // Create Record
                        Controller controller = new Controller(database);
                        controller.AddEmployee(fName, lName, employeeID, location, position, payRate, dateStarted);
                        this.parent.LoadEmployeesDataGrid();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter all employee information");
                    }
                }
                else 
                {
                    MessageBox.Show("That Employee ID already exists. Please select a new ID.");
                }

            }
            catch
            {
                MessageBox.Show("Invalid Entries - Please enter employee information.");
            }

        }
    }
}
