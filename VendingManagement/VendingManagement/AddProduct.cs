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
    public partial class AddProduct : Form
    {
        List<Product> data;
        Database database;
        StartUp parent;

        public AddProduct(Database database, StartUp parent)
        {
            InitializeComponent();
            this.database = database;
            this.parent = parent;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = textBox8.Text;
                string wholeSalePriceString = textBox7.Text;
                if (name != "" & name != null &
                    wholeSalePriceString != "" & wholeSalePriceString != null)
                {
                    float wholeSalePrice = float.Parse(wholeSalePriceString);

                    // Create Record
                    Controller controller = new Controller(database);
                    controller.AddProduct(name, wholeSalePrice);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a product name and purchase price.");
                }

            }
            catch
            {
                MessageBox.Show("Invalid Entries - Please enter a product name and purchase price.");
            }

        }
    }
}
