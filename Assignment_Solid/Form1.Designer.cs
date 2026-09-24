namespace Assignment_Solid
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCustomerEmail = new TextBox();
            dgvItems = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            cmbDiscountType = new ComboBox();
            btnCalculate = new Button();
            btnSaveOrder = new Button();
            btnEmailInvoice = new Button();
            btnPrint = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(54, 29);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(346, 23);
            txtCustomerEmail.TabIndex = 0;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Qty });
            dgvItems.Location = new Point(57, 92);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(343, 150);
            dgvItems.TabIndex = 1;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.Name = "Qty";
            // 
            // cmbDiscountType
            // 
            cmbDiscountType.FormattingEnabled = true;
            cmbDiscountType.Items.AddRange(new object[] { "None", "Student", "Senior", "BlackFriday" });
            cmbDiscountType.Location = new Point(56, 264);
            cmbDiscountType.Name = "cmbDiscountType";
            cmbDiscountType.Size = new Size(344, 23);
            cmbDiscountType.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(46, 375);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(127, 375);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(75, 23);
            btnSaveOrder.TabIndex = 4;
            btnSaveOrder.Text = "SaveOrder";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnEmailInvoice
            // 
            btnEmailInvoice.Location = new Point(208, 375);
            btnEmailInvoice.Name = "btnEmailInvoice";
            btnEmailInvoice.Size = new Size(89, 23);
            btnEmailInvoice.TabIndex = 5;
            btnEmailInvoice.Text = "EmailInvoice";
            btnEmailInvoice.UseVisualStyleBackColor = true;
            btnEmailInvoice.Click += btnEmailInvoice_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(303, 375);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(56, 306);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(37, 45);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(lblTotal);
            Controls.Add(btnPrint);
            Controls.Add(btnEmailInvoice);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnCalculate);
            Controls.Add(cmbDiscountType);
            Controls.Add(dgvItems);
            Controls.Add(txtCustomerEmail);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerEmail;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qty;
        private ComboBox cmbDiscountType;
        private Button btnCalculate;
        private Button btnSaveOrder;
        private Button btnEmailInvoice;
        private Button btnPrint;
        private Label lblTotal;
    }
}