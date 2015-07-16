using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
        }
    }
}
