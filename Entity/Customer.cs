using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    internal class Customer : User
    {
        // Attributes of the Customer Class
        public int? customerid {  get; set; }

        // Default Constructor
        public Customer()
        {
            // this is the default constructor
        }

        // Parameterised Constructor
        public Customer(string usertype, string firstname, string lastname, string address, string contactno, string email, string password, int customerid) : base (usertype, firstname, lastname, address, contactno, email, password)
        {
            this.customerid = customerid;
        }

        // Behaviors or Methods of the Customer Class
        // Manage Customer
        public void InsertCustomer()
        {
            // Insert Customer logic
        }
        public void UpdateCustomer()
        {
            // Update Customer logic
        }
        public void DeleteCustomer()
        {
            // Delete Customer logic
        }
        public void SearchCustomer()
        {
            // Search Customer logic
        }
    }
}
