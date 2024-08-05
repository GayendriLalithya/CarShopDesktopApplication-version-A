using ABCCarTraders.Entity;
using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders.GUI.Admin
{
    public partial class ManageBrands : Form
    {
        public ManageBrands()
        {
            InitializeComponent();
            picBrandImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
        // for clearing the fields
        private void ClearFields()
        {
            tbBrandID.Text = string.Empty;
            tbBrandName.Text = string.Empty;
            picBrandImage.ImageLocation = null;
        }

        private void btnInsertBrand_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand
            {
                brandname = tbBrandName.Text,
                image = picBrandImage.ImageLocation
            };
            brand.AddBrand();
            MessageBox.Show("Brand added successfully.");
            ClearFields();
        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand
            {
                brandid = int.Parse(tbBrandID.Text),
                brandname = tbBrandName.Text,
                image = picBrandImage.ImageLocation
            };
            brand.UpdateBrand();
            MessageBox.Show("Brand updated successfully.");
            ClearFields();
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand {brandid = int.Parse(tbBrandID.Text)};
            brand.DeleteBrand();
            MessageBox.Show("Brand Deleted Successfully");
            ClearFields();
        }

        private void btnSearchBrand_Click(object sender, EventArgs e)
        {
            try
            {
                int brandId = int.Parse(tbBrandID.Text);  // This could throw a FormatException
                Brand brand = new Brand().SearchBrand(brandId);
                if (brand != null)
                {
                    tbBrandName.Text = brand.brandname;
                    picBrandImage.ImageLocation = brand.image;
                }
                else
                {
                    MessageBox.Show("Brand not found.");
                    ClearFields();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                ClearFields();
            }
        }

        // The following codes are used for image choosing and removing
        private void btnImgChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picBrandImage.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            picBrandImage.ImageLocation = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
