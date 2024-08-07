using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders.Entity
{
    public class User
    {
        // Attributes of the user class
        public int? userid {  get; set; }
        public string usertype { get; set; } = string.Empty;
        public string firstname { get; set; } = string.Empty;
        public string lastname { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public string contactno { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;

        // Database Connection 
        private readonly string connectionString;

        // Default Constructor
        public User()
        {
            // This is the default constructor of the user class
        }

        // Parameterised Constructors
        public User (string usertype, string firstname, string lastname, string address, string contactno, string email, string password)
        {
            this.usertype = usertype;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.contactno = contactno;
            this.email = email;
            this.password = password;
        }
        
        public User(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Behavours/ methods of the user class
        public void Register()
        {
            // For password hashing
            string hashedPassword = PasswordHelper.HashPassword(this.password);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Insert into user table and getting the user id
                        string sqlInsertUser = @"
                                               INSERT INTO Users (user_type, first_name, last_name, address, contact_no, email, password)
                                               VALUES (@UserType, @FirstName, @LastName, @Address, @ContactNo, @Email, @Password)
                                               SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdUser = new SqlCommand(sqlInsertUser, conn, tran);
                        cmdUser.Parameters.AddWithValue("@UserType", usertype);
                        cmdUser.Parameters.AddWithValue("@FirstName", firstname);
                        cmdUser.Parameters.AddWithValue("@LastName", lastname);
                        cmdUser.Parameters.AddWithValue("@Address", address);
                        cmdUser.Parameters.AddWithValue("@ContactNo", contactno);
                        cmdUser.Parameters.AddWithValue("@Email", email);
                        cmdUser.Parameters.AddWithValue("@Password", hashedPassword); // using hashedPassword instead of using password

                        // Executing command and getting the user id
                        int userid = Convert.ToInt32(cmdUser.ExecuteScalar());

                        // Insert into customer and admin tables based on the user type
                        if (usertype.Equals("Customer", StringComparison.OrdinalIgnoreCase))
                        {
                            string sqlInsertCustomer = @"
                                                       INSERT INTO Customers (user_id)
                                                       VALUES (@UserId)";

                            SqlCommand cmdCustomer = new SqlCommand(sqlInsertCustomer, conn, tran);
                            cmdCustomer.Parameters.AddWithValue("@UserId", userid);
                            cmdCustomer.ExecuteNonQuery();
                        }
                        else if (usertype.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            string sqlInsertAdmin = @"
                                                    INSERT INTO Admin (user_id)
                                                    VALUES (@UserId)";

                            SqlCommand cmdAdmin = new SqlCommand(sqlInsertAdmin, conn, tran);
                            cmdAdmin.Parameters.AddWithValue("@UserId", userid);
                            cmdAdmin.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw new ApplicationException("Error during registration" + ex.Message);
                    }
                }
            }
        }

        public bool Login(string email, string password, out string usertype)
        {
            usertype = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT user_type, password FROM Users WHERE email = @Email";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedHashedPassword = reader["password"].ToString();
                    if (PasswordHelper.VerifyPassword(storedHashedPassword, password))
                    {
                        usertype = reader["user_type"].ToString();
                        return true;
                    }
                }
                return false;
            }
        }


        public void UpdateProfile()
        {
            // Profile update logic
        }

        public void Logout()
        {
            MessageBox.Show("You have been logged out successfully.");
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
