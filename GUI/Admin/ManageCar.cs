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
    public partial class ManageCar : Form
    {
        public ManageCar()
        {
            InitializeComponent();
            LoadBrands();
            picCarImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ClearFields()
        {
            cmbBrand.SelectedIndex = -1;
            tbModel.Clear();
            tbYear.Clear();
            tbPrice.Clear();
            tbCarID.Clear();
            picCarImage.Image = null;
            picCarImage.ImageLocation = null;
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
            Car car = new Car
            {
                brandid = int.Parse(cmbBrand.SelectedValue.ToString()),
                model = tbModel.Text,
                year = int.Parse(tbYear.Text),
                price = decimal.Parse(tbPrice.Text),
                image = picCarImage.ImageLocation
            };
            car.AddCar();
            MessageBox.Show("Car added successfully.");
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Car car = new Car
            {
                carid = int.Parse(tbCarID.Text),
                brandid = int.Parse(cmbBrand.SelectedValue.ToString()),
                model = tbModel.Text,
                year = int.Parse(tbYear.Text),
                price = decimal.Parse(tbPrice.Text),
                image = picCarImage.ImageLocation
            };
            car.UpdateCar();
            MessageBox.Show("Car updated successfully.");
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Car car = new Car { carid = int.Parse(tbCarID.Text) };
            car.DeleteCar();
            MessageBox.Show("Car deleted successfully.");
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Car car = new Car { carid = int.Parse(tbCarID.Text) };
            Car foundCar = car.SearchCar();
            if (foundCar != null)
            {
                cmbBrand.SelectedValue = foundCar.brandid;
                tbModel.Text = foundCar.model;
                tbYear.Text = foundCar.year.ToString();
                tbPrice.Text = foundCar.price.ToString();
                picCarImage.ImageLocation = foundCar.image;
            }
            else
            {
                MessageBox.Show("Car not found.");
                ClearFields();
            }
        }

        private void btnImgChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picCarImage.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            picCarImage.ImageLocation = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
