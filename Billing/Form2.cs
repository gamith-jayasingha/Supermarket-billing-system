using System.Data;
using MySql.Data.MySqlClient; // Import MySQL library

namespace Billing
{
    public partial class Form2 : Form
    {
        private string connectionString = "server=localhost;database=billingsystem;user=root;password=Gamith12345;";

        public Form2()
        {
            InitializeComponent();
        }

        // Load inventory data on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        // Load inventory from the database
        private void LoadInventory()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Inventory";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to DataGridView
                    dataGridViewItems.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inventory: {ex.Message}");
            }
        }

        // Add new item to inventory
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            int quantity;
            decimal price;

            if (string.IsNullOrWhiteSpace(itemName) ||
                !int.TryParse(txtQuantity.Text, out quantity) ||
                !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter valid item details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Inventory (ItemName, Quantity, PricePerUnit) VALUES (@ItemName, @Quantity, @Price)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ItemName", itemName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload inventory
                LoadInventory();

                // Clear input fields
                txtItemName.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}");
            }
        }

        // Update inventory
        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int itemId = Convert.ToInt32(dataGridViewItems.SelectedRows[0].Cells["ItemID"].Value);
            string itemName = txtItemName.Text;
            int quantity;
            decimal price;

            if (string.IsNullOrWhiteSpace(itemName) ||
                !int.TryParse(txtQuantity.Text, out quantity) ||
                !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter valid item details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Inventory SET ItemName = @ItemName, Quantity = @Quantity, PricePerUnit = @Price WHERE ItemID = @ItemID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", itemId);
                        cmd.Parameters.AddWithValue("@ItemName", itemName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload inventory
                LoadInventory();

                // Clear input fields
                txtItemName.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating item: {ex.Message}");
            }
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
