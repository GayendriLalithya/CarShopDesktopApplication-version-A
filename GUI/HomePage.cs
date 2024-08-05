using ABCCarTraders.Entity;
using ABCCarTraders.GUI.Controlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders.GUI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            cmbItemtype.SelectedItem = "Car"; // Set "Car" as the default by name

            // Attach event handler
            cmbItemtype.SelectedIndexChanged += cmbItemtype_SelectedIndexChanged;

            // Set up combo box
            cmbItemtype.Items.Add("Car");
            cmbItemtype.Items.Add("Car Part");
            cmbItemtype.SelectedIndex = 0;  // Default to showing cars, triggers event if event handler is attached before
        }

        private void LoadCarCards()
        {
            List<Car> cars = Car.GetAllCars();  // Fetch all cars
            flowPanelHome.Controls.Clear();  // Clear existing controls in the FlowLayoutPanel

            foreach (Car car in cars)
            {
                CarCard card = new CarCard();
                card.Brand = car.brand;
                card.Model = car.model;
                card.Year = car.year.ToString();
                card.Price = $"${car.price}";
                card.ImagePath = car.image;  // Ensure this is the correct property from Car object
                flowPanelHome.Controls.Add(card);
            }
        }

        private void LoadCarPartCards()
        {
            List<CarPart> carparts = CarPart.GetAllCarParts();  // Fetch all carparts
            flowPanelHome.Controls.Clear();  // Clear existing controls in the FlowLayoutPanel

            foreach (CarPart carpart in carparts)
            {
                CarPartCard card = new CarPartCard();
                card.Brand = carpart.brandname;
                card.CarPartName = carpart.carpartname;
                card.PartNumber = carpart.partnumber;
                card.PartPrice = carpart.partprice.ToString();
                card.ImagePath = carpart.image;  
                flowPanelHome.Controls.Add(card);
            }
        }

        private void cmbItemtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbItemtype.SelectedItem.ToString())
            {
                case "Car":
                    LoadCarCards();
                    break;
                case "Car Part":
                    LoadCarPartCards();
                    break;
                default:
                    break;
            }
        }


        private void flwpnlCar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Explicit call to load cars if not triggering from SelectedIndexChanged
            LoadCarCards();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Hide();
        }
    }
}
