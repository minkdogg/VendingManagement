using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//using iTextSharp;

namespace VendingManagement
{
    class Export
    {         
        public void ExportToPDFCollection(DataTable table)
        {
            int rowCount = 0;
            foreach (DataRow row in table.Rows)
            {
                rowCount++;
            }

            int columnCount = 1;
            foreach (DataColumn column in table.Columns)
            {
                columnCount++;
            }

            //PdfPTable pdfTable = new PdfPTable();
            //iTextSharp.text.Table textSharpTable = new iTextSharp.text.Table(columnCount, rowCount);
        }
    }
}
