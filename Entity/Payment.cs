using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    internal class Payment
    {
        // Attributes of the Payment Class
        public int? paymentid {  get; set; }
        public int? invoiceid { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; } = string.Empty; // "pending", "paid", "cancelled"
        public decimal amount { get; set; }

        // Default Constructor
        public Payment()
        {
            // default constructor
        }

        // Parameterised constructor
        public Payment(int paymentid, int invoiceid, DateTime date, string status, decimal amount)
        {
            this.paymentid = paymentid;
            this.invoiceid = invoiceid;
            this.date = date;
            this.status = status;
            this.amount = amount;
        }

        // Behaviours and Methods
        public void AddPayment()
        {
            string sql = "INSERT INTO Payment (invoice_id, date, status, amount) VALUES (@InvoiceId, @Date, @Status, @Amount)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@InvoiceId", this.invoiceid),
                new SqlParameter("@Date", this.date),
                new SqlParameter("@Status", this.status),
                new SqlParameter("@Amount", this.amount)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void UpdatePayment()
        {
            string sql = "UPDATE Payment SET invoice_id = @InvoiceId, date = @Date, status = @Status, amount = @Amount WHERE payment_id = @PaymentId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PaymentId", this.paymentid),
                new SqlParameter("@InvoiceId", this.invoiceid),
                new SqlParameter("@Date", this.date),
                new SqlParameter("@Status", this.status),
                new SqlParameter("@Amount", this.amount)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void DeletePayment()
        {
            string sql = "DELETE FROM Payment WHERE payment_id = @PaymentId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PaymentId", this.paymentid)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

    }
}
