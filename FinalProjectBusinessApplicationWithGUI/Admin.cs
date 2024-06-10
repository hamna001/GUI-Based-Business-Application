using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBusinessApplicationWithGUI
{
    class Admin:Musers
    {
        public Admin(string username, string password, string role) : base(username, password, role)
        {

        }
        public Admin(string username, string password) : base(username, password)
        {

        }
    }
}
