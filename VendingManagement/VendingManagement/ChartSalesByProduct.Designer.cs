namespace VendingManagement
{
    partial class ChartSalesByProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SalesByProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.SalesByProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesByProduct
            // 
            chartArea1.Name = "ChartArea1";
            this.SalesByProduct.ChartAreas.Add(chartArea1);
            this.SalesByProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.SalesByProduct.Legends.Add(legend1);
            this.SalesByProduct.Location = new System.Drawing.Point(0, 0);
            this.SalesByProduct.Name = "SalesByProduct";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SalesByProduct.Series.Add(series1);
            this.SalesByProduct.Size = new System.Drawing.Size(575, 503);
            this.SalesByProduct.TabIndex = 0;
            this.SalesByProduct.Text = "chart1";
            // 
            // ChartSalesByProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 503);
            this.Controls.Add(this.SalesByProduct);
            this.Name = "ChartSalesByProduct";
            this.Text = "ChartSalesByProduct";
            this.Load += new System.EventHandler(this.ChartSalesByProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesByProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SalesByProduct;

    }
}