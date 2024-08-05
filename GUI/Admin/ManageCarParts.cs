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
    public partial class ManageCarParts : Form
    {
        public ManageCarParts()
        {
            InitializeComponent();
            LoadBrands();
            picCarPartImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ClearFields()
        {
            tbCarPartName.Clear();
            cmbBrand.SelectedIndex = -1;
            tbPartNumber.Clear();
            tbPartPrice.Clear();
            tbCarPartID.Clear();
            picCarPartImage.Image = null;
            picCarPartImage.ImageLocation = null;
        }

        private void LoadBrands()
        {
            string sql = "SELECT brand_id, brand_name FROM Brand";
            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(sql, null))
            {
                DataTable brandTable = new DataTable();
                brandTable.Load(reader);
                cmbBrand.DataSource = brandTable;
                cmbBrand.DisplayMember = "brand_name";
                cmbBrand.ValueMember = "brand_id";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CarPart carPart = new CarPart
            {
                carpartname = tbCarPartName.Text,
                brandid = int.Parse(cmbBrand.SelectedValue.ToString()),
                partnumber = tbPartNumber.Text,
                partprice = decimal.Parse(tbPartPrice.Text),
                image = picCarPartImage.ImageLocation
            };
            carPart.AddCarPart();
            MessageBox.Show("Car Part added successfully.");
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CarPart carPart = new CarPart
            {
                carpartid = int.Parse(tbCarPartID.Text),
                carpartname = tbCarPartName.Text,
                brandid = int.Parse(cmbBrand.SelectedValue.ToString()),
                partnumber = tbPartNumber.Text,
                partprice = decimal.Parse(tbPartPrice.Text),
                image = picCarPartImage.ImageLocation
            };
            carPart.UpdateCarPart();
            MessageBox.Show("Car Part Updated successfully.");
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CarPart carPart = new CarPart { carpartid = int.Parse(tbCarPartID.Text) };
            carPart.DeleteCarPart();
            MessageBox.Show("Car Part Deleted Successfully.");
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CarPart carPart = new CarPart { carpartid = int.Parse(tbCarPartID.Text) };
            CarPart foundcarPart = carPart.SearchCarPart();
            if (foundcarPart != null)
            {
                tbCarPartName.Text = foundcarPart.carpartname;
                cmbBrand.SelectedValue = foundcarPart.brandid;
                tbPartNumber.Text = foundcarPart.partnumber;
                tbPartPrice.Text = foundcarPart.partprice.ToString();
                picCarPartImage.ImageLocation = foundcarPart.image;
            }
            else
            {
                MessageBox.Show("Car Part Not Found.");
                ClearFields();
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picCarPartImage.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            picCarPartImage.ImageLocation = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
