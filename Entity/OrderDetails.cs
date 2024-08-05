using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    internal class OrderDetails
    {
        // Attributes of the OrderDetails class
        public int orderdetailsid { get; set; }
        public int orderid { get; set; }
        public int itemid { get; set; }
        public int quantity { get; set; }
        public decimal totalprice { get; set; }

        // Default Constructor
        public OrderDetails()
        {
            // default constructor
        }

        // Parameterised Constructor
        public OrderDetails(int orderdetailsid, int orderid, int itemid, int quantity, decimal totalprice)
        {
            this.orderdetailsid = orderdetailsid;
            this.orderid = orderid;
            this.itemid = itemid;
            this.quantity = quantity;
            this.totalprice = totalprice;
        }

        // Behaviours and Methods
        public void AddOrderDetails()
        {
            string sql = "INSERT INTO OrderDetails (order_id, item_id, quantity, total_price) VALUES (@OrderId, @ItemId, @Quantity, @TotalPrice)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", this.orderid),
                new SqlParameter("@ItemId", this.itemid),
                new SqlParameter("@Quantity", this.quantity),
                new SqlParameter("@TotalPrice", this.totalprice)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void UpdateOrderDetails()
        {
            string sql = "UPDATE OrderDetails SET order_id = @OrderId, item_id = @ItemId, quantity = @Quantity, total_price = @TotalPrice WHERE order_details_id = @OrderDetailsId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderDetailsId", this.orderdetailsid),
                new SqlParameter("@OrderId", this.orderid),
                new SqlParameter("@ItemId", this.itemid),
                new SqlParameter("@Quantity", this.quantity),
                new SqlParameter("@TotalPrice", this.totalprice)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void DeleteOrderDetails()
        {
            string sql = "DELETE FROM OrderDetails WHERE order_details_id = @OrderDetailsId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderDetailsId", this.orderdetailsid)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

    }
}
