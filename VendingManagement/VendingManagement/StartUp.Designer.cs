﻿namespace VendingManagement
{
    partial class StartUp
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
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Product Warehouse");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Transactions");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Employees");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Vehicles");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Business", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("City List");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Revenue by City");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Item Sales by City");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("City", new System.Windows.Forms.TreeNode[] {
            treeNode44,
            treeNode45,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("All Machines");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Items by Machine");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Machine", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Sales by Product");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Inventory (Product)");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Sales by Machine");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Sales by Machine (Product)");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Sales by City");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Restock by Machine");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Reports", new System.Windows.Forms.TreeNode[] {
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56});
            this.Header = new System.Windows.Forms.Label();
            this.Business = new System.Windows.Forms.Button();
            this.City = new System.Windows.Forms.Button();
            this.Machine = new System.Windows.Forms.Button();
            this.LogIn = new System.Windows.Forms.Button();
            this.QuickLinks = new System.Windows.Forms.TabControl();
            this.Navigation = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Reports = new System.Windows.Forms.TabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.MainField = new System.Windows.Forms.TabControl();
            this.MainTab1 = new System.Windows.Forms.TabPage();
            this.BusinessTabs = new System.Windows.Forms.TabControl();
            this.BusinessProductWarehouse = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProductWarehouseDataGrid = new System.Windows.Forms.DataGridView();
            this.BusinessTransactions = new System.Windows.Forms.TabPage();
            this.TransactionsDataGrid = new System.Windows.Forms.DataGridView();
            this.BusinessEmployees = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.EmployeesDataGrid = new System.Windows.Forms.DataGridView();
            this.BusinessVehicles = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.VehiclesDataGrid = new System.Windows.Forms.DataGridView();
            this.MainTab2 = new System.Windows.Forms.TabPage();
            this.CityTabs = new System.Windows.Forms.TabControl();
            this.CityList = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.CityMachinesDataGrid = new System.Windows.Forms.DataGridView();
            this.RevenueByCity = new System.Windows.Forms.TabPage();
            this.CityTotalRevenueDataGrid = new System.Windows.Forms.DataGridView();
            this.ItemSalesByCity = new System.Windows.Forms.TabPage();
            this.CitySalesByItemDataGrid = new System.Windows.Forms.DataGridView();
            this.MainTab3 = new System.Windows.Forms.TabPage();
            this.MachineTabs = new System.Windows.Forms.TabControl();
            this.AllMachines = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.createServiceRequest = new System.Windows.Forms.Button();
            this.MachineListAllDataGrid = new System.Windows.Forms.DataGridView();
            this.ItemsByMachine = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.MachineProductItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.MainTab4 = new System.Windows.Forms.TabPage();
            this.ReportTabs = new System.Windows.Forms.TabControl();
            this.SalesProduct = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.PDFSalesByProduct = new System.Windows.Forms.Button();
            this.SalesProductGrid = new System.Windows.Forms.DataGridView();
            this.InventoryProduct = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.InventoryProductGrid = new System.Windows.Forms.DataGridView();
            this.SalesMachine = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.button13 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.SalesMachineGrid = new System.Windows.Forms.DataGridView();
            this.ReportsMachineProduct = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.SalesByMachineProduct = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SalesMachineProductGrid = new System.Windows.Forms.DataGridView();
            this.SalesCityMachine = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.SalesByCityCSV = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.SalesCityMachineGrid = new System.Windows.Forms.DataGridView();
            this.RestockMachine = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.RestockByMachineCSV = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.RestockMachineGrid = new System.Windows.Forms.DataGridView();
            this.GraphSalesByProduct = new System.Windows.Forms.Button();
            this.CSVSalesByProduct = new System.Windows.Forms.Button();
            this.QuickLinks.SuspendLayout();
            this.Navigation.SuspendLayout();
            this.Reports.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainField.SuspendLayout();
            this.MainTab1.SuspendLayout();
            this.BusinessTabs.SuspendLayout();
            this.BusinessProductWarehouse.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductWarehouseDataGrid)).BeginInit();
            this.BusinessTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGrid)).BeginInit();
            this.BusinessEmployees.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).BeginInit();
            this.BusinessVehicles.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclesDataGrid)).BeginInit();
            this.MainTab2.SuspendLayout();
            this.CityTabs.SuspendLayout();
            this.CityList.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityMachinesDataGrid)).BeginInit();
            this.RevenueByCity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityTotalRevenueDataGrid)).BeginInit();
            this.ItemSalesByCity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CitySalesByItemDataGrid)).BeginInit();
            this.MainTab3.SuspendLayout();
            this.MachineTabs.SuspendLayout();
            this.AllMachines.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MachineListAllDataGrid)).BeginInit();
            this.ItemsByMachine.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MachineProductItemsDataGrid)).BeginInit();
            this.MainTab4.SuspendLayout();
            this.ReportTabs.SuspendLayout();
            this.SalesProduct.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesProductGrid)).BeginInit();
            this.InventoryProduct.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryProductGrid)).BeginInit();
            this.SalesMachine.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesMachineGrid)).BeginInit();
            this.ReportsMachineProduct.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesMachineProductGrid)).BeginInit();
            this.SalesCityMachine.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesCityMachineGrid)).BeginInit();
            this.RestockMachine.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestockMachineGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Consolas", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(3, 18);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(346, 62);
            this.Header.TabIndex = 0;
            this.Header.Text = "VendorTRACK";
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // Business
            // 
            this.Business.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Business.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Business.Location = new System.Drawing.Point(407, 36);
            this.Business.Name = "Business";
            this.Business.Size = new System.Drawing.Size(121, 38);
            this.Business.TabIndex = 1;
            this.Business.Text = "BUSINESS";
            this.Business.UseVisualStyleBackColor = true;
            this.Business.Click += new System.EventHandler(this.Business_Click);
            // 
            // City
            // 
            this.City.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.City.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(538, 36);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(121, 37);
            this.City.TabIndex = 2;
            this.City.Text = "CITY";
            this.City.UseVisualStyleBackColor = true;
            this.City.Click += new System.EventHandler(this.City_Click);
            // 
            // Machine
            // 
            this.Machine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Machine.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Machine.Location = new System.Drawing.Point(669, 36);
            this.Machine.Name = "Machine";
            this.Machine.Size = new System.Drawing.Size(121, 37);
            this.Machine.TabIndex = 3;
            this.Machine.Text = "MACHINE";
            this.Machine.UseVisualStyleBackColor = true;
            this.Machine.Click += new System.EventHandler(this.button3_Click);
            // 
            // LogIn
            // 
            this.LogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogIn.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.Location = new System.Drawing.Point(984, 21);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 4;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            // 
            // QuickLinks
            // 
            this.QuickLinks.Controls.Add(this.Navigation);
            this.QuickLinks.Controls.Add(this.Reports);
            this.QuickLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickLinks.Location = new System.Drawing.Point(23, 161);
            this.QuickLinks.Name = "QuickLinks";
            this.QuickLinks.SelectedIndex = 0;
            this.QuickLinks.Size = new System.Drawing.Size(197, 402);
            this.QuickLinks.TabIndex = 6;
            // 
            // Navigation
            // 
            this.Navigation.Controls.Add(this.treeView1);
            this.Navigation.Location = new System.Drawing.Point(4, 22);
            this.Navigation.Name = "Navigation";
            this.Navigation.Padding = new System.Windows.Forms.Padding(3);
            this.Navigation.Size = new System.Drawing.Size(189, 376);
            this.Navigation.TabIndex = 0;
            this.Navigation.Text = "Navigation";
            this.Navigation.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode39.Name = "Product Warehouse";
            treeNode39.Text = "Product Warehouse";
            treeNode40.Name = "Transactions";
            treeNode40.Text = "Transactions";
            treeNode41.Name = "Employees";
            treeNode41.Text = "Employees";
            treeNode42.Name = "Vehicles";
            treeNode42.Text = "Vehicles";
            treeNode43.Name = "Business";
            treeNode43.Text = "Business";
            treeNode44.Name = "City List";
            treeNode44.Text = "City List";
            treeNode45.Name = "Revenue by City";
            treeNode45.Text = "Revenue by City";
            treeNode46.Name = "Item Sales by City";
            treeNode46.Text = "Item Sales by City";
            treeNode47.Name = "City";
            treeNode47.Text = "City";
            treeNode48.Name = "All Machines";
            treeNode48.Text = "All Machines";
            treeNode49.Name = "Items by Machine";
            treeNode49.Text = "Items by Machine";
            treeNode50.Name = "Machine";
            treeNode50.Text = "Machine";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode47,
            treeNode50});
            this.treeView1.Size = new System.Drawing.Size(183, 370);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.treeView2);
            this.Reports.Location = new System.Drawing.Point(4, 22);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Reports.Size = new System.Drawing.Size(189, 376);
            this.Reports.TabIndex = 1;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(3, 3);
            this.treeView2.Name = "treeView2";
            treeNode51.Name = "Sales by Product";
            treeNode51.Text = "Sales by Product";
            treeNode52.Name = "Inventory (Product)";
            treeNode52.Text = "Inventory (Product)";
            treeNode53.Name = "Sales by Machine";
            treeNode53.Text = "Sales by Machine";
            treeNode54.Name = "Sales by Machine (Product)";
            treeNode54.Text = "Sales by Machine (Product)";
            treeNode55.Name = "Sales by City";
            treeNode55.Text = "Sales by City";
            treeNode56.Name = "Restock by Machine";
            treeNode56.Text = "Restock by Machine";
            treeNode57.Name = "Reports";
            treeNode57.Text = "Reports";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode57});
            this.treeView2.ShowNodeToolTips = true;
            this.treeView2.Size = new System.Drawing.Size(183, 370);
            this.treeView2.TabIndex = 7;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quick Links";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1039, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1039, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.38095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.38095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.38095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.38095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.38095F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Header, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.City, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LogIn, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.Business, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Machine, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1062, 92);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(800, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "REPORTS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainField
            // 
            this.MainField.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MainField.Controls.Add(this.MainTab1);
            this.MainField.Controls.Add(this.MainTab2);
            this.MainField.Controls.Add(this.MainTab3);
            this.MainField.Controls.Add(this.MainTab4);
            this.MainField.Location = new System.Drawing.Point(263, 133);
            this.MainField.Multiline = true;
            this.MainField.Name = "MainField";
            this.MainField.SelectedIndex = 0;
            this.MainField.Size = new System.Drawing.Size(743, 434);
            this.MainField.TabIndex = 12;
            this.MainField.SelectedIndexChanged += new System.EventHandler(this.MainField_SelectedIndexChanged);
            // 
            // MainTab1
            // 
            this.MainTab1.Controls.Add(this.BusinessTabs);
            this.MainTab1.Location = new System.Drawing.Point(4, 25);
            this.MainTab1.Name = "MainTab1";
            this.MainTab1.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab1.Size = new System.Drawing.Size(735, 405);
            this.MainTab1.TabIndex = 0;
            this.MainTab1.Text = "Business";
            this.MainTab1.UseVisualStyleBackColor = true;
            // 
            // BusinessTabs
            // 
            this.BusinessTabs.Controls.Add(this.BusinessProductWarehouse);
            this.BusinessTabs.Controls.Add(this.BusinessTransactions);
            this.BusinessTabs.Controls.Add(this.BusinessEmployees);
            this.BusinessTabs.Controls.Add(this.BusinessVehicles);
            this.BusinessTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusinessTabs.Location = new System.Drawing.Point(3, 3);
            this.BusinessTabs.Name = "BusinessTabs";
            this.BusinessTabs.SelectedIndex = 0;
            this.BusinessTabs.Size = new System.Drawing.Size(729, 399);
            this.BusinessTabs.TabIndex = 0;
            // 
            // BusinessProductWarehouse
            // 
            this.BusinessProductWarehouse.Controls.Add(this.tableLayoutPanel2);
            this.BusinessProductWarehouse.Controls.Add(this.ProductWarehouseDataGrid);
            this.BusinessProductWarehouse.Location = new System.Drawing.Point(4, 22);
            this.BusinessProductWarehouse.Name = "BusinessProductWarehouse";
            this.BusinessProductWarehouse.Padding = new System.Windows.Forms.Padding(3);
            this.BusinessProductWarehouse.Size = new System.Drawing.Size(721, 373);
            this.BusinessProductWarehouse.TabIndex = 3;
            this.BusinessProductWarehouse.Text = "Product Warehouse";
            this.BusinessProductWarehouse.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(715, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "Purchase Stock";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(110, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 27);
            this.button3.TabIndex = 1;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ProductWarehouseDataGrid
            // 
            this.ProductWarehouseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductWarehouseDataGrid.Location = new System.Drawing.Point(3, 39);
            this.ProductWarehouseDataGrid.Name = "ProductWarehouseDataGrid";
            this.ProductWarehouseDataGrid.Size = new System.Drawing.Size(715, 331);
            this.ProductWarehouseDataGrid.TabIndex = 0;
            // 
            // BusinessTransactions
            // 
            this.BusinessTransactions.Controls.Add(this.TransactionsDataGrid);
            this.BusinessTransactions.Location = new System.Drawing.Point(4, 22);
            this.BusinessTransactions.Name = "BusinessTransactions";
            this.BusinessTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.BusinessTransactions.Size = new System.Drawing.Size(721, 373);
            this.BusinessTransactions.TabIndex = 2;
            this.BusinessTransactions.Text = "Transactions";
            this.BusinessTransactions.UseVisualStyleBackColor = true;
            // 
            // TransactionsDataGrid
            // 
            this.TransactionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionsDataGrid.Location = new System.Drawing.Point(3, 3);
            this.TransactionsDataGrid.Name = "TransactionsDataGrid";
            this.TransactionsDataGrid.Size = new System.Drawing.Size(715, 367);
            this.TransactionsDataGrid.TabIndex = 0;
            // 
            // BusinessEmployees
            // 
            this.BusinessEmployees.Controls.Add(this.tableLayoutPanel3);
            this.BusinessEmployees.Controls.Add(this.EmployeesDataGrid);
            this.BusinessEmployees.Location = new System.Drawing.Point(4, 22);
            this.BusinessEmployees.Name = "BusinessEmployees";
            this.BusinessEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.BusinessEmployees.Size = new System.Drawing.Size(721, 373);
            this.BusinessEmployees.TabIndex = 0;
            this.BusinessEmployees.Text = "Employees";
            this.BusinessEmployees.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(715, 34);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 27);
            this.button4.TabIndex = 0;
            this.button4.Text = "Add New";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.Location = new System.Drawing.Point(110, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 27);
            this.button5.TabIndex = 1;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // EmployeesDataGrid
            // 
            this.EmployeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGrid.Location = new System.Drawing.Point(3, 39);
            this.EmployeesDataGrid.Name = "EmployeesDataGrid";
            this.EmployeesDataGrid.Size = new System.Drawing.Size(715, 331);
            this.EmployeesDataGrid.TabIndex = 0;
            // 
            // BusinessVehicles
            // 
            this.BusinessVehicles.Controls.Add(this.tableLayoutPanel4);
            this.BusinessVehicles.Controls.Add(this.VehiclesDataGrid);
            this.BusinessVehicles.Location = new System.Drawing.Point(4, 22);
            this.BusinessVehicles.Name = "BusinessVehicles";
            this.BusinessVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.BusinessVehicles.Size = new System.Drawing.Size(721, 373);
            this.BusinessVehicles.TabIndex = 1;
            this.BusinessVehicles.Text = "Vehicles";
            this.BusinessVehicles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button7, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(715, 34);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 27);
            this.button6.TabIndex = 0;
            this.button6.Text = "Add New";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button7.Location = new System.Drawing.Point(110, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 27);
            this.button7.TabIndex = 1;
            this.button7.Text = "Remove";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // VehiclesDataGrid
            // 
            this.VehiclesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiclesDataGrid.Location = new System.Drawing.Point(3, 39);
            this.VehiclesDataGrid.Name = "VehiclesDataGrid";
            this.VehiclesDataGrid.Size = new System.Drawing.Size(715, 331);
            this.VehiclesDataGrid.TabIndex = 0;
            // 
            // MainTab2
            // 
            this.MainTab2.Controls.Add(this.CityTabs);
            this.MainTab2.Location = new System.Drawing.Point(4, 25);
            this.MainTab2.Name = "MainTab2";
            this.MainTab2.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab2.Size = new System.Drawing.Size(735, 405);
            this.MainTab2.TabIndex = 1;
            this.MainTab2.Text = "City";
            this.MainTab2.UseVisualStyleBackColor = true;
            // 
            // CityTabs
            // 
            this.CityTabs.Controls.Add(this.CityList);
            this.CityTabs.Controls.Add(this.RevenueByCity);
            this.CityTabs.Controls.Add(this.ItemSalesByCity);
            this.CityTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityTabs.Location = new System.Drawing.Point(3, 3);
            this.CityTabs.Name = "CityTabs";
            this.CityTabs.SelectedIndex = 0;
            this.CityTabs.Size = new System.Drawing.Size(729, 399);
            this.CityTabs.TabIndex = 0;
            // 
            // CityList
            // 
            this.CityList.Controls.Add(this.tableLayoutPanel5);
            this.CityList.Controls.Add(this.CityMachinesDataGrid);
            this.CityList.Location = new System.Drawing.Point(4, 22);
            this.CityList.Name = "CityList";
            this.CityList.Padding = new System.Windows.Forms.Padding(3);
            this.CityList.Size = new System.Drawing.Size(721, 373);
            this.CityList.TabIndex = 0;
            this.CityList.Text = "City List";
            this.CityList.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Controls.Add(this.button8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.button9, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(715, 34);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 27);
            this.button8.TabIndex = 0;
            this.button8.Text = "Add New";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button9.Location = new System.Drawing.Point(110, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 27);
            this.button9.TabIndex = 1;
            this.button9.Text = "Remove";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // CityMachinesDataGrid
            // 
            this.CityMachinesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CityMachinesDataGrid.Location = new System.Drawing.Point(3, 39);
            this.CityMachinesDataGrid.Name = "CityMachinesDataGrid";
            this.CityMachinesDataGrid.Size = new System.Drawing.Size(715, 331);
            this.CityMachinesDataGrid.TabIndex = 0;
            // 
            // RevenueByCity
            // 
            this.RevenueByCity.Controls.Add(this.CityTotalRevenueDataGrid);
            this.RevenueByCity.Location = new System.Drawing.Point(4, 22);
            this.RevenueByCity.Name = "RevenueByCity";
            this.RevenueByCity.Padding = new System.Windows.Forms.Padding(3);
            this.RevenueByCity.Size = new System.Drawing.Size(721, 373);
            this.RevenueByCity.TabIndex = 1;
            this.RevenueByCity.Text = "Revenue by City";
            this.RevenueByCity.UseVisualStyleBackColor = true;
            // 
            // CityTotalRevenueDataGrid
            // 
            this.CityTotalRevenueDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CityTotalRevenueDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityTotalRevenueDataGrid.Location = new System.Drawing.Point(3, 3);
            this.CityTotalRevenueDataGrid.Name = "CityTotalRevenueDataGrid";
            this.CityTotalRevenueDataGrid.Size = new System.Drawing.Size(715, 367);
            this.CityTotalRevenueDataGrid.TabIndex = 0;
            // 
            // ItemSalesByCity
            // 
            this.ItemSalesByCity.Controls.Add(this.CitySalesByItemDataGrid);
            this.ItemSalesByCity.Location = new System.Drawing.Point(4, 22);
            this.ItemSalesByCity.Name = "ItemSalesByCity";
            this.ItemSalesByCity.Padding = new System.Windows.Forms.Padding(3);
            this.ItemSalesByCity.Size = new System.Drawing.Size(721, 373);
            this.ItemSalesByCity.TabIndex = 2;
            this.ItemSalesByCity.Text = "Item Sales by City";
            this.ItemSalesByCity.UseVisualStyleBackColor = true;
            // 
            // CitySalesByItemDataGrid
            // 
            this.CitySalesByItemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CitySalesByItemDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CitySalesByItemDataGrid.Location = new System.Drawing.Point(3, 3);
            this.CitySalesByItemDataGrid.Name = "CitySalesByItemDataGrid";
            this.CitySalesByItemDataGrid.Size = new System.Drawing.Size(715, 367);
            this.CitySalesByItemDataGrid.TabIndex = 0;
            // 
            // MainTab3
            // 
            this.MainTab3.Controls.Add(this.MachineTabs);
            this.MainTab3.Location = new System.Drawing.Point(4, 25);
            this.MainTab3.Name = "MainTab3";
            this.MainTab3.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab3.Size = new System.Drawing.Size(735, 405);
            this.MainTab3.TabIndex = 2;
            this.MainTab3.Text = "Machine";
            this.MainTab3.UseVisualStyleBackColor = true;
            // 
            // MachineTabs
            // 
            this.MachineTabs.Controls.Add(this.AllMachines);
            this.MachineTabs.Controls.Add(this.ItemsByMachine);
            this.MachineTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineTabs.Location = new System.Drawing.Point(3, 3);
            this.MachineTabs.Name = "MachineTabs";
            this.MachineTabs.SelectedIndex = 0;
            this.MachineTabs.Size = new System.Drawing.Size(729, 399);
            this.MachineTabs.TabIndex = 0;
            // 
            // AllMachines
            // 
            this.AllMachines.Controls.Add(this.tableLayoutPanel8);
            this.AllMachines.Controls.Add(this.MachineListAllDataGrid);
            this.AllMachines.Location = new System.Drawing.Point(4, 22);
            this.AllMachines.Name = "AllMachines";
            this.AllMachines.Padding = new System.Windows.Forms.Padding(3);
            this.AllMachines.Size = new System.Drawing.Size(721, 373);
            this.AllMachines.TabIndex = 0;
            this.AllMachines.Text = "All Machines";
            this.AllMachines.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel8.Controls.Add(this.button10, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.button14, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.button15, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.createServiceRequest, 3, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(715, 34);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button10.Location = new System.Drawing.Point(227, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(97, 27);
            this.button10.TabIndex = 2;
            this.button10.Text = "Adjust Inventory";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button14.Location = new System.Drawing.Point(3, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(101, 27);
            this.button14.TabIndex = 0;
            this.button14.Text = "Add New";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button15.Location = new System.Drawing.Point(115, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(97, 27);
            this.button15.TabIndex = 1;
            this.button15.Text = "Remove";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // createServiceRequest
            // 
            this.createServiceRequest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.createServiceRequest.Location = new System.Drawing.Point(573, 3);
            this.createServiceRequest.Name = "createServiceRequest";
            this.createServiceRequest.Size = new System.Drawing.Size(139, 28);
            this.createServiceRequest.TabIndex = 3;
            this.createServiceRequest.Text = "Create Service Request";
            this.createServiceRequest.UseVisualStyleBackColor = true;
            this.createServiceRequest.Click += new System.EventHandler(this.createServiceRequest_Click);
            // 
            // MachineListAllDataGrid
            // 
            this.MachineListAllDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MachineListAllDataGrid.Location = new System.Drawing.Point(3, 39);
            this.MachineListAllDataGrid.Name = "MachineListAllDataGrid";
            this.MachineListAllDataGrid.Size = new System.Drawing.Size(715, 331);
            this.MachineListAllDataGrid.TabIndex = 0;
            // 
            // ItemsByMachine
            // 
            this.ItemsByMachine.Controls.Add(this.tableLayoutPanel10);
            this.ItemsByMachine.Controls.Add(this.MachineProductItemsDataGrid);
            this.ItemsByMachine.Location = new System.Drawing.Point(4, 22);
            this.ItemsByMachine.Name = "ItemsByMachine";
            this.ItemsByMachine.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsByMachine.Size = new System.Drawing.Size(721, 373);
            this.ItemsByMachine.TabIndex = 2;
            this.ItemsByMachine.Text = "Items by Machine";
            this.ItemsByMachine.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel10.Controls.Add(this.button18, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.button19, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(715, 34);
            this.tableLayoutPanel10.TabIndex = 4;
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button18.Location = new System.Drawing.Point(3, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(101, 27);
            this.button18.TabIndex = 0;
            this.button18.Text = "Add New";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button19.Location = new System.Drawing.Point(110, 3);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(97, 27);
            this.button19.TabIndex = 1;
            this.button19.Text = "Remove";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // MachineProductItemsDataGrid
            // 
            this.MachineProductItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MachineProductItemsDataGrid.Location = new System.Drawing.Point(3, 39);
            this.MachineProductItemsDataGrid.Name = "MachineProductItemsDataGrid";
            this.MachineProductItemsDataGrid.Size = new System.Drawing.Size(715, 331);
            this.MachineProductItemsDataGrid.TabIndex = 0;
            // 
            // MainTab4
            // 
            this.MainTab4.Controls.Add(this.ReportTabs);
            this.MainTab4.Location = new System.Drawing.Point(4, 25);
            this.MainTab4.Name = "MainTab4";
            this.MainTab4.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab4.Size = new System.Drawing.Size(735, 405);
            this.MainTab4.TabIndex = 3;
            this.MainTab4.Text = "Reports";
            this.MainTab4.UseVisualStyleBackColor = true;
            // 
            // ReportTabs
            // 
            this.ReportTabs.Controls.Add(this.SalesProduct);
            this.ReportTabs.Controls.Add(this.InventoryProduct);
            this.ReportTabs.Controls.Add(this.SalesMachine);
            this.ReportTabs.Controls.Add(this.ReportsMachineProduct);
            this.ReportTabs.Controls.Add(this.SalesCityMachine);
            this.ReportTabs.Controls.Add(this.RestockMachine);
            this.ReportTabs.Location = new System.Drawing.Point(3, 3);
            this.ReportTabs.Name = "ReportTabs";
            this.ReportTabs.SelectedIndex = 0;
            this.ReportTabs.Size = new System.Drawing.Size(729, 399);
            this.ReportTabs.TabIndex = 0;
            // 
            // SalesProduct
            // 
            this.SalesProduct.Controls.Add(this.tableLayoutPanel6);
            this.SalesProduct.Location = new System.Drawing.Point(4, 22);
            this.SalesProduct.Name = "SalesProduct";
            this.SalesProduct.Padding = new System.Windows.Forms.Padding(3);
            this.SalesProduct.Size = new System.Drawing.Size(721, 373);
            this.SalesProduct.TabIndex = 0;
            this.SalesProduct.Text = "Sales by Product";
            this.SalesProduct.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.SalesProductGrid, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(715, 367);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.Controls.Add(this.GraphSalesByProduct, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.CSVSalesByProduct, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.PDFSalesByProduct, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(709, 30);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // PDFSalesByProduct
            // 
            this.PDFSalesByProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PDFSalesByProduct.Location = new System.Drawing.Point(3, 3);
            this.PDFSalesByProduct.Name = "PDFSalesByProduct";
            this.PDFSalesByProduct.Size = new System.Drawing.Size(92, 23);
            this.PDFSalesByProduct.TabIndex = 1;
            this.PDFSalesByProduct.Text = "Create PDF";
            this.PDFSalesByProduct.UseVisualStyleBackColor = true;
            this.PDFSalesByProduct.Click += new System.EventHandler(this.Export_Click);
            // 
            // SalesProductGrid
            // 
            this.SalesProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesProductGrid.Location = new System.Drawing.Point(3, 39);
            this.SalesProductGrid.Name = "SalesProductGrid";
            this.SalesProductGrid.Size = new System.Drawing.Size(709, 325);
            this.SalesProductGrid.TabIndex = 0;
            // 
            // InventoryProduct
            // 
            this.InventoryProduct.Controls.Add(this.tableLayoutPanel9);
            this.InventoryProduct.Location = new System.Drawing.Point(4, 22);
            this.InventoryProduct.Name = "InventoryProduct";
            this.InventoryProduct.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryProduct.Size = new System.Drawing.Size(721, 373);
            this.InventoryProduct.TabIndex = 1;
            this.InventoryProduct.Text = "Inventory - Product";
            this.InventoryProduct.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.InventoryProductGrid, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(715, 367);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel11.Controls.Add(this.button11, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.button12, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(709, 30);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button11.Location = new System.Drawing.Point(109, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(92, 23);
            this.button11.TabIndex = 2;
            this.button11.Text = "Create CSV";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button12.Location = new System.Drawing.Point(3, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(92, 23);
            this.button12.TabIndex = 1;
            this.button12.Text = "Create PDF";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // InventoryProductGrid
            // 
            this.InventoryProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryProductGrid.Location = new System.Drawing.Point(3, 39);
            this.InventoryProductGrid.Name = "InventoryProductGrid";
            this.InventoryProductGrid.Size = new System.Drawing.Size(709, 325);
            this.InventoryProductGrid.TabIndex = 0;
            // 
            // SalesMachine
            // 
            this.SalesMachine.Controls.Add(this.tableLayoutPanel12);
            this.SalesMachine.Location = new System.Drawing.Point(4, 22);
            this.SalesMachine.Name = "SalesMachine";
            this.SalesMachine.Padding = new System.Windows.Forms.Padding(3);
            this.SalesMachine.Size = new System.Drawing.Size(721, 373);
            this.SalesMachine.TabIndex = 2;
            this.SalesMachine.Text = "Sales by Machine";
            this.SalesMachine.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.SalesMachineGrid, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(715, 367);
            this.tableLayoutPanel12.TabIndex = 2;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel13.Controls.Add(this.button13, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.button16, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(709, 30);
            this.tableLayoutPanel13.TabIndex = 1;
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button13.Location = new System.Drawing.Point(109, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(92, 23);
            this.button13.TabIndex = 2;
            this.button13.Text = "Create CSV";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button16.Location = new System.Drawing.Point(3, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(92, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "Create PDF";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click_1);
            // 
            // SalesMachineGrid
            // 
            this.SalesMachineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesMachineGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesMachineGrid.Location = new System.Drawing.Point(3, 39);
            this.SalesMachineGrid.Name = "SalesMachineGrid";
            this.SalesMachineGrid.Size = new System.Drawing.Size(709, 325);
            this.SalesMachineGrid.TabIndex = 0;
            // 
            // ReportsMachineProduct
            // 
            this.ReportsMachineProduct.Controls.Add(this.tableLayoutPanel14);
            this.ReportsMachineProduct.Location = new System.Drawing.Point(4, 22);
            this.ReportsMachineProduct.Name = "ReportsMachineProduct";
            this.ReportsMachineProduct.Padding = new System.Windows.Forms.Padding(3);
            this.ReportsMachineProduct.Size = new System.Drawing.Size(721, 373);
            this.ReportsMachineProduct.TabIndex = 3;
            this.ReportsMachineProduct.Text = "Sales by Machine - Product";
            this.ReportsMachineProduct.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.SalesMachineProductGrid, 0, 1);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(715, 367);
            this.tableLayoutPanel14.TabIndex = 2;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel15.Controls.Add(this.SalesByMachineProduct, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.button20, 0, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(709, 30);
            this.tableLayoutPanel15.TabIndex = 1;
            // 
            // SalesByMachineProduct
            // 
            this.SalesByMachineProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SalesByMachineProduct.Location = new System.Drawing.Point(109, 3);
            this.SalesByMachineProduct.Name = "SalesByMachineProduct";
            this.SalesByMachineProduct.Size = new System.Drawing.Size(92, 23);
            this.SalesByMachineProduct.TabIndex = 2;
            this.SalesByMachineProduct.Text = "Create CSV";
            this.SalesByMachineProduct.UseVisualStyleBackColor = true;
            this.SalesByMachineProduct.Click += new System.EventHandler(this.SalesByMachineProduct_Click);
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button20.Location = new System.Drawing.Point(3, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(92, 23);
            this.button20.TabIndex = 1;
            this.button20.Text = "Create PDF";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // SalesMachineProductGrid
            // 
            this.SalesMachineProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesMachineProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesMachineProductGrid.Location = new System.Drawing.Point(3, 39);
            this.SalesMachineProductGrid.Name = "SalesMachineProductGrid";
            this.SalesMachineProductGrid.Size = new System.Drawing.Size(709, 325);
            this.SalesMachineProductGrid.TabIndex = 0;
            // 
            // SalesCityMachine
            // 
            this.SalesCityMachine.Controls.Add(this.tableLayoutPanel16);
            this.SalesCityMachine.Location = new System.Drawing.Point(4, 22);
            this.SalesCityMachine.Name = "SalesCityMachine";
            this.SalesCityMachine.Padding = new System.Windows.Forms.Padding(3);
            this.SalesCityMachine.Size = new System.Drawing.Size(721, 373);
            this.SalesCityMachine.TabIndex = 4;
            this.SalesCityMachine.Text = "Sales by City ";
            this.SalesCityMachine.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel17, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.SalesCityMachineGrid, 0, 1);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(715, 367);
            this.tableLayoutPanel16.TabIndex = 2;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 3;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel17.Controls.Add(this.SalesByCityCSV, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.button22, 0, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 1;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(709, 30);
            this.tableLayoutPanel17.TabIndex = 1;
            // 
            // SalesByCityCSV
            // 
            this.SalesByCityCSV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SalesByCityCSV.Location = new System.Drawing.Point(109, 3);
            this.SalesByCityCSV.Name = "SalesByCityCSV";
            this.SalesByCityCSV.Size = new System.Drawing.Size(92, 23);
            this.SalesByCityCSV.TabIndex = 2;
            this.SalesByCityCSV.Text = "Create CSV";
            this.SalesByCityCSV.UseVisualStyleBackColor = true;
            this.SalesByCityCSV.Click += new System.EventHandler(this.SalesByCityCSV_Click);
            // 
            // button22
            // 
            this.button22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button22.Location = new System.Drawing.Point(3, 3);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(92, 23);
            this.button22.TabIndex = 1;
            this.button22.Text = "Create PDF";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // SalesCityMachineGrid
            // 
            this.SalesCityMachineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesCityMachineGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesCityMachineGrid.Location = new System.Drawing.Point(3, 39);
            this.SalesCityMachineGrid.Name = "SalesCityMachineGrid";
            this.SalesCityMachineGrid.Size = new System.Drawing.Size(709, 325);
            this.SalesCityMachineGrid.TabIndex = 0;
            // 
            // RestockMachine
            // 
            this.RestockMachine.Controls.Add(this.tableLayoutPanel18);
            this.RestockMachine.Location = new System.Drawing.Point(4, 22);
            this.RestockMachine.Name = "RestockMachine";
            this.RestockMachine.Padding = new System.Windows.Forms.Padding(3);
            this.RestockMachine.Size = new System.Drawing.Size(721, 373);
            this.RestockMachine.TabIndex = 5;
            this.RestockMachine.Text = "Restock by Machine";
            this.RestockMachine.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Controls.Add(this.tableLayoutPanel19, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.RestockMachineGrid, 0, 1);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 2;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(715, 367);
            this.tableLayoutPanel18.TabIndex = 2;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 3;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel19.Controls.Add(this.RestockByMachineCSV, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.button24, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(709, 30);
            this.tableLayoutPanel19.TabIndex = 1;
            // 
            // RestockByMachineCSV
            // 
            this.RestockByMachineCSV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RestockByMachineCSV.Location = new System.Drawing.Point(109, 3);
            this.RestockByMachineCSV.Name = "RestockByMachineCSV";
            this.RestockByMachineCSV.Size = new System.Drawing.Size(92, 23);
            this.RestockByMachineCSV.TabIndex = 2;
            this.RestockByMachineCSV.Text = "Create CSV";
            this.RestockByMachineCSV.UseVisualStyleBackColor = true;
            this.RestockByMachineCSV.Click += new System.EventHandler(this.RestockByMachineCSV_Click);
            // 
            // button24
            // 
            this.button24.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button24.Location = new System.Drawing.Point(3, 3);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(92, 23);
            this.button24.TabIndex = 1;
            this.button24.Text = "Create PDF";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // RestockMachineGrid
            // 
            this.RestockMachineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestockMachineGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestockMachineGrid.Location = new System.Drawing.Point(3, 39);
            this.RestockMachineGrid.Name = "RestockMachineGrid";
            this.RestockMachineGrid.Size = new System.Drawing.Size(709, 325);
            this.RestockMachineGrid.TabIndex = 0;
            // 
            // GraphSalesByProduct
            // 
            this.GraphSalesByProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GraphSalesByProduct.Location = new System.Drawing.Point(215, 3);
            this.GraphSalesByProduct.Name = "GraphSalesByProduct";
            this.GraphSalesByProduct.Size = new System.Drawing.Size(92, 23);
            this.GraphSalesByProduct.TabIndex = 3;
            this.GraphSalesByProduct.Text = "Generate Graph";
            this.GraphSalesByProduct.UseVisualStyleBackColor = true;
            this.GraphSalesByProduct.Click += new System.EventHandler(this.GraphSalesByProduct_Click);
            // 
            // CSVSalesByProduct
            // 
            this.CSVSalesByProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CSVSalesByProduct.Location = new System.Drawing.Point(109, 3);
            this.CSVSalesByProduct.Name = "CSVSalesByProduct";
            this.CSVSalesByProduct.Size = new System.Drawing.Size(92, 23);
            this.CSVSalesByProduct.TabIndex = 2;
            this.CSVSalesByProduct.Text = "Create CSV";
            this.CSVSalesByProduct.UseVisualStyleBackColor = true;
            this.CSVSalesByProduct.Click += new System.EventHandler(this.CSVSalesByProduct_Click);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 590);
            this.Controls.Add(this.MainField);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuickLinks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartUp";
            this.Text = "StartUp";
            this.Load += new System.EventHandler(this.StartUp_Load);
            this.QuickLinks.ResumeLayout(false);
            this.Navigation.ResumeLayout(false);
            this.Reports.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MainField.ResumeLayout(false);
            this.MainTab1.ResumeLayout(false);
            this.BusinessTabs.ResumeLayout(false);
            this.BusinessProductWarehouse.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductWarehouseDataGrid)).EndInit();
            this.BusinessTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGrid)).EndInit();
            this.BusinessEmployees.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).EndInit();
            this.BusinessVehicles.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VehiclesDataGrid)).EndInit();
            this.MainTab2.ResumeLayout(false);
            this.CityTabs.ResumeLayout(false);
            this.CityList.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CityMachinesDataGrid)).EndInit();
            this.RevenueByCity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CityTotalRevenueDataGrid)).EndInit();
            this.ItemSalesByCity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CitySalesByItemDataGrid)).EndInit();
            this.MainTab3.ResumeLayout(false);
            this.MachineTabs.ResumeLayout(false);
            this.AllMachines.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MachineListAllDataGrid)).EndInit();
            this.ItemsByMachine.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MachineProductItemsDataGrid)).EndInit();
            this.MainTab4.ResumeLayout(false);
            this.ReportTabs.ResumeLayout(false);
            this.SalesProduct.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesProductGrid)).EndInit();
            this.InventoryProduct.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryProductGrid)).EndInit();
            this.SalesMachine.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesMachineGrid)).EndInit();
            this.ReportsMachineProduct.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesMachineProductGrid)).EndInit();
            this.SalesCityMachine.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesCityMachineGrid)).EndInit();
            this.RestockMachine.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RestockMachineGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button Business;
        private System.Windows.Forms.Button City;
        private System.Windows.Forms.Button Machine;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.TabControl QuickLinks;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl MainField;
        private System.Windows.Forms.TabPage MainTab2;
        private System.Windows.Forms.TabPage MainTab3;
        private System.Windows.Forms.TabControl BusinessTabs;
        private System.Windows.Forms.TabPage BusinessVehicles;
        private System.Windows.Forms.TabPage BusinessTransactions;
        private System.Windows.Forms.TabPage Navigation;
        private System.Windows.Forms.TabControl CityTabs;
        private System.Windows.Forms.TabPage CityList;
        private System.Windows.Forms.TabPage RevenueByCity;
        private System.Windows.Forms.TabPage ItemSalesByCity;
        private System.Windows.Forms.TabControl MachineTabs;
        private System.Windows.Forms.TabPage AllMachines;
        private System.Windows.Forms.TabPage ItemsByMachine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage MainTab4;
        private System.Windows.Forms.TabControl ReportTabs;
        private System.Windows.Forms.TabPage SalesProduct;
        private System.Windows.Forms.TabPage InventoryProduct;
        private System.Windows.Forms.TabPage SalesMachine;
        private System.Windows.Forms.TabPage ReportsMachineProduct;
        private System.Windows.Forms.DataGridView EmployeesDataGrid;
        private System.Windows.Forms.DataGridView VehiclesDataGrid;
        private System.Windows.Forms.DataGridView TransactionsDataGrid;
        private System.Windows.Forms.DataGridView CitySalesByItemDataGrid;
        private System.Windows.Forms.DataGridView MachineListAllDataGrid;
        private System.Windows.Forms.DataGridView MachineProductItemsDataGrid;
        private System.Windows.Forms.DataGridView SalesProductGrid;
        private System.Windows.Forms.TabPage MainTab1;
        private System.Windows.Forms.TabPage BusinessEmployees;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView CityMachinesDataGrid;
        private System.Windows.Forms.DataGridView CityTotalRevenueDataGrid;
        private System.Windows.Forms.TabPage BusinessProductWarehouse;
        private System.Windows.Forms.DataGridView ProductWarehouseDataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TabPage SalesCityMachine;
        private System.Windows.Forms.Button PDFSalesByProduct;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TabPage RestockMachine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridView InventoryProductGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.DataGridView SalesMachineGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Button SalesByMachineProduct;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.DataGridView SalesMachineProductGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Button SalesByCityCSV;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.DataGridView SalesCityMachineGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.Button RestockByMachineCSV;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.DataGridView RestockMachineGrid;
        private System.Windows.Forms.Button createServiceRequest;
        private System.Windows.Forms.Button GraphSalesByProduct;
        private System.Windows.Forms.Button CSVSalesByProduct;

    }
}