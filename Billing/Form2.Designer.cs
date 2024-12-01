using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Billing
{
    partial class Form2
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
            dataGridViewItems = new DataGridView();
            txtItemName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            lblItemName = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            btnAddItem = new Button();
            btnUpdateInventory = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(12, 12);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(679, 258);
            dataGridViewItems.TabIndex = 0;
            dataGridViewItems.CellContentClick += dataGridViewItems_CellContentClick;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(118, 276);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(150, 27);
            txtItemName.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(118, 313);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 27);
            txtQuantity.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(118, 367);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 27);
            txtPrice.TabIndex = 3;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(12, 283);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(86, 20);
            lblItemName.TabIndex = 4;
            lblItemName.Text = "Item Name:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 313);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(11, 374);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(101, 20);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price per Unit:";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(364, 280);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(150, 50);
            btnAddItem.TabIndex = 7;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnUpdateInventory
            // 
            btnUpdateInventory.Location = new Point(364, 346);
            btnUpdateInventory.Name = "btnUpdateInventory";
            btnUpdateInventory.Size = new Size(150, 48);
            btnUpdateInventory.TabIndex = 8;
            btnUpdateInventory.Text = "Update Inventory";
            btnUpdateInventory.UseVisualStyleBackColor = true;
            btnUpdateInventory.Click += btnUpdateInventory_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(757, 491);
            Controls.Add(btnUpdateInventory);
            Controls.Add(btnAddItem);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblItemName);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemName);
            Controls.Add(dataGridViewItems);
            Name = "Form2";
            Text = "Inventory Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnUpdateInventory;
    }
}
