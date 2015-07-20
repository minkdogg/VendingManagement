using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VendingManagement
{
    public partial class ChartSalesByProduct : Form
    {
        Database database;

        public ChartSalesByProduct(Database database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ChartSalesByProduct_Load(object sender, EventArgs e)
        {
            List<Transactions> data;
            ReportManager report = new ReportManager();
            data = this.database.SelectAllTransactions();
            DataTable subtotals = report.reportSalesByItem(data);

            SalesByProduct.DataSource = subtotals;

            SalesByProduct.Titles.Add("Net Profit by Product");

            string productName = subtotals.Columns[0].ToString();
            SalesByProduct.Series["Series 1"].XValueMember = productName;

            string netProfit = subtotals.Columns[1].ToString();
            SalesByProduct.Series["Series 1"].YValueMembers = netProfit;

            SalesByProduct.DataBind();
        }

        private void SalesByProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
