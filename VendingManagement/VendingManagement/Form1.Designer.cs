namespace VendingManagement
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.businessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.machineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.databaseBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1152, 578);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = typeof(VendingManagement.Database);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(194, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(907, 317);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(194, 60);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(275, 60);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.businessToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.vehicleToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.machineToolStripMenuItem,
            this.productToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // businessToolStripMenuItem
            // 
            this.businessToolStripMenuItem.Name = "businessToolStripMenuItem";
            this.businessToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.businessToolStripMenuItem.Text = "Business";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cityToolStripMenuItem.Text = "City";
            // 
            // machineToolStripMenuItem
            // 
            this.machineToolStripMenuItem.Name = "machineToolStripMenuItem";
            this.machineToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.machineToolStripMenuItem.Text = "Machine";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.businesToolStripMenuItem,
            this.employeeToolStripMenuItem1,
            this.vehicleToolStripMenuItem1,
            this.transactionsToolStripMenuItem1,
            this.machineToolStripMenuItem1,
            this.productToolStripMenuItem1,
            this.cityToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // businesToolStripMenuItem
            // 
            this.businesToolStripMenuItem.Name = "businesToolStripMenuItem";
            this.businesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.businesToolStripMenuItem.Text = "Business";
            // 
            // employeeToolStripMenuItem1
            // 
            this.employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.employeeToolStripMenuItem1.Text = "Employee";
            // 
            // vehicleToolStripMenuItem1
            // 
            this.vehicleToolStripMenuItem1.Name = "vehicleToolStripMenuItem1";
            this.vehicleToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.vehicleToolStripMenuItem1.Text = "Vehicle";
            // 
            // transactionsToolStripMenuItem1
            // 
            this.transactionsToolStripMenuItem1.Name = "transactionsToolStripMenuItem1";
            this.transactionsToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.transactionsToolStripMenuItem1.Text = "Transactions";
            // 
            // machineToolStripMenuItem1
            // 
            this.machineToolStripMenuItem1.Name = "machineToolStripMenuItem1";
            this.machineToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.machineToolStripMenuItem1.Text = "Machine";
            // 
            // productToolStripMenuItem1
            // 
            this.productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            this.productToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.productToolStripMenuItem1.Text = "Product";
            // 
            // cityToolStripMenuItem1
            // 
            this.cityToolStripMenuItem1.Name = "cityToolStripMenuItem1";
            this.cityToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.cityToolStripMenuItem1.Text = "City";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 602);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem businessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem businesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem machineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem1;
        private System.Windows.Forms.BindingSource databaseBindingSource;
    }
}

