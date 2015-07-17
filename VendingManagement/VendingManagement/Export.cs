using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.collection;

namespace VendingManagement
{
    class Export
    {         
        public void ExportToPDFCollection(DataGridView dataGridView, string fileName)
        {
            int columnCount = 0;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                columnCount++;
            }

            //Create iTextSharp Table with columnCount
            PdfPTable pdfTable = new PdfPTable(dataGridView.ColumnCount);
            PdfPCell headerCell = new PdfPCell(new Phrase(fileName));
            headerCell.Colspan = columnCount;
            pdfTable.AddCell(headerCell);

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
                
                headerCell.Colspan++;
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }
            }

            //Exporting to PDF
            /*
            string folderPath = @"C:\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            */
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.LETTER, 10, 10, 10, 10);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }
    }
}