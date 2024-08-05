using ABCCarTraders.Entity;
using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ABCCarTraders.GUI
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            cmbUtype.SelectedItem = "Customer"; // Set "Customer" as the default by name
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Gather input from textboxes
            string email = tbEmail.Text.Trim();
            string password = tbPsw.Text.Trim();
            string contactNo = tbContact.Text.Trim();
            string firstName = tbFname.Text.Trim();
            string lastName = tbLname.Text.Trim();
            string address = tbAddress.Text.Trim();

            // Check if any required field is empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(contactNo) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("All fields are required. Please ensure no field is left blank.");
                return;
            }

            // Validate using Regular Expressions from the ValidationHelper
            bool hasError = false;

            // Validate Email
            if (ValidationHelper.IsValidEmail(email))
            {
                lblEmailError.Text = ""; // Clear the error if valid
            }
            else
            {
                lblEmailError.Text = "Invalid email address.";
                lblEmailError.ForeColor = Color.Red;
                tbEmail.Clear();
                tbEmail.Focus();
                hasError = true;
            }

            // Validate Password
            if (ValidationHelper.IsValidPassword(password))
            {
                lblPasswordError.Text = ""; // Clear the error if valid
            }
            else
            {
                lblPasswordError.Text = "Invalid Password";
                lblPasswordError.ForeColor = Color.Red;
                tbPsw.Clear();
                tbPsw.Focus();
                hasError = true;
            }

            // Validate Contact Number
            if (ValidationHelper.IsValidContactNumber(contactNo))
            {
                lblContactError.Text = ""; // Clear the error if valid
            }
            else
            {
                lblContactError.Text = "Invalid contact number.";
                lblContactError.ForeColor = Color.Red;
                tbContact.Clear();
                tbContact.Focus();
                hasError = true;
            }

            // Check if there were any validation errors
            if (hasError)
            {
                return; // Do not proceed if there's any error
            }

            // Get user type from ComboBox
            string userType = cmbUtype.SelectedItem.ToString();

            // Getting the connction string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;

            // Instantiate RegistrationManager
            User reg = new User(connectionString)
            {
                usertype = userType,
                firstname = firstName,
                lastname = lastName,
                address = address,
                contactno = contactNo,
                email = email,
                password = password,
            };

            // Call the register method in the user class
            try 
            {
                reg.Register();
                MessageBox.Show("User registered successfully!");
                this.Close();

                // show the login form
                LoginForm loginForm = new LoginForm();
                //loginForm.Show();

                // Close the registration page
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed." + ex.Message);
            }
        }

        private void cmbUtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
