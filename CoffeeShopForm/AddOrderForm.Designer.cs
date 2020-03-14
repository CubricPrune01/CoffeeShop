namespace CoffeeShopForm
{
    partial class AddOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.additionGridView = new System.Windows.Forms.DataGridView();
            this.Column_Addition_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Addition_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.orderListGridView = new System.Windows.Forms.DataGridView();
            this.Column2_MenuItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUD_Cheese = new System.Windows.Forms.NumericUpDown();
            this.NUD_Lettuce = new System.Windows.Forms.NumericUpDown();
            this.NUD_Mayo = new System.Windows.Forms.NumericUpDown();
            this.NUD_Milk = new System.Windows.Forms.NumericUpDown();
            this.NUD_Sugar = new System.Windows.Forms.NumericUpDown();
            this.NUD_Sweetener = new System.Windows.Forms.NumericUpDown();
            this.NUD_Tomato = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cheeseValue = new System.Windows.Forms.Label();
            this.lettuceValue = new System.Windows.Forms.Label();
            this.mayoValue = new System.Windows.Forms.Label();
            this.milkValue = new System.Windows.Forms.Label();
            this.sugarValue = new System.Windows.Forms.Label();
            this.sweetenerValue = new System.Windows.Forms.Label();
            this.tomatoValue = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Column_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.additionGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Lettuce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Mayo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Milk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Sugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Sweetener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Tomato)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuGridView);
            this.groupBox1.Location = new System.Drawing.Point(36, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // menuGridView
            // 
            this.menuGridView.AllowUserToAddRows = false;
            this.menuGridView.AllowUserToDeleteRows = false;
            this.menuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Description,
            this.Column_Cost});
            this.menuGridView.Location = new System.Drawing.Point(7, 22);
            this.menuGridView.MultiSelect = false;
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.ReadOnly = true;
            this.menuGridView.RowTemplate.Height = 24;
            this.menuGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuGridView.Size = new System.Drawing.Size(467, 281);
            this.menuGridView.TabIndex = 0;
            this.menuGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuGridView_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.additionGridView);
            this.groupBox2.Location = new System.Drawing.Point(524, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu Item Addition";
            // 
            // additionGridView
            // 
            this.additionGridView.AllowUserToAddRows = false;
            this.additionGridView.AllowUserToDeleteRows = false;
            this.additionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.additionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.additionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Addition_Description,
            this.Column_Addition_Cost});
            this.additionGridView.Location = new System.Drawing.Point(6, 22);
            this.additionGridView.Name = "additionGridView";
            this.additionGridView.ReadOnly = true;
            this.additionGridView.RowTemplate.Height = 24;
            this.additionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.additionGridView.Size = new System.Drawing.Size(359, 282);
            this.additionGridView.TabIndex = 0;
            // 
            // Column_Addition_Description
            // 
            this.Column_Addition_Description.HeaderText = "Description";
            this.Column_Addition_Description.Name = "Column_Addition_Description";
            this.Column_Addition_Description.ReadOnly = true;
            // 
            // Column_Addition_Cost
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Column_Addition_Cost.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column_Addition_Cost.HeaderText = "Base Cost";
            this.Column_Addition_Cost.Name = "Column_Addition_Cost";
            this.Column_Addition_Cost.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.orderListGridView);
            this.groupBox3.Location = new System.Drawing.Point(36, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(853, 230);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order List";
            // 
            // orderListGridView
            // 
            this.orderListGridView.AllowUserToAddRows = false;
            this.orderListGridView.AllowUserToDeleteRows = false;
            this.orderListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2_MenuItem,
            this.Column2_Cost});
            this.orderListGridView.Location = new System.Drawing.Point(7, 22);
            this.orderListGridView.Name = "orderListGridView";
            this.orderListGridView.ReadOnly = true;
            this.orderListGridView.RowTemplate.Height = 24;
            this.orderListGridView.Size = new System.Drawing.Size(840, 202);
            this.orderListGridView.TabIndex = 0;
            // 
            // Column2_MenuItem
            // 
            this.Column2_MenuItem.HeaderText = "Item";
            this.Column2_MenuItem.Name = "Column2_MenuItem";
            this.Column2_MenuItem.ReadOnly = true;
            // 
            // Column2_Cost
            // 
            this.Column2_Cost.HeaderText = "Cost";
            this.Column2_Cost.Name = "Column2_Cost";
            this.Column2_Cost.ReadOnly = true;
            // 
            // NUD_Cheese
            // 
            this.NUD_Cheese.Location = new System.Drawing.Point(900, 92);
            this.NUD_Cheese.Name = "NUD_Cheese";
            this.NUD_Cheese.Size = new System.Drawing.Size(60, 22);
            this.NUD_Cheese.TabIndex = 2;
            this.NUD_Cheese.ValueChanged += new System.EventHandler(this.NUD_Cheese_ValueChanged);
            // 
            // NUD_Lettuce
            // 
            this.NUD_Lettuce.Location = new System.Drawing.Point(900, 121);
            this.NUD_Lettuce.Name = "NUD_Lettuce";
            this.NUD_Lettuce.Size = new System.Drawing.Size(60, 22);
            this.NUD_Lettuce.TabIndex = 2;
            this.NUD_Lettuce.ValueChanged += new System.EventHandler(this.NUD_Lettuce_ValueChanged);
            // 
            // NUD_Mayo
            // 
            this.NUD_Mayo.Location = new System.Drawing.Point(900, 150);
            this.NUD_Mayo.Name = "NUD_Mayo";
            this.NUD_Mayo.Size = new System.Drawing.Size(60, 22);
            this.NUD_Mayo.TabIndex = 2;
            this.NUD_Mayo.ValueChanged += new System.EventHandler(this.NUD_Mayo_ValueChanged);
            // 
            // NUD_Milk
            // 
            this.NUD_Milk.Location = new System.Drawing.Point(900, 178);
            this.NUD_Milk.Name = "NUD_Milk";
            this.NUD_Milk.Size = new System.Drawing.Size(60, 22);
            this.NUD_Milk.TabIndex = 2;
            this.NUD_Milk.ValueChanged += new System.EventHandler(this.NUD_Milk_ValueChanged);
            // 
            // NUD_Sugar
            // 
            this.NUD_Sugar.Location = new System.Drawing.Point(900, 206);
            this.NUD_Sugar.Name = "NUD_Sugar";
            this.NUD_Sugar.Size = new System.Drawing.Size(60, 22);
            this.NUD_Sugar.TabIndex = 2;
            this.NUD_Sugar.ValueChanged += new System.EventHandler(this.NUD_Sugar_ValueChanged);
            // 
            // NUD_Sweetener
            // 
            this.NUD_Sweetener.Location = new System.Drawing.Point(900, 234);
            this.NUD_Sweetener.Name = "NUD_Sweetener";
            this.NUD_Sweetener.Size = new System.Drawing.Size(60, 22);
            this.NUD_Sweetener.TabIndex = 2;
            this.NUD_Sweetener.ValueChanged += new System.EventHandler(this.NUD_Sweetener_ValueChanged);
            // 
            // NUD_Tomato
            // 
            this.NUD_Tomato.Location = new System.Drawing.Point(900, 262);
            this.NUD_Tomato.Name = "NUD_Tomato";
            this.NUD_Tomato.Size = new System.Drawing.Size(60, 22);
            this.NUD_Tomato.TabIndex = 2;
            this.NUD_Tomato.ValueChanged += new System.EventHandler(this.NUD_Tomato_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(980, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cheese: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(980, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lettuce:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(980, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mayo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(980, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Milk: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(980, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sugar: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(980, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sweetener: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(980, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tomato: ";
            // 
            // cheeseValue
            // 
            this.cheeseValue.AutoSize = true;
            this.cheeseValue.Location = new System.Drawing.Point(1060, 97);
            this.cheeseValue.Name = "cheeseValue";
            this.cheeseValue.Size = new System.Drawing.Size(0, 17);
            this.cheeseValue.TabIndex = 4;
            // 
            // lettuceValue
            // 
            this.lettuceValue.AutoSize = true;
            this.lettuceValue.Location = new System.Drawing.Point(1060, 126);
            this.lettuceValue.Name = "lettuceValue";
            this.lettuceValue.Size = new System.Drawing.Size(0, 17);
            this.lettuceValue.TabIndex = 4;
            // 
            // mayoValue
            // 
            this.mayoValue.AutoSize = true;
            this.mayoValue.Location = new System.Drawing.Point(1060, 155);
            this.mayoValue.Name = "mayoValue";
            this.mayoValue.Size = new System.Drawing.Size(0, 17);
            this.mayoValue.TabIndex = 4;
            // 
            // milkValue
            // 
            this.milkValue.AutoSize = true;
            this.milkValue.Location = new System.Drawing.Point(1060, 183);
            this.milkValue.Name = "milkValue";
            this.milkValue.Size = new System.Drawing.Size(0, 17);
            this.milkValue.TabIndex = 4;
            // 
            // sugarValue
            // 
            this.sugarValue.AutoSize = true;
            this.sugarValue.Location = new System.Drawing.Point(1060, 211);
            this.sugarValue.Name = "sugarValue";
            this.sugarValue.Size = new System.Drawing.Size(0, 17);
            this.sugarValue.TabIndex = 4;
            // 
            // sweetenerValue
            // 
            this.sweetenerValue.AutoSize = true;
            this.sweetenerValue.Location = new System.Drawing.Point(1060, 239);
            this.sweetenerValue.Name = "sweetenerValue";
            this.sweetenerValue.Size = new System.Drawing.Size(0, 17);
            this.sweetenerValue.TabIndex = 4;
            // 
            // tomatoValue
            // 
            this.tomatoValue.AutoSize = true;
            this.tomatoValue.Location = new System.Drawing.Point(1060, 267);
            this.tomatoValue.Name = "tomatoValue";
            this.tomatoValue.Size = new System.Drawing.Size(0, 17);
            this.tomatoValue.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(910, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 52);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(910, 456);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(145, 52);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(910, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 52);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Column_Description
            // 
            dataGridViewCellStyle8.NullValue = null;
            this.Column_Description.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column_Description.HeaderText = "Description";
            this.Column_Description.Name = "Column_Description";
            this.Column_Description.ReadOnly = true;
            // 
            // Column_Cost
            // 
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.Column_Cost.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column_Cost.HeaderText = "Base Cost";
            this.Column_Cost.Name = "Column_Cost";
            this.Column_Cost.ReadOnly = true;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 602);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tomatoValue);
            this.Controls.Add(this.sweetenerValue);
            this.Controls.Add(this.sugarValue);
            this.Controls.Add(this.milkValue);
            this.Controls.Add(this.mayoValue);
            this.Controls.Add(this.lettuceValue);
            this.Controls.Add(this.cheeseValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_Tomato);
            this.Controls.Add(this.NUD_Sweetener);
            this.Controls.Add(this.NUD_Sugar);
            this.Controls.Add(this.NUD_Milk);
            this.Controls.Add(this.NUD_Mayo);
            this.Controls.Add(this.NUD_Lettuce);
            this.Controls.Add(this.NUD_Cheese);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddOrderForm";
            this.Text = "Add Order";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.additionGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Lettuce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Mayo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Milk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Sugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Sweetener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Tomato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView additionGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView orderListGridView;
        private System.Windows.Forms.NumericUpDown NUD_Cheese;
        private System.Windows.Forms.NumericUpDown NUD_Lettuce;
        private System.Windows.Forms.NumericUpDown NUD_Mayo;
        private System.Windows.Forms.NumericUpDown NUD_Milk;
        private System.Windows.Forms.NumericUpDown NUD_Sugar;
        private System.Windows.Forms.NumericUpDown NUD_Sweetener;
        private System.Windows.Forms.NumericUpDown NUD_Tomato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cheeseValue;
        private System.Windows.Forms.Label lettuceValue;
        private System.Windows.Forms.Label mayoValue;
        private System.Windows.Forms.Label milkValue;
        private System.Windows.Forms.Label sugarValue;
        private System.Windows.Forms.Label sweetenerValue;
        private System.Windows.Forms.Label tomatoValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_MenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Addition_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Addition_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cost;
    }
}