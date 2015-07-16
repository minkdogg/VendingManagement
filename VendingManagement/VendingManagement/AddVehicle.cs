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
    public partial class AddVehicle : Form
    {
        Database database;
        StartUp parent;

        public AddVehicle(Database database, StartUp parent)
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
                // Prebuild Existing Vehicle ID list for comparison
                List<string> existingIDList = new List<string>();
                foreach (Vehicle vehicle in database.SelectAllVehicle())
                {
                    existingIDList.Add(vehicle.VehicleID);
                }

                string vehicleID = textBox1.Text;
                string yearString = textBox2.Text;
                string make = textBox3.Text;
                string model = textBox4.Text;
                string location = textBox5.Text;
                string mileageCostString = textBox6.Text;
  
                if (!existingIDList.Contains(vehicleID))
                {
                    if (vehicleID != "" & vehicleID != null &
                        yearString != "" & yearString != null &
                        make != "" & make != null &
                        model != "" & model != null &
                        location != "" & location != null &
                        mileageCostString != "" & mileageCostString != null)
                    {
                        int year = int.Parse(yearString);
                        int mileageCost = int.Parse(mileageCostString);

                        // Create Record
                        Controller controller = new Controller(database);
                        controller.AddVehicle(vehicleID, year, make, model, location, mileageCost);

                        this.parent.LoadVehiclesDataGrid();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter all vehicle information");
                    }
                }
                else 
                {
                    MessageBox.Show("That VehicleID already exists. Please select a new ID.");
                }

            }
            catch
            {
                MessageBox.Show("Invalid Entries - Please enter vehicle information.");
            }

        
        }
    }
}
