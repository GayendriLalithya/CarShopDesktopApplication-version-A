using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ABCCarTraders.Healper;

namespace ABCCarTraders.Entity
{
    public class Brand
    {
        // Attributes of the Brand class
        public int? brandid { get; set; }
        public string brandname { get; set; } = string.Empty;
        public string image {  get; set; } = string.Empty;

        // Database Connection
        //private readonly string connectionString;

        // Default Constructor
        public Brand()
        {
            // default constructor
        }
        
        // Parameterised Constructor
        public Brand(int brandid, string brandname, string image)
        {
            this.brandid = brandid;
            this.brandname = brandname;
            this.image = image;
        }
        /*
        public Brand(string connectionString)
        {
            this.connectionString = connectionString;
        }
        */
        // Behavoiors and Method
        public void AddBrand()
        {
            string sql = "INSERT INTO Brand (brand_name, image) VALUES (@BrandName, @Image)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@BrandName", brandname),
                new SqlParameter("@Image", image)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }
        public Brand SearchBrand(int id)
        {
            string sql = "SELECT * FROM Brand WHERE brand_id = @BrandId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@BrandId", id)
            };

            using (SqlDataReader reader =  DatabaseHelper.ExecuteReader(sql, parameters))
            {
                if (reader.Read())
                {
                    return new Brand
                    {
                        brandid = reader.GetInt32(0),
                        brandname = reader.GetString(1),
                        image = reader.GetString(2)
                    };
                }
            }
            return null;
        }
        public void UpdateBrand()
        {
            string sql = "UPDATE Brand SET brand_name = @BrandName, image = @Image WHERE brand_id = @BrandId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@BrandId", brandid),
                new SqlParameter("@BrandName", brandname),
                new SqlParameter("@Image", image)
            };
            DatabaseHelper.ExecuteNonQuery (sql, parameters);
        }
        public void DeleteBrand()
        {
            string sql = "DELETE FROM Brand WHERE brand_id = @BrandId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@BrandId", brandid)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}
