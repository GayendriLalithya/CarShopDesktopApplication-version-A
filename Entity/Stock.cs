using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    internal class Stock
    {
        // Attributes of the Stock Class
        public int? stockid {  get; set; }
        public int? itemid { get; set; }
        public DateTime date { get; set; }
        public int? quantity { get; set; }

        // Default Constructor
        public Stock()
        {
            // default constructor
        }

        // parameterised constructor
        public Stock(int stockid, int itemid, DateTime date, int quantity)
        {
            this.stockid = stockid;
            this.itemid = itemid;
            this.date = date;
            this.quantity = quantity;
        }

        // Behaviours and Methods
        public void AddStock()
        {
            string sql = "INSERT INTO Stock (item_id, date, quantity) VALUES (@ItemId, @Date, @Quantity)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ItemId", this.itemid),
                new SqlParameter("@Date", this.date),
                new SqlParameter("@Quantity", this.quantity)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void UpdateStock()
        {
            string sql = "UPDATE Stock SET item_id = @ItemId, date = @Date, quantity = @Quantity WHERE stock_id = @StockId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StockId", this.stockid),
                new SqlParameter("@ItemId", this.itemid),
                new SqlParameter("@Date", this.date),
                new SqlParameter("@Quantity", this.quantity)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void DeleteStock()
        {
            string sql = "DELETE FROM Stock WHERE stock_id = @StockId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StockId", this.stockid)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

    }
}
