namespace CoffeeShopForm
{
    partial class Customer_Orders
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerInfo_ListBox = new System.Windows.Forms.ListBox();
            this.order_ListBox = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order List";
            // 
            // customerInfo_ListBox
            // 
            this.customerInfo_ListBox.FormattingEnabled = true;
            this.customerInfo_ListBox.ItemHeight = 16;
            this.customerInfo_ListBox.Location = new System.Drawing.Point(23, 53);
            this.customerInfo_ListBox.Name = "customerInfo_ListBox";
            this.customerInfo_ListBox.Size = new System.Drawing.Size(899, 196);
            this.customerInfo_ListBox.TabIndex = 7;
            this.customerInfo_ListBox.SelectedIndexChanged += new System.EventHandler(this.CustomerInfo_ListBox_SelectedIndexChanged);
            // 
            // order_ListBox
            // 
            this.order_ListBox.FormattingEnabled = true;
            this.order_ListBox.ItemHeight = 16;
            this.order_ListBox.Location = new System.Drawing.Point(23, 330);
            this.order_ListBox.Name = "order_ListBox";
            this.order_ListBox.Size = new System.Drawing.Size(899, 228);
            this.order_ListBox.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(796, 565);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 50);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Customer_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 627);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.order_ListBox);
            this.Controls.Add(this.customerInfo_ListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Orders";
            this.Text = "Customer_Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox customerInfo_ListBox;
        private System.Windows.Forms.ListBox order_ListBox;
        private System.Windows.Forms.Button btnClose;
    }
}