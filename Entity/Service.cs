using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    internal class Service
    {
        // Attributes of the Service Class
        public int serviceid {  get; set; }
        public string servicedescription { get; set; }
        public DateTime date { get; set; }
        public int carid { get; set; }
        public int customerid { get; set; }
        public string vinnumber { get; set; }
        public decimal price { get; set; }

        // Default Constructor
        public Service()
        {
            // Default Construdtor
        }

        // Parameterised Constructor
        public Service(int serviceid, string servicedescription, DateTime date, int carid, int customerid, string vinnumber, decimal price)
        {
            this.serviceid = serviceid;
            this.servicedescription = servicedescription;
            this.date = date;
            this.carid = carid;
            this.customerid = customerid;
            this.vinnumber = vinnumber;
            this.price = price;
        }

        // Behaviours and methods
        public void AddService()
        {
            string sql = "INSERT INTO Service (service_description, date, car_id, customer_id, vin_number, price) VALUES (@ServiceDescription, @Date, @CarId, @CustomerId, @VinNumber, @Price)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ServiceDescription", this.servicedescription),
                new SqlParameter("@Date", this.date),
                new SqlParameter("@CarId", this.carid),
                new SqlParameter("@CustomerId", this.customerid),
                new SqlParameter("@VinNumber", this.vinnumber),
                new SqlParameter("@Price", this.price)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void UpdateService()
        {
            string sql = "UPDATE Service SET service_description = @ServiceDescription, date = @Date, car_id = @CarId, customer_id = @CustomerId, vin_number = @VinNumber, price = @Price WHERE service_id = @ServiceId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ServiceId", this.serviceid),
                new SqlParameter("@ServiceDescription", this.servicedescription),
                new SqlParameter("@Date", this.date),
                new SqlParameter("@CarId", this.carid),
                new SqlParameter("@CustomerId", this.customerid),
                new SqlParameter("@VinNumber", this.vinnumber),
                new SqlParameter("@Price", this.price)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void DeleteService()
        {
            string sql = "DELETE FROM Service WHERE service_id = @ServiceId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ServiceId", this.serviceid)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

    }
}
