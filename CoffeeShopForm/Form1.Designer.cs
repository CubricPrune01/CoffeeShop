namespace CoffeeShopForm
{
    partial class CoffeeShopForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dataOrderList = new System.Windows.Forms.DataGridView();
            this.Column_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1401, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.CloseToolStripMenuItem1_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.editCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.AddCustomerToolStripMenuItem_Click);
            // 
            // editCustomerToolStripMenuItem
            // 
            this.editCustomerToolStripMenuItem.Name = "editCustomerToolStripMenuItem";
            this.editCustomerToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.editCustomerToolStripMenuItem.Text = "Edit Customer";
            this.editCustomerToolStripMenuItem.Click += new System.EventHandler(this.EditCustomerToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.addOrderToolStripMenuItem.Text = "Add Order";
            this.addOrderToolStripMenuItem.Click += new System.EventHandler(this.AddOrderToolStripMenuItem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Id,
            this.Column_Name,
            this.Column_Street,
            this.Column_City,
            this.Column_Province,
            this.Column_PostalCode,
            this.Column_PhoneNumber});
            this.dataGridView2.Location = new System.Drawing.Point(12, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(996, 339);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.DataGridView2_SelectionChanged);
            // 
            // Column_Id
            // 
            this.Column_Id.HeaderText = "ID";
            this.Column_Id.Name = "Column_Id";
            this.Column_Id.ReadOnly = true;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_Street
            // 
            this.Column_Street.HeaderText = "Street";
            this.Column_Street.Name = "Column_Street";
            this.Column_Street.ReadOnly = true;
            // 
            // Column_City
            // 
            this.Column_City.HeaderText = "City";
            this.Column_City.Name = "Column_City";
            this.Column_City.ReadOnly = true;
            // 
            // Column_Province
            // 
            this.Column_Province.HeaderText = "Province";
            this.Column_Province.Name = "Column_Province";
            this.Column_Province.ReadOnly = true;
            // 
            // Column_PostalCode
            // 
            this.Column_PostalCode.HeaderText = "Postal Code";
            this.Column_PostalCode.Name = "Column_PostalCode";
            this.Column_PostalCode.ReadOnly = true;
            // 
            // Column_PhoneNumber
            // 
            this.Column_PhoneNumber.HeaderText = "Phone Number";
            this.Column_PhoneNumber.Name = "Column_PhoneNumber";
            this.Column_PhoneNumber.ReadOnly = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(1141, 449);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(121, 44);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(1268, 449);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(121, 44);
            this.btnEditCustomer.TabIndex = 2;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomer_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1266, 499);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 44);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(1141, 499);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(121, 44);
            this.btnAddOrder.TabIndex = 2;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // dataOrderList
            // 
            this.dataOrderList.AllowUserToAddRows = false;
            this.dataOrderList.AllowUserToDeleteRows = false;
            this.dataOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Description,
            this.Column_Cost});
            this.dataOrderList.Location = new System.Drawing.Point(1041, 69);
            this.dataOrderList.Name = "dataOrderList";
            this.dataOrderList.ReadOnly = true;
            this.dataOrderList.RowTemplate.Height = 24;
            this.dataOrderList.Size = new System.Drawing.Size(346, 339);
            this.dataOrderList.TabIndex = 3;
            // 
            // Column_Description
            // 
            this.Column_Description.HeaderText = "Description";
            this.Column_Description.Name = "Column_Description";
            this.Column_Description.ReadOnly = true;
            // 
            // Column_Cost
            // 
            this.Column_Cost.HeaderText = "Cost";
            this.Column_Cost.Name = "Column_Cost";
            this.Column_Cost.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1041, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(211, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers with Undelivered Order";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(479, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 94);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Order Made Within Range of Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(264, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CoffeeShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataOrderList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoffeeShopForm";
            this.Text = "Coffee Shop Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ToolStripMenuItem editCustomerToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PhoneNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

