using ABCCarTraders.GUI;
using ABCCarTraders.GUI.Admin;
using ABCCarTraders.GUI.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABCCarTraders.Entity;

namespace ABCCarTraders
{
    public partial class LoginForm : Form
    {
        private readonly User user;

        public LoginForm()
        {
            InitializeComponent();
            // Initialize the LoginValidationHelper with the connection string
            user = new User("Data Source=HP-15S\\SQLEXPRESS;Initial Catalog=CarDealershipDB;Integrated Security=True");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lnkRegister_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void lnkRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            this.Hide();  // Hide the login form
            regForm.ShowDialog();  // Show the registration form as a modal dialog
            this.Show();  // Optionally, show the login form again if the registration form is closed
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbUname.Text.Trim();
            string password = tbPsw.Text;

            if (user.Login(email, password, out string usertype))
            {
                if (usertype.Equals("Customer", StringComparison.OrdinalIgnoreCase))
                {
                    // Redirect to Customer Dashboard
                    CustomerDashboard customerDashboard = new CustomerDashboard();
                    customerDashboard.Show();
                    this.Hide();
                }
                else if (usertype.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    // Redirect to Admin Dashboard
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                // Clear All Fields
                tbUname.Clear();
                tbPsw.Clear();

                // Display Message
                MessageBox.Show("Invalid username or password.");

                // Focus the username textbox
                tbUname.Focus();
            }
        }

        private void tbUname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
