using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Healper
{
    public static class SessionManager
    {
        public static bool IsLoggedIn { get; set; }
        public static string UserRole { get; set; }
        public static int UserId { get; set; }


        public static void PerformLogin(string username, string password)
        {
            // Assume credentials are validated and role is retrieved
            SessionManager.IsLoggedIn = true;
            SessionManager.UserRole = DatabaseHelper.GetRoleForUser(username); // Call the method to get the role
            SessionManager.UserId = DatabaseHelper.GetUserId(username); // Similarly, retrieve the user ID
        }
    }
}
