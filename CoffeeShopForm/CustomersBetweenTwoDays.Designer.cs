namespace CoffeeShopForm
{
    partial class CustomersBetweenTwoDays
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
            this.customer_ListBox = new System.Windows.Forms.ListBox();
            this.order_ListBox = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order List";
            // 
            // customer_ListBox
            // 
            this.customer_ListBox.FormattingEnabled = true;
            this.customer_ListBox.ItemHeight = 16;
            this.customer_ListBox.Location = new System.Drawing.Point(30, 84);
            this.customer_ListBox.Name = "customer_ListBox";
            this.customer_ListBox.Size = new System.Drawing.Size(843, 196);
            this.customer_ListBox.TabIndex = 8;
            this.customer_ListBox.SelectedIndexChanged += new System.EventHandler(this.Customer_ListBox_SelectedIndexChanged);
            // 
            // order_ListBox
            // 
            this.order_ListBox.FormattingEnabled = true;
            this.order_ListBox.ItemHeight = 16;
            this.order_ListBox.Location = new System.Drawing.Point(30, 362);
            this.order_ListBox.Name = "order_ListBox";
            this.order_ListBox.Size = new System.Drawing.Size(843, 196);
            this.order_ListBox.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(761, 580);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 45);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CustomersBetweenTwoDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 637);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.order_ListBox);
            this.Controls.Add(this.customer_ListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomersBetweenTwoDays";
            this.Text = "CustomersBetweenTwoDays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox customer_ListBox;
        private System.Windows.Forms.ListBox order_ListBox;
        private System.Windows.Forms.Button btnClose;
    }
}