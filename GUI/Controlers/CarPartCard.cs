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
    public partial class CarPartCard : UserControl
    {
        public CarPartCard()
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
                LoadPartImage(value);
            }
        }

        private void LoadPartImage(string imagePath)
        {
            Console.WriteLine("Loading image from path: " + imagePath);  // Log the path to debug
            try
            {
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    pictureBoxCarPart.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Optionally, log when no path is provided
                    Console.WriteLine("No image path provided.");
                }
            }
            catch (Exception ex)
            {
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

        // Property for Car Part Name
        private string _carpartname;
        public string CarPartName
        {
            get { return _carpartname; }
            set
            {
                _carpartname = value;
                lblCarPartName.Text = value;  
            }
        }

        // Property for Car Part Name
        private string _partnumber;
        public string PartNumber
        {
            get { return _partnumber; }
            set
            {
                _partnumber = value;
                lblPartNo.Text = value;  
            }
        }

        // Property for Part Price
        private string _partprice;
        public string PartPrice
        {
            get { return _partprice; }
            set
            {
                _partprice = value;
                lblPrice.Text = "$" + value;  
            }
        }

        private void CarPartCard_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
