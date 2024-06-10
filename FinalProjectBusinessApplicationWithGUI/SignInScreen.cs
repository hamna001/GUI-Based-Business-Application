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
    public partial class SignInScreen : Form
    {
        public SignInScreen()
        {
            InitializeComponent();
        }

        private void txtSignInpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNextSignIn_Click(object sender, EventArgs e)
        {
            string username = txtSignInName.Text;
            string password = txtSignInpassword.Text;
            Musers user = new Musers(username, password);
            string validUser = MusersDL.SignIn(user);
            string Role = MusersDL.SignIn(user);
            if (validUser != null && Role=="Admin")
            {
                MessageBox.Show("User is Valid!");
                AdminInterfaceScreen form = new AdminInterfaceScreen();
                form.Show();
                this.Hide();

            }
            else if(validUser==null && txtSignInName==null && txtSignInpassword==null)
            {
                MessageBox.Show("User is InValid OR valid Input Required!");
            }
            if(validUser!=null && Role=="Customer")
            {

                MessageBox.Show("User is Valid!");
                CustomerInterfaceScreen form = new CustomerInterfaceScreen();
                form.Show();
                this.Hide();
            }
            else if(validUser == null && txtSignInName == null && txtSignInpassword == null)
            {
                MessageBox.Show("User is InValid OR valid Input Required!");
            }
        }

        private void btnbackSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SignInScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
