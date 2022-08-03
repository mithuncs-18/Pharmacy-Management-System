using PharmacyManagementSystem.Data_Access_Layer;
using PharmacyManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.Presentation_Layer
{
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
        }

        private void OrderList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            UpdateGridView();

        }

        void UpdateGridView()
        {
            OrderDataAccess orderDataAccess = new OrderDataAccess();
            orderListGridView.DataSource = orderDataAccess.ShowProducts();
        }

        void ClearFields()
        {
            medicineNameTextBox.Text = String.Empty;
            priceTextBox.Text = String.Empty;
            quantityNumericUpDown.Text = String.Empty;

            productIdTextBox.Text = String.Empty;

            updateMedicineNameTextBox.Text = String.Empty;
            updatePriceTextBox.Text = String.Empty;
            updateQuantityNumericUpDown.Text = String.Empty;

            deleteProductIdTextBox.Text = String.Empty;

            totalCustomerNameTextBox.Text = String.Empty;

            totalTextBox.Text = string.Empty;

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            OrderDataAccess orderDataAccess = new OrderDataAccess();            

            if (orderDataAccess.CreateProduct(medicineNameTextBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(quantityNumericUpDown.Text),customerNameTextBox.Text))
            {
                MessageBox.Show("New Medicine Added");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in adding !");
            }
        }


        private void productIdLoad_Click(object sender, EventArgs e)
        {

            if (productIdTextBox.Text == "")
            {
                MessageBox.Show("Please give a Product Id");
            }
            else
            {
                OrderDataAccess orderDataAccess = new OrderDataAccess();
                Order order = orderDataAccess.ShowProductsById(Convert.ToInt32(productIdTextBox.Text));

                if (order == null)
                {
                    MessageBox.Show("Product is not available");
                    UpdateGridView();
                    ClearFields();
                }
                else
                {
                    updateMedicineNameTextBox.Text = order.ProductName;
                    updatePriceTextBox.Text = order.Price.ToString();
                    updateQuantityNumericUpDown.Text = order.Quantity.ToString();
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            OrderDataAccess orderDataAccess = new OrderDataAccess();
            if (orderDataAccess.UpdateProduct(Convert.ToInt32(productIdTextBox.Text), updateMedicineNameTextBox.Text, Convert.ToInt32(updatePriceTextBox.Text), Convert.ToInt32(updateQuantityNumericUpDown.Text)))
            {
                MessageBox.Show("Order Updated !");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in Updating !");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            {
                if (deleteProductIdTextBox.Text == "")
                {
                    MessageBox.Show("Please give a Product Id");
                }
                else
                {
                    OrderDataAccess orderDataAccess = new OrderDataAccess();
                    Order order = orderDataAccess.ShowProductsById(Convert.ToInt32(deleteProductIdTextBox.Text));
                    if (order == null)
                    {
                        MessageBox.Show("Order is not available ! Nothing to delete !");
                        ClearFields();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            orderDataAccess = new OrderDataAccess();
                            if (orderDataAccess.DeleteProduct(Convert.ToInt32(deleteProductIdTextBox.Text)))
                            {
                                MessageBox.Show("Order deleted");
                                UpdateGridView();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Error in deleting");
                            }
                        }
                    }
                }
            }

        }

        private void totalProductIdLoad_Click(object sender, EventArgs e)
        {
            if (totalCustomerNameTextBox.Text == "")
            {
                MessageBox.Show("Please give a Customer Name!");
            }
            else
            {
                OrderDataAccess orderDataAccess = new OrderDataAccess();
                List<Order> order = orderDataAccess.ShowCustomerOrderByName(totalCustomerNameTextBox.Text);

                    if (order.Count == 0)
                    {
                        MessageBox.Show("Customer haven't made any order yet");
                        UpdateGridView();
                        ClearFields();
                    }
                    else
                    {
                    int sum = 0;
                    for (int i = 0; i < order.Count; i++)
                    {
                        sum += (order[i].Quantity * order[i].Price);
                    }
                        totalTextBox.Text = sum.ToString();
                    }

            }
        }

        private void orderListLogoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OrderDataAccess orderDataAccess = new OrderDataAccess();
            orderListGridView.DataSource = orderDataAccess.ShowCustomerOrderByName(searchCustomerTextBox.Text);
        }
    }
}

