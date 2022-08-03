namespace PharmacyManagementSystem.Presentation_Layer
{
    partial class OrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderList));
            this.orderListGroupBox = new System.Windows.Forms.GroupBox();
            this.searchCustomerTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.orderListGridView = new System.Windows.Forms.DataGridView();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.medicineNameTextBox = new System.Windows.Forms.TextBox();
            this.medicineNameLabel = new System.Windows.Forms.Label();
            this.updateGroupBox = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateMedicineNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.updatePriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productIdLoad = new System.Windows.Forms.Button();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteProductIdTextBox = new System.Windows.Forms.TextBox();
            this.deleteProductIdLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalProductIdLoad = new System.Windows.Forms.Button();
            this.totalCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.orderListLogoutButton = new System.Windows.Forms.Button();
            this.orderListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderListGridView)).BeginInit();
            this.addGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.updateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateQuantityNumericUpDown)).BeginInit();
            this.delete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderListGroupBox
            // 
            this.orderListGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.orderListGroupBox.Controls.Add(this.searchCustomerTextBox);
            this.orderListGroupBox.Controls.Add(this.label7);
            this.orderListGroupBox.Controls.Add(this.orderListGridView);
            this.orderListGroupBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListGroupBox.Location = new System.Drawing.Point(95, 524);
            this.orderListGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderListGroupBox.Name = "orderListGroupBox";
            this.orderListGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderListGroupBox.Size = new System.Drawing.Size(856, 345);
            this.orderListGroupBox.TabIndex = 0;
            this.orderListGroupBox.TabStop = false;
            this.orderListGroupBox.Text = "Order List";
            // 
            // searchCustomerTextBox
            // 
            this.searchCustomerTextBox.Location = new System.Drawing.Point(425, 55);
            this.searchCustomerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCustomerTextBox.Name = "searchCustomerTextBox";
            this.searchCustomerTextBox.Size = new System.Drawing.Size(115, 29);
            this.searchCustomerTextBox.TabIndex = 6;
            this.searchCustomerTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Customer Name:";
            // 
            // orderListGridView
            // 
            this.orderListGridView.AllowUserToAddRows = false;
            this.orderListGridView.AllowUserToDeleteRows = false;
            this.orderListGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.orderListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderListGridView.Location = new System.Drawing.Point(8, 121);
            this.orderListGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderListGridView.Name = "orderListGridView";
            this.orderListGridView.ReadOnly = true;
            this.orderListGridView.RowHeadersWidth = 51;
            this.orderListGridView.Size = new System.Drawing.Size(840, 217);
            this.orderListGridView.TabIndex = 0;
            // 
            // addGroupBox
            // 
            this.addGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addGroupBox.Controls.Add(this.customerNameTextBox);
            this.addGroupBox.Controls.Add(this.label);
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.quantityNumericUpDown);
            this.addGroupBox.Controls.Add(this.quantityLabel);
            this.addGroupBox.Controls.Add(this.priceTextBox);
            this.addGroupBox.Controls.Add(this.priceLabel);
            this.addGroupBox.Controls.Add(this.medicineNameTextBox);
            this.addGroupBox.Controls.Add(this.medicineNameLabel);
            this.addGroupBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBox.Location = new System.Drawing.Point(89, 38);
            this.addGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addGroupBox.Size = new System.Drawing.Size(365, 263);
            this.addGroupBox.TabIndex = 1;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add Order";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(191, 28);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(132, 29);
            this.customerNameTextBox.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 39);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(138, 20);
            this.label.TabIndex = 7;
            this.label.Text = "Customer Name:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(129, 202);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 36);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(191, 151);
            this.quantityNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(133, 29);
            this.quantityNumericUpDown.TabIndex = 5;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(71, 153);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(81, 20);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(191, 111);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(132, 29);
            this.priceTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(71, 114);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(52, 20);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price:";
            // 
            // medicineNameTextBox
            // 
            this.medicineNameTextBox.Location = new System.Drawing.Point(191, 73);
            this.medicineNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medicineNameTextBox.Name = "medicineNameTextBox";
            this.medicineNameTextBox.Size = new System.Drawing.Size(132, 29);
            this.medicineNameTextBox.TabIndex = 1;
            // 
            // medicineNameLabel
            // 
            this.medicineNameLabel.AutoSize = true;
            this.medicineNameLabel.Location = new System.Drawing.Point(23, 78);
            this.medicineNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medicineNameLabel.Name = "medicineNameLabel";
            this.medicineNameLabel.Size = new System.Drawing.Size(135, 20);
            this.medicineNameLabel.TabIndex = 0;
            this.medicineNameLabel.Text = "Medicine Name:";
            // 
            // updateGroupBox
            // 
            this.updateGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.updateGroupBox.Controls.Add(this.updateButton);
            this.updateGroupBox.Controls.Add(this.updateMedicineNameTextBox);
            this.updateGroupBox.Controls.Add(this.label3);
            this.updateGroupBox.Controls.Add(this.updateQuantityNumericUpDown);
            this.updateGroupBox.Controls.Add(this.label1);
            this.updateGroupBox.Controls.Add(this.updatePriceTextBox);
            this.updateGroupBox.Controls.Add(this.label2);
            this.updateGroupBox.Controls.Add(this.productIdLoad);
            this.updateGroupBox.Controls.Add(this.productIdTextBox);
            this.updateGroupBox.Controls.Add(this.productIDLabel);
            this.updateGroupBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGroupBox.Location = new System.Drawing.Point(497, 38);
            this.updateGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateGroupBox.Name = "updateGroupBox";
            this.updateGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateGroupBox.Size = new System.Drawing.Size(453, 263);
            this.updateGroupBox.TabIndex = 2;
            this.updateGroupBox.TabStop = false;
            this.updateGroupBox.Text = "Update Order";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(301, 108);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 87);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateMedicineNameTextBox
            // 
            this.updateMedicineNameTextBox.Location = new System.Drawing.Point(165, 80);
            this.updateMedicineNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateMedicineNameTextBox.Name = "updateMedicineNameTextBox";
            this.updateMedicineNameTextBox.Size = new System.Drawing.Size(112, 29);
            this.updateMedicineNameTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Medicine Name:";
            // 
            // updateQuantityNumericUpDown
            // 
            this.updateQuantityNumericUpDown.Location = new System.Drawing.Point(165, 165);
            this.updateQuantityNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateQuantityNumericUpDown.Name = "updateQuantityNumericUpDown";
            this.updateQuantityNumericUpDown.Size = new System.Drawing.Size(113, 29);
            this.updateQuantityNumericUpDown.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantity:";
            // 
            // updatePriceTextBox
            // 
            this.updatePriceTextBox.Location = new System.Drawing.Point(165, 126);
            this.updatePriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updatePriceTextBox.Name = "updatePriceTextBox";
            this.updatePriceTextBox.Size = new System.Drawing.Size(112, 29);
            this.updatePriceTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price:";
            // 
            // productIdLoad
            // 
            this.productIdLoad.Location = new System.Drawing.Point(301, 41);
            this.productIdLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productIdLoad.Name = "productIdLoad";
            this.productIdLoad.Size = new System.Drawing.Size(100, 32);
            this.productIdLoad.TabIndex = 2;
            this.productIdLoad.Text = "Load";
            this.productIdLoad.UseVisualStyleBackColor = true;
            this.productIdLoad.Click += new System.EventHandler(this.productIdLoad_Click);
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(165, 41);
            this.productIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(112, 29);
            this.productIdTextBox.TabIndex = 1;
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.Location = new System.Drawing.Point(13, 42);
            this.productIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(99, 20);
            this.productIDLabel.TabIndex = 0;
            this.productIDLabel.Text = "Product ID:";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.delete.Controls.Add(this.deleteButton);
            this.delete.Controls.Add(this.deleteProductIdTextBox);
            this.delete.Controls.Add(this.deleteProductIdLabel);
            this.delete.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(95, 343);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete.Name = "delete";
            this.delete.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete.Size = new System.Drawing.Size(359, 134);
            this.delete.TabIndex = 3;
            this.delete.TabStop = false;
            this.delete.Text = "Delete Order";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(115, 78);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 36);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteProductIdTextBox
            // 
            this.deleteProductIdTextBox.Location = new System.Drawing.Point(147, 27);
            this.deleteProductIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteProductIdTextBox.Name = "deleteProductIdTextBox";
            this.deleteProductIdTextBox.Size = new System.Drawing.Size(132, 29);
            this.deleteProductIdTextBox.TabIndex = 1;
            // 
            // deleteProductIdLabel
            // 
            this.deleteProductIdLabel.AutoSize = true;
            this.deleteProductIdLabel.Location = new System.Drawing.Point(32, 31);
            this.deleteProductIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deleteProductIdLabel.Name = "deleteProductIdLabel";
            this.deleteProductIdLabel.Size = new System.Drawing.Size(99, 20);
            this.deleteProductIdLabel.TabIndex = 0;
            this.deleteProductIdLabel.Text = "Product ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.totalProductIdLoad);
            this.groupBox1.Controls.Add(this.totalCustomerNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Controls.Add(this.TotalLabel);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(497, 343);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(453, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // totalProductIdLoad
            // 
            this.totalProductIdLoad.Location = new System.Drawing.Point(312, 26);
            this.totalProductIdLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalProductIdLoad.Name = "totalProductIdLoad";
            this.totalProductIdLoad.Size = new System.Drawing.Size(100, 32);
            this.totalProductIdLoad.TabIndex = 5;
            this.totalProductIdLoad.Text = "Load";
            this.totalProductIdLoad.UseVisualStyleBackColor = true;
            this.totalProductIdLoad.Click += new System.EventHandler(this.totalProductIdLoad_Click);
            // 
            // totalCustomerNameTextBox
            // 
            this.totalCustomerNameTextBox.Location = new System.Drawing.Point(165, 26);
            this.totalCustomerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalCustomerNameTextBox.Name = "totalCustomerNameTextBox";
            this.totalCustomerNameTextBox.Size = new System.Drawing.Size(112, 29);
            this.totalCustomerNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Name:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(165, 78);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(112, 29);
            this.totalTextBox.TabIndex = 1;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(99, 81);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(54, 20);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total:";
            // 
            // orderListLogoutButton
            // 
            this.orderListLogoutButton.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListLogoutButton.Location = new System.Drawing.Point(1119, 38);
            this.orderListLogoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderListLogoutButton.Name = "orderListLogoutButton";
            this.orderListLogoutButton.Size = new System.Drawing.Size(123, 44);
            this.orderListLogoutButton.TabIndex = 5;
            this.orderListLogoutButton.Text = "Log Out";
            this.orderListLogoutButton.UseVisualStyleBackColor = true;
            this.orderListLogoutButton.Click += new System.EventHandler(this.orderListLogoutButton_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1275, 875);
            this.Controls.Add(this.orderListLogoutButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.updateGroupBox);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.orderListGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderList_FormClosing);
            this.Load += new System.EventHandler(this.OrderList_Load);
            this.orderListGroupBox.ResumeLayout(false);
            this.orderListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderListGridView)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.updateGroupBox.ResumeLayout(false);
            this.updateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateQuantityNumericUpDown)).EndInit();
            this.delete.ResumeLayout(false);
            this.delete.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox orderListGroupBox;
        private System.Windows.Forms.DataGridView orderListGridView;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox medicineNameTextBox;
        private System.Windows.Forms.Label medicineNameLabel;
        private System.Windows.Forms.GroupBox updateGroupBox;
        private System.Windows.Forms.TextBox updateMedicineNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updateQuantityNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox updatePriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button productIdLoad;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox delete;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteProductIdTextBox;
        private System.Windows.Forms.Label deleteProductIdLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button totalProductIdLoad;
        private System.Windows.Forms.TextBox totalCustomerNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button orderListLogoutButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox searchCustomerTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customerNameTextBox;
    }
}