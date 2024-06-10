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
    public partial class customerfunctionality5 : Form
    {
        public customerfunctionality5()
        {
            InitializeComponent();
        }

        private void btnNextfeedback_Click(object sender, EventArgs e)
        {
            string username = txtnamefeedback.Text;
            string feedback = txtfeedback.Text;
           // foreach(Order order in customerDL.orderinfo)
            {
                //if(username==order.GetUsername())
               // {
                    Customer c = new Customer(feedback, username);
                    customerDL.Add_Feedback_to_File();
                    customerDL.Add_feedback_to_List(c);
                    MessageBox.Show("Thanks for Giving Feedback!!!");
              //  }
                //else
                //{
                //    MessageBox.Show("Order something first please!");
                //}
            }
           
        }

        private void btnbackfeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void customerfunctionality5_Load(object sender, EventArgs e)
        {

        }
    }
}
