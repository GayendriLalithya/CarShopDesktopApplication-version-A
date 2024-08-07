using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    public class Order
    {
        // Attributes of the Order Class
        public int? orderid {  get; set; }
        public int? customerid { get; set; }
        public DateTime orderdate { get; set; }
        public string status { get; set; } = string.Empty;

        // Default Constructor
        public Order()
        {
            // default constructor
        }

        // Parameterised Constructor
        public Order(int orderid, int customerid, DateTime orderdate, string status)
        {
            this.orderid = orderid;
            this.customerid = customerid;
            this.orderdate = orderdate;
            this.status = status;
        }

        // Behaviour or methods of the order class
        public void AddOrder()
        {
            string sql = "INSERT INTO Orders (customer_id, order_date, status) VALUES (@CustomerId, @OrderDate, @Status)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerId", this.customerid),
                new SqlParameter("@OrderDate", this.orderdate),
                new SqlParameter("@Status", this.status)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }
        public void UpdateOrder()
        {
            string sql = "UPDATE Orders SET customer_id = @CustomerId, order_date = @OrderDate, status = @Status WHERE order_id = @OrderId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", this.orderid),
                new SqlParameter("@CustomerId", this.customerid),
                new SqlParameter("@OrderDate", this.orderdate),
                new SqlParameter("@Status", this.status)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void DeleteOrder()
        {
            string sql = "DELETE FROM Orders WHERE order_id = @OrderId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", this.orderid)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public string ViewOrderStatus()
        {
            string sql = "SELECT status FROM Orders WHERE order_id = @OrderId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", this.orderid)
            };
            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(sql, parameters))
            {
                if (reader.Read())
                {
                    return reader["status"].ToString();
                }
                else
                {
                    return "Order not found.";
                }
            }
        }

    }
}
