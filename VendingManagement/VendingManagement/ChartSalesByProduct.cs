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
        Database database = new Database();

        public ChartSalesByProduct()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ChartSalesByProduct_Load(object sender, EventArgs e)
        {
            List<Product> data;
            ReportManager report = new ReportManager();
            data = this.database.SelectAllProduct();

            DataTable subtotals = report.reportInventoryCostItem(data);

            this.SalesByProduct.Titles.Add("Net Profit by Product");

            string productName = subtotals.Columns[0].ToString();
            SalesByProduct.Series["Series 1"].XValueMember = productName;

            //string netProfit = subtotals.Columns[1].ToString();
            //SalesByProduct.Series["Series 1"].YValueMember = netProfit;
            
            /*
            string[] seriesArray = { "Cats", "Dogs" };
            int[] pointsArray = { 1, 2 };

            this.SalesByProduct.Palette = ChartColorPalette.SeaGreen;

            this.SalesByProduct.Titles.Add("Pets");

            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.SalesByProduct.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);    
            }
            */
        }
    }
}
