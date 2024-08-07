using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    internal class Cart
    {
        // Attributes of the Cart class
        public int? cartid { get; set; }
        public int? customerid { get; set; }
        public int? itemid { get; set; }
        public int? quantity { get; set; }

        // Default Constructor
        public Cart()
        {
            // default constructor
        }

        // Parameterized Constructor
        public Cart(int cartId, int customerId, int itemId, int quantity)
        {
            this.cartid = cartId;
            this.customerid = customerId;
            this.itemid = itemId;
            this.quantity = quantity;
        }

        // Method to insert a new cart record
        public void AddCart()
        {
            string sql = "INSERT INTO Cart (customer_id, item_id, quantity) VALUES (@CustomerId, @ItemId, @Quantity)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@CustomerId", customerid),
                new SqlParameter("@ItemId", itemid),
                new SqlParameter("@Quantity", quantity)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        // Method to update an existing cart record
        public void UpdateCart()
        {
            string sql = "UPDATE Cart SET customer_id = @CustomerId, item_id = @ItemId, quantity = @Quantity WHERE cart_id = @CartId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@CartId", cartid),
                new SqlParameter("@CustomerId", customerid),
                new SqlParameter("@ItemId", itemid),
                new SqlParameter("@Quantity", quantity)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        // Method to delete a cart record
        public void DeleteCart()
        {
            string sql = "DELETE FROM Cart WHERE cart_id = @CartId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@CartId", cartid)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        // Method to search for a cart record by cart ID
        public void SearchCart()
        {
            // search logic
        }
    }
}
