using ABCCarTraders.Entity;
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

namespace ABCCarTraders.GUI.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void manageCarPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageCarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void manageCarPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void manageCarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ManageBrands manageBrands = new ManageBrands();
            manageBrands.Show();
            this.Hide();
        }

        private void manageCarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ManageCar manageCar = new ManageCar();
            manageCar.Show();
            this.Hide();
        }

        private void manageCarPartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ManageCarParts manageCarParts = new ManageCarParts();
            manageCarParts.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            User user = new User();

            // call the logout method
            user.Logout();

            // show the login form
            LoginForm loginForm = new LoginForm();
            //loginForm.Show();

            // close the current form
            this.Close();
        }
    }
}
