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
    public partial class PDFCreatedDialog : Form
    {
        public PDFCreatedDialog()
        {
            InitializeComponent();
        }

        private void PdfCreateOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
