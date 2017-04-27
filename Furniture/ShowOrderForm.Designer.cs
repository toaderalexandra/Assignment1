namespace Furniture
{
    partial class ShowOrderForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ordStatus = new System.Windows.Forms.TextBox();
            this.shippingAddr = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.txtOderID = new System.Windows.Forms.TextBox();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.btnRetrieveOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.delivDate = new System.Windows.Forms.DateTimePicker();
            this.txtprodID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQunat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Order ID:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Delivery Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Shipping Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Customer Name:";
            // 
            // ordStatus
            // 
            this.ordStatus.Location = new System.Drawing.Point(140, 114);
            this.ordStatus.Name = "ordStatus";
            this.ordStatus.Size = new System.Drawing.Size(100, 20);
            this.ordStatus.TabIndex = 43;
            // 
            // shippingAddr
            // 
            this.shippingAddr.Location = new System.Drawing.Point(140, 62);
            this.shippingAddr.Name = "shippingAddr";
            this.shippingAddr.Size = new System.Drawing.Size(100, 20);
            this.shippingAddr.TabIndex = 41;
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(140, 36);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(100, 20);
            this.customerName.TabIndex = 40;
            // 
            // txtOderID
            // 
            this.txtOderID.Location = new System.Drawing.Point(140, 10);
            this.txtOderID.Name = "txtOderID";
            this.txtOderID.Size = new System.Drawing.Size(59, 20);
            this.txtOderID.TabIndex = 49;
            // 
            // gridStudents
            // 
            this.gridStudents.AllowUserToAddRows = false;
            this.gridStudents.AllowUserToDeleteRows = false;
            this.gridStudents.AllowUserToResizeColumns = false;
            this.gridStudents.AllowUserToResizeRows = false;
            this.gridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Address,
            this.DeliveryDate,
            this.Status,
            this.ProductId,
            this.Quantity,
            this.TotalPrice});
            this.gridStudents.Location = new System.Drawing.Point(39, 245);
            this.gridStudents.MultiSelect = false;
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.RowHeadersVisible = false;
            this.gridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudents.Size = new System.Drawing.Size(644, 236);
            this.gridStudents.TabIndex = 50;
            // 
            // btnRetrieveOrder
            // 
            this.btnRetrieveOrder.Location = new System.Drawing.Point(315, 204);
            this.btnRetrieveOrder.Name = "btnRetrieveOrder";
            this.btnRetrieveOrder.Size = new System.Drawing.Size(88, 23);
            this.btnRetrieveOrder.TabIndex = 54;
            this.btnRetrieveOrder.Text = "Retrieve";
            this.btnRetrieveOrder.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(221, 204);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(88, 23);
            this.btnDeleteOrder.TabIndex = 53;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(140, 204);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(75, 23);
            this.btnEditOrder.TabIndex = 52;
            this.btnEditOrder.Text = "Edit";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(48, 204);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(86, 23);
            this.btnAddOrder.TabIndex = 51;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // delivDate
            // 
            this.delivDate.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.delivDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.delivDate.Location = new System.Drawing.Point(140, 88);
            this.delivDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.delivDate.Name = "delivDate";
            this.delivDate.Size = new System.Drawing.Size(184, 20);
            this.delivDate.TabIndex = 55;
            // 
            // txtprodID
            // 
            this.txtprodID.Location = new System.Drawing.Point(140, 145);
            this.txtprodID.Name = "txtprodID";
            this.txtprodID.Size = new System.Drawing.Size(59, 20);
            this.txtprodID.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Product ID:";
            // 
            // txtQunat
            // 
            this.txtQunat.Location = new System.Drawing.Point(140, 171);
            this.txtQunat.Name = "txtQunat";
            this.txtQunat.Size = new System.Drawing.Size(59, 20);
            this.txtQunat.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Quantity:";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "Delivery Date";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // ShowOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 503);
            this.Controls.Add(this.txtQunat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprodID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delivDate);
            this.Controls.Add(this.btnRetrieveOrder);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.gridStudents);
            this.Controls.Add(this.txtOderID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordStatus);
            this.Controls.Add(this.shippingAddr);
            this.Controls.Add(this.customerName);
            this.Name = "ShowOrderForm";
            this.Load += new System.EventHandler(this.ShowProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ordStatus;
        private System.Windows.Forms.TextBox shippingAddr;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox txtOderID;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.Button btnRetrieveOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DateTimePicker delivDate;
        private System.Windows.Forms.TextBox txtprodID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQunat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}