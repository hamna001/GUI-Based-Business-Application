using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBusinessApplicationWithGUI
{
    class Musers
    {
        private string username;
        private string password;
        private string role;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public Musers(string username, string password, string role)
        {
            this.username = username;
            this.Password = password;
            this.role = role;
        }
        public Musers(string username, string password)
        {
            this.Password = password;
            this.username = username;
            this.role = "NA";
        }
        public string GetName()
        {
            return username;
        }
        public string Getpassword()
        {
            return Password;
        }
        public string GetRole()
        {
            return role;
        }
        public bool IsUserValid()
        {
            if (role == "admin" || role == "customer")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
