using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    public class CarPart
    {
        // Attributes of the CarPart class
        public int? carpartid {  get; set; }
        public int? itemid { get; set; }
        public string carpartname { get; set; } = string.Empty;
        public int? brandid { get; set; }
        public string brandname { get; set; } = string.Empty;
        public string partnumber { get; set; } = string.Empty;
        public decimal partprice { get; set; }
        public string image {  get; set; } = string.Empty;

        // Default Constructor
        public CarPart()
        {
            // default constructor
        }

        // Parameterized Con
        public CarPart(int itemid, int carpartid, string carpartname, int brandid, string brandname, string partnumber, decimal partprice, string image)
        {
            this.carpartid = carpartid;
            this.itemid = itemid;
            this.carpartname = carpartname;
            this.brandid = brandid;
            this.brandname = brandname;
            this.partnumber = partnumber;
            this.partprice = partprice;
            this.image = image;
        }

        // Behaviors or Methods
        public void AddCarPart()
        {
            string sqlItem = "INSERT INTO Item (item_type) VALUES (@ItemType); SELECT SCOPE_IDENTITY();";
            SqlParameter[] itemParams = {
                new SqlParameter("@ItemType", "CarPart")
            };

            int itemId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(sqlItem, itemParams));

            string sqlCarPart = "INSERT INTO CarPart (item_id, car_part_name, brand_id, part_number, part_price, image) VALUES (@ItemID, @CarPartName, @BrandID, @PartNumber, @PartPrice, @Image)";
            SqlParameter[] carPartParams = 
            {
                new SqlParameter("@ItemID", itemId),
                new SqlParameter("@CarPartName", carpartname),
                new SqlParameter("@BrandID", brandid),
                new SqlParameter("@PartNumber", partnumber),
                new SqlParameter("@PartPrice", partprice),
                new SqlParameter("@Image", image)
            };

            DatabaseHelper.ExecuteNonQuery(sqlCarPart, carPartParams);
        }
        public void UpdateCarPart()
        {
            string sqlCarPart = "UPDATE CarPart SET car_part_name = @CarPartName, brand_id = @BrandID, part_number = @PartNumber, part_price = @PartPrice, image = @Image WHERE car_part_id = @CarPartID";
            SqlParameter[] carPartParams = 
            {
                new SqlParameter("@CarPartID", carpartid),
                new SqlParameter("@CarPartName", carpartname),
                new SqlParameter("@BrandID", brandid),
                new SqlParameter("@PartNumber", partnumber),
                new SqlParameter("@PartPrice", partprice),
                new SqlParameter("@Image", image)
            };

            DatabaseHelper.ExecuteNonQuery(sqlCarPart, carPartParams);
        }

        public void DeleteCarPart()
        {
            string sqlItem = "SELECT item_id FROM CarPart WHERE car_part_id = @CarPartID";
            SqlParameter[] fetchParams =
            {
                new SqlParameter("@CarPartID", carpartid)
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
                    throw new Exception("Car Part Not Found");
                }
            }

            string sqlCarPart = "DELETE FROM CarPart WHERE car_part_id = @CarPartID";
            SqlParameter[] carPartParams = 
            {
                new SqlParameter("@CarPartID", carpartid)
            };

            DatabaseHelper.ExecuteNonQuery(sqlCarPart, carPartParams);

            string sqlDeleteItem = "DELETE FROM Item WHERE item_id = @ItemID";
            SqlParameter[] itemParams =
            {
                new SqlParameter ("@ItemID", itemid)
            };

            DatabaseHelper.ExecuteNonQuery (sqlDeleteItem, itemParams);
        }

        public CarPart SearchCarPart()
        {
            string sqlCarPart = "SELECT * FROM CarPart WHERE car_part_id = @CarPartID";
            SqlParameter[] carPartParams = {
                new SqlParameter("@CarPartID", carpartid)
            };

            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(sqlCarPart, carPartParams))
            {
                if (reader.Read())
                {
                    return new CarPart
                    {
                        carpartid = reader.GetInt32(0),
                        itemid = reader.GetInt32(1),
                        carpartname = reader.GetString(2),
                        brandid = reader.GetInt32(3),
                        partnumber = reader.GetString(4),
                        partprice = reader.GetDecimal(5),
                        image = reader.GetString(6)
                    };
                }
            }
            return null;
        }

        public static List<CarPart> GetAllCarParts()
        {
            List<CarPart> carparts = new List<CarPart>();
            string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;
            string query = @"
                           SELECT cp.car_part_id, cp.item_id, cp.car_part_name, cp.brand_id, b.brand_name, cp.part_number, cp.part_price, cp.image 
                           FROM CarPart AS cp 
                           JOIN Brand AS b ON cp.brand_id = b.brand_id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CarPart carpart = new CarPart
                    {
                        carpartid = reader.GetInt32(0),
                        itemid = reader.GetInt32(1),
                        carpartname = reader.GetString(2),
                        brandid = reader.GetInt32(3),
                        brandname = reader.GetString(4),
                        partnumber = reader.GetString(5),
                        partprice = reader.GetDecimal(6),
                        image = reader.IsDBNull(7) ? null : reader.GetString(7)
                    };
                    carparts.Add(carpart);
                }
                reader.Close();
            }
            return carparts;
        }
    }
}
