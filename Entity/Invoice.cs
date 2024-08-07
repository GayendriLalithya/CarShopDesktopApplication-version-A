using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    internal class Invoice
    {
        // Attributes of the invoice Class
        public int? invoiceid {  get; set; }
        public int? orderid { get; set; }
        public int? serviceid { get; set; }
        public decimal totalamount { get; set; }

        // Default Constructor
        public Invoice()
        {
            // default constructor
        }
        
        // parameterised constructor
        public Invoice(int invoiceid, int orderid, int serviceid, decimal totalamount)
        {
            this.orderid = orderid;
            this.invoiceid = invoiceid;
            this.serviceid = serviceid;
            this.totalamount = totalamount;
        }

        // Behaviours and Methods
        public void AddInvoice()
        {
            string sql = "INSERT INTO Invoice (order_id, service_id, total_amount) VALUES (@OrderId, @ServiceId, @TotalAmount)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", this.orderid),
                new SqlParameter("@ServiceId", this.serviceid),
                new SqlParameter("@TotalAmount", this.totalamount)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void UpdateInvoice()
        {
            string sql = "UPDATE Invoice SET order_id = @OrderId, service_id = @ServiceId, total_amount = @TotalAmount WHERE invoice_id = @InvoiceId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@InvoiceId", this.invoiceid),
                new SqlParameter("@OrderId", this.orderid),
                new SqlParameter("@ServiceId", this.serviceid),
                new SqlParameter("@TotalAmount", this.totalamount)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void DeleteInvoice()
        {
            string sql = "DELETE FROM Invoice WHERE invoice_id = @InvoiceId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@InvoiceId", this.invoiceid)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

    }
}
