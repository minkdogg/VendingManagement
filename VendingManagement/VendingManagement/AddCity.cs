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
    public partial class AddCity : Form
    {
        Database database;
        StartUp parent;

        public AddCity(Database database, StartUp parent)
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
                List<string> existingIDList = new List<string>();
                foreach (City city in database.SelectAllCity())
                {
                    existingIDList.Add(city.ID);
                }

                string cityName = textBox8.Text;
                string state = textBox7.Text;
                string ID = textBox1.Text;
                if (!existingIDList.Contains(ID))
                {
                    if (cityName != "" & cityName != null &
                        state != "" & state != null &
                        ID != "" & ID != null)
                    {
                        // Create Record
                        Controller controller = new Controller(database);
                        controller.AddCity(cityName, state, ID);
                        this.parent.LoadCityMachinesDataGrid();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a City, State, and a uniquie ID.");
                    }
                }
                else
                {
                    MessageBox.Show("ID already exists. Please enter a uniqueID.");
                }

            }
            catch
            {
                MessageBox.Show("Invalid Entries - Please enter a City, State, and a uniquie ID.");
            }

        }
    }
}
