using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectBusinessApplicationWithGUI
{
    public partial class SignUpScreen : Form
    {
        public SignUpScreen()
        {
            InitializeComponent();
        }

        private void btnNextSignUp_Click(object sender, EventArgs e)
        {
            string username = txtSignUpName.Text;
            string password = txtSignInpassword.Text;
            string path = "C:\\Users\\hamna\\source\\repos\\FinalProjectBusinessApplicationWithGUI\\FinalProjectBusinessApplicationWithGUI\\users.txt";
            if(rdnAdmin.Checked)
            {
                if( MusersDL.ValidAdminName(username)==true && Validations.validation(username,password)==true)
                {
                    Musers user = new Musers(username, password, "Admin");
                    MusersDL.Add_UserstoList(user);
                    MusersDL.Add_Users_to_File(user, path);
                    MessageBox.Show("User Added Successfully!!!");
                }
                
            }
            else if(rdnCustomer.Checked)
            {
               if(MusersDL.ValidCustomerName(username)==true && Validations.validation(username, password) )
                {
                    Musers user = new Musers(username, password, "Customer");
                    MusersDL.Add_UserstoList(user);
                    MusersDL.Add_Users_to_File(user, path);
                    MessageBox.Show("User Added Successfully!!!");
                }
               
            }


            
        }

        private void btnbackSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SignUpScreen_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
