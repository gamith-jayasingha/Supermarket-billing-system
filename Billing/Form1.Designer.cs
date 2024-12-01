namespace Billing
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewBilling = new DataGridView();
            colItemID = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPricePerUnit = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            txtItemCode = new TextBox();
            txtQuantity = new TextBox();
            txtAmountPaid = new TextBox();
            btnAddItem = new Button();
            btnCalculateTotal = new Button();
            btnPrintBill = new Button();
            lblTotal = new Label();
            lblAmountPaid = new Label();
            lblBalance = new Label();
            btnGoToInventory = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBilling).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBilling
            // 
            dataGridViewBilling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBilling.Columns.AddRange(new DataGridViewColumn[] { colItemID, colItemName, colQuantity, colPricePerUnit, colTotal });
            dataGridViewBilling.Location = new Point(12, 12);
            dataGridViewBilling.Name = "dataGridViewBilling";
            dataGridViewBilling.RowHeadersWidth = 51;
            dataGridViewBilling.Size = new Size(848, 246);
            dataGridViewBilling.TabIndex = 0;
            // 
            // colItemID
            // 
            colItemID.HeaderText = "Item ID";
            colItemID.MinimumWidth = 6;
            colItemID.Name = "colItemID";
            colItemID.ReadOnly = true;
            colItemID.Width = 125;
            // 
            // colItemName
            // 
            colItemName.HeaderText = "Item Name";
            colItemName.MinimumWidth = 6;
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            colItemName.Width = 125;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 125;
            // 
            // colPricePerUnit
            // 
            colPricePerUnit.HeaderText = "Price Per Unit";
            colPricePerUnit.MinimumWidth = 6;
            colPricePerUnit.Name = "colPricePerUnit";
            colPricePerUnit.ReadOnly = true;
            colPricePerUnit.Width = 125;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 125;
            // 
            // txtItemCode
            // 
            txtItemCode.Location = new Point(117, 280);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new Size(150, 27);
            txtItemCode.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(117, 313);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 27);
            txtQuantity.TabIndex = 2;
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Location = new Point(115, 395);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(150, 27);
            txtAmountPaid.TabIndex = 3;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(315, 276);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(140, 43);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Location = new Point(315, 325);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(140, 44);
            btnCalculateTotal.TabIndex = 5;
            btnCalculateTotal.Text = "Calculate Total";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // btnPrintBill
            // 
            btnPrintBill.Location = new Point(315, 386);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(140, 36);
            btnPrintBill.TabIndex = 6;
            btnPrintBill.Text = "Print Bill";
            btnPrintBill.UseVisualStyleBackColor = true;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(500, 280);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(57, 20);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total: 0";
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Location = new Point(12, 402);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(97, 20);
            lblAmountPaid.TabIndex = 8;
            lblAmountPaid.Text = "Amount Paid:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(500, 310);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(68, 20);
            lblBalance.TabIndex = 9;
            lblBalance.Text = "Balance: ";
            // 
            // btnGoToInventory
            // 
            btnGoToInventory.Location = new Point(743, 423);
            btnGoToInventory.Name = "btnGoToInventory";
            btnGoToInventory.Size = new Size(117, 56);
            btnGoToInventory.TabIndex = 10;
            btnGoToInventory.Text = "Go to Inventory";
            btnGoToInventory.UseVisualStyleBackColor = true;
            btnGoToInventory.Click += btnGoToInventory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 287);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 11;
            label1.Text = "Item ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 320);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 12;
            label2.Text = "Quantity";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(875, 491);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGoToInventory);
            Controls.Add(lblBalance);
            Controls.Add(lblAmountPaid);
            Controls.Add(lblTotal);
            Controls.Add(btnPrintBill);
            Controls.Add(btnCalculateTotal);
            Controls.Add(btnAddItem);
            Controls.Add(txtAmountPaid);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemCode);
            Controls.Add(dataGridViewBilling);
            Name = "Form1";
            Text = "Billing System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBilling).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnGoToInventory;
        private Label label1;
        private Label label2;
    }
}
