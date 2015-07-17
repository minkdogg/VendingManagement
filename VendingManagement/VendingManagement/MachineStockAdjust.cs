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
        Machine machine;
        TransferManager transferManager;


        public MachineStockAdjust(Database database, StartUp parent, Machine machine)
        {
            InitializeComponent();
            this.database = database;
            this.parent = parent;
            this.machine = machine;
            this.transferManager = new TransferManager(database);

        }

        private void MachineStockAdjust_Load(object sender, EventArgs e)
        {
            LoadMachineDataHeader();
            LoadWarehouseTransferGridView();
            LoadMachineTransferGridView();            
        }


        private void LoadMachineDataHeader()
        {
            tbMachineID.Text = this.machine.MachineID;
            tbCity.Text = this.machine.City;
            tbLocation.Text = this.machine.Location;
            tbMinimimStock.Text = Convert.ToString(this.machine.DefaultMinStock);
            tbMaximumStock.Text = Convert.ToString(this.machine.MaxCapacity);
            cbRestock.Checked = this.machine.NeedRestock;
            cbService.Checked = this.machine.NeedService;
        }




        public void LoadWarehouseTransferGridView()
        {
            WarehouseTransferGridView.DataSource = null;
            WarehouseTransferGridView.Update();
            WarehouseTransferGridView.Refresh();

            List<Product> data;
            ReportManager report = new ReportManager();
            data = this.database.SelectAllProduct();
            DataTable source = report.reportProductWarehouse(data);
            WarehouseTransferGridView.DataSource = source;
        }

        public void LoadMachineTransferGridView()
        {
            MachineTransferGridView.DataSource = null;
            MachineTransferGridView.Update();
            MachineTransferGridView.Refresh();

            List<Machine> data = new List<Machine>();
            data.Add(machine);
            ReportManager report = new ReportManager();
            DataTable source = report.reportProductByMachine(data);
            MachineTransferGridView.DataSource = source;
        }





    }
}
