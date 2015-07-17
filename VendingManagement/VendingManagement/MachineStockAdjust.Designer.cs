namespace VendingManagement
{
    partial class MachineStockAdjust
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
            this.TransferPanel = new System.Windows.Forms.SplitContainer();
            this.MachineTransferGridView = new System.Windows.Forms.DataGridView();
            this.WarehouseTransferGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRestock = new System.Windows.Forms.CheckBox();
            this.cbService = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbMaximumStock = new System.Windows.Forms.TextBox();
            this.tbMinimimStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMachineID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TransferControlPanel = new System.Windows.Forms.SplitContainer();
            this.label12 = new System.Windows.Forms.Label();
            this.tbProductTransferToWarehouse = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbQuantityTransferToWarehouse = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbProductTransferToMachine = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbQuantityTransferToMachine = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuyOne = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbPriceUpdate = new System.Windows.Forms.TextBox();
            this.btnPriceUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransferPanel)).BeginInit();
            this.TransferPanel.Panel1.SuspendLayout();
            this.TransferPanel.Panel2.SuspendLayout();
            this.TransferPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MachineTransferGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseTransferGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferControlPanel)).BeginInit();
            this.TransferControlPanel.Panel1.SuspendLayout();
            this.TransferControlPanel.Panel2.SuspendLayout();
            this.TransferControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TransferPanel
            // 
            this.TransferPanel.Location = new System.Drawing.Point(12, 146);
            this.TransferPanel.Name = "TransferPanel";
            // 
            // TransferPanel.Panel1
            // 
            this.TransferPanel.Panel1.Controls.Add(this.MachineTransferGridView);
            // 
            // TransferPanel.Panel2
            // 
            this.TransferPanel.Panel2.Controls.Add(this.WarehouseTransferGridView);
            this.TransferPanel.Size = new System.Drawing.Size(1081, 303);
            this.TransferPanel.SplitterDistance = 523;
            this.TransferPanel.TabIndex = 0;
            // 
            // MachineTransferGridView
            // 
            this.MachineTransferGridView.AllowUserToAddRows = false;
            this.MachineTransferGridView.AllowUserToDeleteRows = false;
            this.MachineTransferGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MachineTransferGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineTransferGridView.Location = new System.Drawing.Point(0, 0);
            this.MachineTransferGridView.Name = "MachineTransferGridView";
            this.MachineTransferGridView.ReadOnly = true;
            this.MachineTransferGridView.Size = new System.Drawing.Size(523, 303);
            this.MachineTransferGridView.TabIndex = 0;
            this.MachineTransferGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MachineTransferGridView_CellClick);
            // 
            // WarehouseTransferGridView
            // 
            this.WarehouseTransferGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseTransferGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarehouseTransferGridView.Location = new System.Drawing.Point(0, 0);
            this.WarehouseTransferGridView.Name = "WarehouseTransferGridView";
            this.WarehouseTransferGridView.Size = new System.Drawing.Size(554, 303);
            this.WarehouseTransferGridView.TabIndex = 0;
            this.WarehouseTransferGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarehouseTransferGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRestock);
            this.groupBox1.Controls.Add(this.cbService);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbLocation);
            this.groupBox1.Controls.Add(this.tbCity);
            this.groupBox1.Controls.Add(this.tbMaximumStock);
            this.groupBox1.Controls.Add(this.tbMinimimStock);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMachineID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Data";
            // 
            // cbRestock
            // 
            this.cbRestock.AutoSize = true;
            this.cbRestock.Location = new System.Drawing.Point(231, 51);
            this.cbRestock.Name = "cbRestock";
            this.cbRestock.Size = new System.Drawing.Size(29, 17);
            this.cbRestock.TabIndex = 13;
            this.cbRestock.Text = " ";
            this.cbRestock.UseVisualStyleBackColor = true;
            // 
            // cbService
            // 
            this.cbService.AutoSize = true;
            this.cbService.Location = new System.Drawing.Point(101, 51);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(29, 17);
            this.cbService.TabIndex = 12;
            this.cbService.Text = " ";
            this.cbService.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Restock Required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Service Required";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(367, 46);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.ReadOnly = true;
            this.tbLocation.Size = new System.Drawing.Size(100, 20);
            this.tbLocation.TabIndex = 9;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(367, 19);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 8;
            // 
            // tbMaximumStock
            // 
            this.tbMaximumStock.Location = new System.Drawing.Point(673, 49);
            this.tbMaximumStock.Name = "tbMaximumStock";
            this.tbMaximumStock.ReadOnly = true;
            this.tbMaximumStock.Size = new System.Drawing.Size(100, 20);
            this.tbMaximumStock.TabIndex = 7;
            // 
            // tbMinimimStock
            // 
            this.tbMinimimStock.Location = new System.Drawing.Point(673, 19);
            this.tbMinimimStock.Name = "tbMinimimStock";
            this.tbMinimimStock.ReadOnly = true;
            this.tbMinimimStock.Size = new System.Drawing.Size(100, 20);
            this.tbMinimimStock.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maximum Stock Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Minimum Stock Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "City";
            // 
            // tbMachineID
            // 
            this.tbMachineID.Location = new System.Drawing.Point(86, 20);
            this.tbMachineID.Name = "tbMachineID";
            this.tbMachineID.ReadOnly = true;
            this.tbMachineID.Size = new System.Drawing.Size(100, 20);
            this.tbMachineID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine ID# ";
            // 
            // TransferControlPanel
            // 
            this.TransferControlPanel.Location = new System.Drawing.Point(12, 455);
            this.TransferControlPanel.Name = "TransferControlPanel";
            // 
            // TransferControlPanel.Panel1
            // 
            this.TransferControlPanel.Panel1.Controls.Add(this.btnPriceUpdate);
            this.TransferControlPanel.Panel1.Controls.Add(this.tbPriceUpdate);
            this.TransferControlPanel.Panel1.Controls.Add(this.label12);
            this.TransferControlPanel.Panel1.Controls.Add(this.tbProductTransferToWarehouse);
            this.TransferControlPanel.Panel1.Controls.Add(this.label10);
            this.TransferControlPanel.Panel1.Controls.Add(this.tbQuantityTransferToWarehouse);
            this.TransferControlPanel.Panel1.Controls.Add(this.pictureBox1);
            // 
            // TransferControlPanel.Panel2
            // 
            this.TransferControlPanel.Panel2.Controls.Add(this.label13);
            this.TransferControlPanel.Panel2.Controls.Add(this.tbProductTransferToMachine);
            this.TransferControlPanel.Panel2.Controls.Add(this.label11);
            this.TransferControlPanel.Panel2.Controls.Add(this.tbQuantityTransferToMachine);
            this.TransferControlPanel.Panel2.Controls.Add(this.pictureBox2);
            this.TransferControlPanel.Size = new System.Drawing.Size(1081, 86);
            this.TransferControlPanel.SplitterDistance = 523;
            this.TransferControlPanel.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Product";
            // 
            // tbProductTransferToWarehouse
            // 
            this.tbProductTransferToWarehouse.Location = new System.Drawing.Point(299, 33);
            this.tbProductTransferToWarehouse.Name = "tbProductTransferToWarehouse";
            this.tbProductTransferToWarehouse.ReadOnly = true;
            this.tbProductTransferToWarehouse.Size = new System.Drawing.Size(100, 20);
            this.tbProductTransferToWarehouse.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Quantity";
            // 
            // tbQuantityTransferToWarehouse
            // 
            this.tbQuantityTransferToWarehouse.Location = new System.Drawing.Point(298, 6);
            this.tbQuantityTransferToWarehouse.Name = "tbQuantityTransferToWarehouse";
            this.tbQuantityTransferToWarehouse.Size = new System.Drawing.Size(100, 20);
            this.tbQuantityTransferToWarehouse.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::VendingManagement.Properties.Resources.arrow_3D_green_right;
            this.pictureBox1.Location = new System.Drawing.Point(417, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(252, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Product";
            // 
            // tbProductTransferToMachine
            // 
            this.tbProductTransferToMachine.Location = new System.Drawing.Point(146, 36);
            this.tbProductTransferToMachine.Name = "tbProductTransferToMachine";
            this.tbProductTransferToMachine.ReadOnly = true;
            this.tbProductTransferToMachine.Size = new System.Drawing.Size(100, 20);
            this.tbProductTransferToMachine.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Quantity";
            // 
            // tbQuantityTransferToMachine
            // 
            this.tbQuantityTransferToMachine.Location = new System.Drawing.Point(146, 10);
            this.tbQuantityTransferToMachine.Name = "tbQuantityTransferToMachine";
            this.tbQuantityTransferToMachine.Size = new System.Drawing.Size(100, 20);
            this.tbQuantityTransferToMachine.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::VendingManagement.Properties.Resources.arrow_3D_green_left;
            this.pictureBox2.Location = new System.Drawing.Point(77, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Trasnfer Stock from Machine back into Warehouse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(721, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Transfer Stock from Warehouse to Machine";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(939, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuyOne
            // 
            this.btnBuyOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyOne.Location = new System.Drawing.Point(191, 569);
            this.btnBuyOne.Name = "btnBuyOne";
            this.btnBuyOne.Size = new System.Drawing.Size(253, 23);
            this.btnBuyOne.TabIndex = 3;
            this.btnBuyOne.Text = "SIMULATE - BUY ONE CANDYBAR";
            this.btnBuyOne.UseVisualStyleBackColor = true;
            this.btnBuyOne.Click += new System.EventHandler(this.btnBuyOne_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(153, 599);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(426, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "NOTE: This button will simulate the customer buying a single candybar from this m" +
    "achine.";
            // 
            // tbPriceUpdate
            // 
            this.tbPriceUpdate.Location = new System.Drawing.Point(299, 60);
            this.tbPriceUpdate.Name = "tbPriceUpdate";
            this.tbPriceUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbPriceUpdate.TabIndex = 6;
            // 
            // btnPriceUpdate
            // 
            this.btnPriceUpdate.Location = new System.Drawing.Point(174, 58);
            this.btnPriceUpdate.Name = "btnPriceUpdate";
            this.btnPriceUpdate.Size = new System.Drawing.Size(119, 23);
            this.btnPriceUpdate.TabIndex = 7;
            this.btnPriceUpdate.Text = "Update Retail Price";
            this.btnPriceUpdate.UseVisualStyleBackColor = true;
            this.btnPriceUpdate.Click += new System.EventHandler(this.btnPriceUpdate_Click);
            // 
            // MachineStockAdjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 629);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnBuyOne);
            this.Controls.Add(this.TransferControlPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TransferPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "MachineStockAdjust";
            this.Text = "MachineStockAdjust";
            this.Load += new System.EventHandler(this.MachineStockAdjust_Load);
            this.TransferPanel.Panel1.ResumeLayout(false);
            this.TransferPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransferPanel)).EndInit();
            this.TransferPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MachineTransferGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseTransferGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TransferControlPanel.Panel1.ResumeLayout(false);
            this.TransferControlPanel.Panel1.PerformLayout();
            this.TransferControlPanel.Panel2.ResumeLayout(false);
            this.TransferControlPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferControlPanel)).EndInit();
            this.TransferControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer TransferPanel;
        private System.Windows.Forms.DataGridView MachineTransferGridView;
        private System.Windows.Forms.DataGridView WarehouseTransferGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMachineID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRestock;
        private System.Windows.Forms.CheckBox cbService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbMaximumStock;
        private System.Windows.Forms.TextBox tbMinimimStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer TransferControlPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbProductTransferToWarehouse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbQuantityTransferToWarehouse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbProductTransferToMachine;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbQuantityTransferToMachine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuyOne;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPriceUpdate;
        private System.Windows.Forms.TextBox tbPriceUpdate;
    }
}