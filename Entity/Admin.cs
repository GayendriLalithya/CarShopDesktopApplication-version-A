using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    public class Admin : User
    {
        // Attributes of the Admin class
        public int adminid {  get; set; }

        // Default Constructor
        public Admin()
        {
            // default constructor
        }
        public Admin(string usertype, string firstname, string lastname, string address, string contactno, string email, string password, int adminid) : base (usertype, firstname, lastname, address, contactno, email, password)
        {
            this.adminid = adminid;
        }

        // behaviors and methods
        public void ManageCars()
        {
            // Manage cars logic
        }
        public void ManageCarParts()
        {
            // Manage car parts logic
        }
        public void ManageUser()
        {
            // Manage customers logic
        }
        public void GenerateReports()
        {
            // Report generation logic
        }
    }
}
