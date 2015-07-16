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
                string quantityString = textBox1.Text;

                if (name != "" & name != null &
                    wholeSalePriceString != "" & wholeSalePriceString != null &
                    quantityString != "" & quantityString != null )
                {
                    float wholeSalePrice = float.Parse(wholeSalePriceString);
                    int quantity = int.Parse(quantityString);

                    if (quantity > 0)
                    {
                        DialogResult confirm = MessageBox.Show("You are about to purchase " + quantityString + " " + name + " for a total of $" + Convert.ToString(quantity * wholeSalePrice) + ".\nPlease confirm this is accurate.",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);

                        if (confirm == DialogResult.Yes)
                        {
                            // Create Record
                            Controller controller = new Controller(database);
                            controller.AddProduct(name, wholeSalePrice, quantity);
                            this.parent.LoadProductWarehouseDataGrid();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter quantity larger than 0.");
                    }
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
