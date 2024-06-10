using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBusinessApplicationWithGUI
{
    class MusersDL
    {
        public static List<Musers> userinfo = new List<Musers>();

        public static void Add_UserstoList(Musers user)
        {
            userinfo.Add(user);
        }
        public static string SignIn(Musers user)
        {
            foreach (Musers storedUser in userinfo)
            {
                if (storedUser.GetName() == user.GetName() && storedUser.Getpassword() == user.Getpassword())
                {
                     return storedUser.GetRole();
                }
                
            }
            return null;
        }
        public static void Add_Users_to_File(Musers user, string path)
        {

            path = "C:\\Users\\hamna\\source\\repos\\FinalProjectBusinessApplicationWithGUI\\FinalProjectBusinessApplicationWithGUI\\users.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.GetName() + "," + user.Getpassword() + "," + user.GetRole());
            file.Flush();
            file.Close();

        }
        public static bool ReadUsersfromFile( )
        {
           string path = "C:\\Users\\hamna\\source\\repos\\FinalProjectBusinessApplicationWithGUI\\FinalProjectBusinessApplicationWithGUI\\users.txt";
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path, true);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string username = record.Split(',')[0];
                    string Password = record.Split(',')[1];
                    string role = record.Split(',')[2];
                    Musers user = new Musers(username, Password, role);
                    Add_UserstoList(user);
                    x++;
                    if (x > userinfo.Count)
                    {
                        break;
                    }

                }
                file.Close();
                return true;

            }
            else
            {
                return false;
            }
        }

        public static Boolean ValidCustomerName(string username)
        {
            bool isPresent = false;
            foreach (Musers user in userinfo)
            {
                if (username == user.GetName())
                {
                    isPresent = false;
                    break;
                }
            }
            if (isPresent == false)
            {
               // Console.WriteLine("Username already exists:");
                return isPresent;
            }
            return isPresent;

        }
        public static Boolean ValidAdminName(string username)
        {
            bool isPresent = false;
            foreach (Musers user in userinfo)
            {
                if (username == user.GetName())
                {
                    isPresent = false;
                    break;
                }
            }
            if (isPresent == false)
            {
                //Console.WriteLine("Username already exists:");
                return isPresent;
            }
            return isPresent;

        }
    }
}
