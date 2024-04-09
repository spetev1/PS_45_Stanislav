using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static string ToString(this User user)
        {
            return $"Name: {user.Name}, Password: {user.Password}";
        }

        public static bool ValidateCredentials(User user, string name, string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("The name cannot be empty");
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("The password cannot be empty");
                return false;
            }

            return true;
        }
        public static User GetUser(UserData userData, string name, string password)
        {

            return userData.GetUser(name, password);
        }
    }
}

