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
    public partial class AddMachine : Form
    {
        Database database;
        StartUp parent;

        public AddMachine(Database database, StartUp parent)
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
                // Prebuild Existing Machine ID list for comparison
                List<string> existingIDList = new List<string>();
                foreach (Machine machine in database.SelectAllMachine())
                {
                    existingIDList.Add(machine.MachineID);
                }

                string productType = textBox1.Text;
                string maxCapacityString = textBox2.Text;
                string city = textBox3.Text;
                string location = textBox4.Text;
                string minimumStockString = textBox5.Text;
                string machineID = textBox6.Text;

                if (!existingIDList.Contains(machineID))
                {
                    if (productType != "" & productType != null &
                        maxCapacityString != "" & maxCapacityString != null &
                        city != "" & city != null &
                        location != "" & location != null &
                        minimumStockString != "" & minimumStockString != null &
                        machineID != "" & machineID != null)
                    {
                        int maxCapacity = int.Parse(maxCapacityString);
                        int minimumStock = int.Parse(minimumStockString);

                        // Create Record
                        Controller controller = new Controller(database);
                        controller.AddMachine(machineID, city, location, maxCapacity, minimumStock, productType);
                        this.parent.LoadMachineListAllDataGrid();
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
