using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders.GUI.Controlers
{
    public partial class CarCard : UserControl
    {
        public CarCard()
        {
            InitializeComponent();
        }

        // Property for Image
        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                LoadImage(value);
            }
        }

        private void LoadImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    // If the imagePath is a file path
                    pictureBoxCar.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // If not specified, use a default image
                    //pictureBoxCar.Image = Properties.Resources.DefaultImage; // Make sure this resource is added to your project
                }
            }
            catch (Exception ex)
            {
                // Log the error or display a default error image
                //pictureBoxCar.Image = Properties.Resources.DefaultImage; // Fallback if image fails to load
                Console.WriteLine("Failed to load image: " + ex.Message);
            }
        }

        // Property for Brand
        private string _brand;
        public string Brand
        {
            get { return _brand; }
            set
            {
                _brand = value;
                lblBrand.Text = value;  // Assuming you have a Label named lblBrand
            }
        }

        // Property for Model
        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
                lblModel.Text = value;  // Assuming you have a Label named lblModel
            }
        }

        // Property for Year
        private string _year;
        public string Year
        {
            get { return _year; }
            set
            {
                _year = value;
                lblYear.Text = value;  // Assuming you have a Label named lblYear
            }
        }

        // Property for Price
        private string _price;
        public string Price
        {
            get { return _price; }
            set
            {
                _price = value;
                lblPrice.Text = "$" + value;  // Assuming you have a Label named lblPrice
            }
        }

        private void CarCard_Load(object sender, EventArgs e)
        {

        }
    }
}
