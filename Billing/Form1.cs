using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Billing
{
    public partial class Form1 : Form
    {
     
        private string connectionString = "server=localhost;database=billingsystem;user=root;password=Gamith12345;";

        // Constructor to initialize the form
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize any necessary settings or data here (if required)
        }

        // Add an item to the bill
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int itemID; // To store the item ID entered by the user
            int quantity; // To store the quantity entered by the user

            // Validate user input for Item ID and Quantity
            if (!int.TryParse(txtItemCode.Text, out itemID) || !int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter valid Item ID and Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Establish a connection to the database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch item details from the Inventory table
                    string query = "SELECT ItemName, PricePerUnit, Quantity FROM Inventory WHERE ItemID = @ItemID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", itemID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string itemName = reader["ItemName"].ToString(); // Retrieve item name
                                decimal pricePerUnit = Convert.ToDecimal(reader["PricePerUnit"]); // Retrieve price per unit
                                int availableQuantity = Convert.ToInt32(reader["Quantity"]); // Retrieve available quantity

                                // Check if the requested quantity is available
                                if (quantity > availableQuantity)
                                {
                                    MessageBox.Show($"Insufficient stock. Available quantity: {availableQuantity}", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                // Calculate total price for the selected quantity
                                decimal total = pricePerUnit * quantity;

                                // Add item details to the DataGridView
                                dataGridViewBilling.Rows.Add(itemID, itemName, quantity, pricePerUnit, total);

                                // Update the inventory after adding the item
                                UpdateInventory(itemID, availableQuantity - quantity);
                            }
                            else
                            {
                                MessageBox.Show("Item ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear the input fields after adding the item
            txtItemCode.Clear();
            txtQuantity.Clear();
        }

        // Update inventory after a sale
        private void UpdateInventory(int itemID, int newQuantity)
        {
            try
            {
                // Establish a connection to the database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to update the inventory quantity
                    string query = "UPDATE Inventory SET Quantity = @Quantity WHERE ItemID = @ItemID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Quantity", newQuantity);
                        command.Parameters.AddWithValue("@ItemID", itemID);
                        command.ExecuteNonQuery(); // Execute the query
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating inventory: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Calculate the total amount for the bill
        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            decimal grandTotal = 0;

            // Iterate through the DataGridView rows and calculate the total
            foreach (DataGridViewRow row in dataGridViewBilling.Rows)
            {
                grandTotal += Convert.ToDecimal(row.Cells["colTotal"].Value);
            }

            // Display the total amount
            lblTotal.Text = $"Total: + 10 {grandTotal:C}";
            
        }

        // Print the bill and calculate balance
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            string bill = "===== BILL =====\n";

            // Iterate through the DataGridView rows to create a bill summary
            foreach (DataGridViewRow row in dataGridViewBilling.Rows)
            {
                bill += $"Item: {row.Cells["colItemName"].Value}, Quantity: {row.Cells["colQuantity"].Value}, Total: {row.Cells["colTotal"].Value:C}\n";
            }

            // Calculate the grand total
            decimal grandTotal = 0;
            foreach (DataGridViewRow row in dataGridViewBilling.Rows)
            {
                grandTotal += Convert.ToDecimal(row.Cells["colTotal"].Value);
            }

            // Add the grand total to the bill
            bill += $"\nGrand Total: {grandTotal:C}";

            // Calculate and display the balance
            if (decimal.TryParse(txtAmountPaid.Text, out decimal paidAmount))
            {
                decimal balance = paidAmount - grandTotal;
                bill += $"\nAmount Paid: {paidAmount:C}";
                bill += $"\nBalance: {balance:C}";
            }
            else
            {
                MessageBox.Show("Please enter a valid amount paid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Display the bill in a message box
            MessageBox.Show(bill, "Print Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Navigate to the Inventory Management form
        private void btnGoToInventory_Click(object sender, EventArgs e)
        {
            Form2 inventoryForm = new Form2();
            inventoryForm.Show();
        }

        // Placeholder for any additional event handlers
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
