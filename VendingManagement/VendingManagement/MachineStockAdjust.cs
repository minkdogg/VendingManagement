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
    public partial class MachineStockAdjust : Form
    {
        Database database;
        StartUp parent;
        TransferManager transferManager;
        public MachineStockAdjust(Database database, StartUp parent, Machine machine)
        {
            InitializeComponent();
            this.database = database;
            this.parent = parent;
            this.transferManager = new TransferManager(database);

        }
    }
}
