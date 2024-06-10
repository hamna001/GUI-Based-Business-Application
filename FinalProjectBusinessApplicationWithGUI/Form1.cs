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
    public partial class TitlePage : Form
    {
        public TitlePage()
        {
            InitializeComponent();
            string path = "C:\\Users\\hamna\\source\\repos\\FinalProjectBusinessApplicationWithGUI\\FinalProjectBusinessApplicationWithGUI\\users.txt";
            if (MusersDL.ReadUsersfromFile())
            {
              //  MessageBox.Show("Data Loaded From File");
            }
            else
            {
                MessageBox.Show("Data Not Loaded");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void formSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            SignUpScreen form = new SignUpScreen();
            form.Show();
          //  this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNextTitlePage_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            SignInScreen form = new SignInScreen();
            form.Show();
           // this.Hide();
        }
    }
}
