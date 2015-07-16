using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using VendingManagement;
using System.Xml;


namespace ExportUnitTest
{
    [TestClass]
    public class ExportUnitTest
    {
        Database database = new Database();
        ReportManager reportManager = new ReportManager();

        public ExportUnitTest()
        {
            this.database.generateInitialData();
            List<Product> data = this.database.SelectAllProduct();
            DataTable dataTable = reportManager.reportInventoryCostItem(data);
        }

        [TestMethod]
        public void ExportToPDFCollection(DataTable table)
        {
            ExportUnitTest exportUnitTest = new ExportUnitTest();

            int rowCount = 0;
            foreach (DataRow row in table.Rows)
            {
                rowCount++;
                MessageBox.Show(rowCount.ToString());
            }
        }
    }
}