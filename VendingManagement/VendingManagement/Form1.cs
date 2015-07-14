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
    public partial class Form1 : Form
    {
        List<Product> data;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.generateInitialData();
            this.data = database.SelectAllProduct();

            dataGridView2.DataSource = data;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.data != null)
            {
                data.Remove(data[0]);
                dataGridView2.Refresh();
            }
        }
    }
}
