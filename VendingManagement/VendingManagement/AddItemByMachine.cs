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
    public partial class AddItemByMachine : Form
    {
        Database database;
        StartUp parent;

        public AddItemByMachine(Database database, StartUp parent)
        {
            InitializeComponent();
            this.database = database;
            this.parent = parent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
