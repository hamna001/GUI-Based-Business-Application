using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBusinessApplicationWithGUI
{
    class Validations
    {
        public static bool validation(string password, string name)
        {

            if (password.Length > 8)
            {
                return false;
            }
            int flag = 0;

            // Checking if string contians special character
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 48 && password[i] <= 57) ||
                    (password[i] >= 65 && password[i] <= 90) ||
                    (password[i] >= 97 && password[i] <= 122))
                {
                    continue;
                }
                else
                {

                    flag = 1;
                    break;
                }
            }
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 48 && password[i] <= 57) ||
                    (password[i] >= 65 && password[i] <= 90) ||
                    (password[i] >= 97 && password[i] <= 122))
                {
                    continue;
                }
                else
                {

                    flag = 1;
                    break;
                }
            }
            // Checking if username contians special character or integer
            for (int i = 0; i < name.Length; i++)
            {
                if (
                    (name[i] >= 65 && name[i] <= 90) ||
                    (name[i] >= 97 && name[i] <= 122))
                {
                    continue;
                }
                else
                {

                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("No special character or integer  is allowed in username or password");
                return false;
            }

            return true;
        }
    }
}
