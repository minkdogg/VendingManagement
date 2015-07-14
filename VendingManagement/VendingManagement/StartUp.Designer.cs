namespace VendingManagement
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
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Employees");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Vehicles");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Transactions");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Business", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Machines");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Total Revenue");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Sales by Item");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("City", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("List All");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Type");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Items");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Machine", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Total Profit");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Top Selling Items");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Profit Margin by Item");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Sales by City");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Reports", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33});
            this.Header = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Consolas", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(346, 62);
            this.Header.TabIndex = 0;
            this.Header.Text = "VendorTRACK";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(399, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Business";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(546, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "City";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(693, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Machine";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(959, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Log In";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 6);
            this.treeView1.Name = "treeView1";
            treeNode18.Name = "Employees";
            treeNode18.Text = "Employees";
            treeNode19.Name = "Vehicles";
            treeNode19.Text = "Vehicles";
            treeNode20.Name = "Transactions";
            treeNode20.Text = "Transactions";
            treeNode21.Name = "Business";
            treeNode21.Text = "Business";
            treeNode22.Name = "Machines";
            treeNode22.Text = "Machines";
            treeNode23.Name = "Total Revenue";
            treeNode23.Text = "Total Revenue";
            treeNode24.Name = "Sales by Item";
            treeNode24.Text = "Sales by Item";
            treeNode25.Name = "City";
            treeNode25.Text = "City";
            treeNode26.Name = "List All";
            treeNode26.Text = "List All";
            treeNode27.Name = "Type";
            treeNode27.Text = "Type";
            treeNode28.Name = "Items";
            treeNode28.Text = "Items";
            treeNode29.Name = "Machine";
            treeNode29.Text = "Machine";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode25,
            treeNode29});
            this.treeView1.Size = new System.Drawing.Size(126, 398);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(23, 164);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(181, 403);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(173, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(173, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(6, 6);
            this.treeView2.Name = "treeView2";
            treeNode30.Name = "Total Profit";
            treeNode30.Text = "Total Profit";
            treeNode31.Name = "Top Selling Items";
            treeNode31.Text = "Top Selling Items";
            treeNode32.Name = "Profit Margin by Item";
            treeNode32.Text = "Profit Margin by Item";
            treeNode33.Name = "Sales by City";
            treeNode33.Text = "Sales by City";
            treeNode34.Name = "Reports";
            treeNode34.Text = "Reports";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode34});
            this.treeView2.Size = new System.Drawing.Size(146, 398);
            this.treeView2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(173, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(12, 71);
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
            this.label3.Location = new System.Drawing.Point(12, 84);
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
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Header);
            this.Name = "StartUp";
            this.Text = "StartUp";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}