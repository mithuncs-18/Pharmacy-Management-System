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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginUsernameTextBox.Text == "" && loginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Username and password can not be empty");
            }
            else if (loginUsernameTextBox.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if (loginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else
            {
                AdminDataAccess userDataAccess = new AdminDataAccess();
                if (userDataAccess.LoginValidation(loginUsernameTextBox.Text, loginPasswordTextBox.Text))
                {
                    EmpInfo empinfo = new EmpInfo();
                    empinfo.Show();
                    this.Hide();
                }
                else
                {
                    RegistrationDataAccess registrationDataAccess = new RegistrationDataAccess();
                    if (registrationDataAccess.LoginValidation(loginUsernameTextBox.Text, loginPasswordTextBox.Text))
                    {
                        OrderList orderList = new OrderList();
                        orderList.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password");
                    }
                }
            }
        }

        private void registrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.Show();
            this.Hide();

        }
    }
}
