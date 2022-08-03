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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (submitButton.Enabled == false)
            {
                submitButton.Enabled = true;
            }
            else
                submitButton.Enabled = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }

            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if (confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm password cannot be empty");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (dateOfBirthDateTimePicker.Text == "")
            {
                MessageBox.Show("Select a date");
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Select a blood group");
            }
            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else
                {
                    Registration registration = new Registration();
                    registration.Name = nameTextBox.Text;
                    registration.Username = usernameTextBox.Text;
                    registration.Password = passwordTextBox.Text;
                    registration.Email = emailTextBox.Text;
                    registration.DateOfBirth = dateOfBirthDateTimePicker.Text;
                    if (maleRadioButton.Checked)
                    {
                        registration.Gender = "Male";
                    }
                    else
                    {
                        registration.Gender = "Female";
                    }
                    registration.BloodGroup = bloodGroupComboBox.Text;


                    RegistrationDataAccess registrationDataAccess = new RegistrationDataAccess();
                    if (registrationDataAccess.UserRegister(registration))
                    {
                        MessageBox.Show("User added");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error in adding");
                    }

                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
    
}

