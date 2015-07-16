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
    public partial class AddCity : Form
    {
        List<City> data;
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
                string city = textBox8.Text;
                string state = textBox7.Text;
                if (city != "" & city != null &
                    state != "" & state != null)
                {
                    // Create Record
                    Controller controller = new Controller(database);
                    controller.AddCity(city, state);
                    this.parent.LoadCityMachinesDataGrid();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a City and State.");
                }

            }
            catch
            {
                MessageBox.Show("Invalid Entries - Please enter a City and State.");
            }

        }
    }
}
