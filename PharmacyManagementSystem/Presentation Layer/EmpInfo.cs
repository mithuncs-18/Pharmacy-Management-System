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
    public partial class EmpInfo : Form
    {
        public EmpInfo()
        {
            InitializeComponent();
        }

        private void EmpInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EmpInfo_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        void UpdateGridView()
        {
            EmpDataAccess empDataAccess = new EmpDataAccess();
            empInfoGridView.DataSource = empDataAccess.ShowEmpInfo();
        }

        void ClearFields()
        {
            empNametextBox.Text = String.Empty;
            empAgetextBox.Text = String.Empty;
            empSalarytextBox.Text = String.Empty;
            empLocationtextBox.Text = String.Empty;

            updateEmpIdtextBox.Text = String.Empty;

            updateEmpNameTextBox.Text = String.Empty;
            updateAgeTextBox.Text = String.Empty;
            updateSalaryTextBox.Text = String.Empty;
            updateLocationTextBox.Text = String.Empty;

            removeEmpIdTextBox.Text = String.Empty;

        }

        private void addEmpButton_Click(object sender, EventArgs e)
        {
            EmpDataAccess empDataAccess = new EmpDataAccess();

            if (empDataAccess.InsertEmp(empNametextBox.Text, Convert.ToInt32(empAgetextBox.Text), Convert.ToInt32(empSalarytextBox.Text),empLocationtextBox.Text))
            {
                MessageBox.Show("New Employee Added");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in adding !");
            }
        }

        private void empIdLoadButton_Click(object sender, EventArgs e)
        {
            if (updateEmpIdtextBox.Text == "")
            {
                MessageBox.Show("Please give a Employee Id");
            }
            else
            {
                EmpDataAccess empDataAccess = new EmpDataAccess();
                Employee emp = empDataAccess.ShowEmpInfoById(Convert.ToInt32(updateEmpIdtextBox.Text));

                if (emp == null)
                {
                    MessageBox.Show("Employee not found");
                    UpdateGridView();
                    ClearFields();
                }
                else
                {
                    updateEmpNameTextBox.Text = emp.EmpName;
                    updateAgeTextBox.Text = emp.Age.ToString();
                    updateSalaryTextBox.Text = emp.Salary.ToString();
                    updateLocationTextBox.Text = emp.Location;
                }
            }
        }

        private void updateEmpInfoButton_Click(object sender, EventArgs e)
        {
            EmpDataAccess empDataAccess = new EmpDataAccess();
            if (empDataAccess.UpdateEmpInfo(Convert.ToInt32(updateEmpIdtextBox.Text), updateEmpNameTextBox.Text, Convert.ToInt32(updateAgeTextBox.Text), Convert.ToInt32(updateSalaryTextBox.Text),updateLocationTextBox.Text))
            {
                MessageBox.Show("Information Updated !");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in Updating !");
            }
        }

        private void removeEmpButton_Click(object sender, EventArgs e)
        {
            {
                if (removeEmpIdTextBox.Text == "")
                {
                    MessageBox.Show("Please give a Employee Id");
                }
                else
                {
                    EmpDataAccess empDataAccess = new EmpDataAccess();
                    Employee emp = empDataAccess.ShowEmpInfoById(Convert.ToInt32(removeEmpIdTextBox.Text));
                    if (emp == null)
                    {
                        MessageBox.Show("Order is not available ! Nothing to delete !");
                        ClearFields();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            empDataAccess = new EmpDataAccess();
                            if (empDataAccess.RemoveEmpInfo(Convert.ToInt32(removeEmpIdTextBox.Text)))
                            {
                                MessageBox.Show("Employee Removed");
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

        private void searchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EmpDataAccess empDataAccess = new EmpDataAccess();
            searchDataGridView.DataSource = empDataAccess.ShowEmpInfoByName(searchNameTextBox.Text);
        }

        private void showProductMedicineNameTextBox_TextChanged(object sender, EventArgs e)
        {
            OrderDataAccess orderDataAccess = new OrderDataAccess();
            showMedicineNameDataGridView.DataSource = orderDataAccess.ShowProductsByName(showProductMedicineNameTextBox.Text);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

       
    }
}
