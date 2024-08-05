using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ABCCarTraders.Entity
{
    internal class Car
    {
        // Attributes of the Car Class
        public int carid {  get; set; }
        public int itemid { get; set; }
        public int brandid { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public decimal price { get; set; }
        public string image { get; set; }

        // Default Constructor
        public Car()
        {
            // default car constructor
        }

        // Parameterised Construtor
        public Car(int itemid, int carid, int barndid, string model, int year, decimal price, string image) 
        {
            this.carid = carid;
            this.itemid = itemid;  
            this.brandid = brandid;
            this.model = model;
            this.year = year;
            this.price = price;
            this.image = image;
        }

        // Behaviors or Methods
        public void AddCar()
        {
            string sqlItem = "INSERT INTO Item (item_type) VALUES (@ItemType); SELECT SCOPE_IDENTITY();";
            SqlParameter[] itemParams =
            {
                new SqlParameter("@ItemType", "Car")
            };
            int itemId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(sqlItem, itemParams));

            string sqlCar = "INSERT INTO Car (item_id, brand_id, model, year, price, image) VALUES (@ItemID, @BrandID, @Model, @Year, @Price, @Image)";
            SqlParameter[] carParams =
            {
                new SqlParameter("@ItemID", itemId),
                new SqlParameter("@BrandID", brandid),
                new SqlParameter("@Model", model),
                new SqlParameter("@Year", year),
                new SqlParameter("@Price", price),
                new SqlParameter("@Image", image)
            };

            DatabaseHelper.ExecuteNonQuery(sqlCar, carParams);
        }
        public void UpdateCar()
        {
            string sqlCar = "UPDATE Car SET brand_id = @BrandID, model = @Model, year = @Year, price = @Price, image = @Image WHERE car_id = @CarID";
            SqlParameter[] carParams = 
            {
                new SqlParameter("@CarID", carid),
                new SqlParameter("@BrandID", brandid),
                new SqlParameter("@Model", model),
                new SqlParameter("@Year", year),
                new SqlParameter("@Price", price),
                new SqlParameter("@Image", image)
            };

            DatabaseHelper.ExecuteNonQuery(sqlCar, carParams);
        }
        public void DeleteCar()
        {
            string sqlItem = "SELECT item_id FROM Car WHERE car_id = @CarID";
            SqlParameter[] fetchParams =
            {
                new SqlParameter ("@CarID", carid)
            };

            int itemid;
            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(sqlItem, fetchParams))
            {
                if (reader.Read())
                {
                    itemid = reader.GetInt32(0);
                }
                else
                {
                    throw new Exception("Car Not Found");
                }
            }

            string sqlCar = "DELETE FROM Car WHERE car_id = @CarID";
            SqlParameter[] carParams =
            {
                new SqlParameter("@CarID", carid)
            };

            DatabaseHelper.ExecuteNonQuery (sqlCar, carParams);

            string sqlDeleteItem = "DELETE FROM Item WHERE item_id = @ItemID";
            SqlParameter[] itemParams =
            {
                new SqlParameter("@ItemID", itemid)
            };

            DatabaseHelper.ExecuteNonQuery(sqlDeleteItem, itemParams);
        }

        public Car SearchCar()
        {
            string sqlCar = "SELECT * FROM Car WHERE car_id = @CarID";
            SqlParameter[] carParams = {
                new SqlParameter("@CarID", carid)
            };

            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(sqlCar, carParams))
            {
                if (reader.Read())
                {
                    return new Car
                    {
                        carid = reader.GetInt32(0),
                        itemid = reader.GetInt32(1),
                        brandid = reader.GetInt32(2),
                        model = reader.GetString(3),
                        year = reader.GetInt32(4),
                        price = reader.GetDecimal(5),
                        image = reader.GetString(6)
                    };
                }
            }
            return null;
        }
    }
}
