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
    public partial class CustomerFunctionality2 : Form
    {
        public CustomerFunctionality2()
        {
            InitializeComponent();
        }

        private void btnnextcustfunctinality2_Click(object sender, EventArgs e)
        {
            int count = 0;
            string carname = txtcustfunction2.Text;
            string Quanitity = txtquanitycustfunction2.Text;
            string username = txtusernamecustfunction2.Text;
            foreach(Musers user in MusersDL.userinfo)
            {
               foreach (Cars car in CarsDL.carinfo)
               {
                    if(carname==car.GetCarName() && username==user.GetName())
                    {
                        Order order = new Order(carname, Quanitity, car.GetcarPrice(), username);
                        customerDL.Add_Orders_To_File();
                        customerDL.Add_Order_toList(order);
                        count++;
                    }
               }
            }
            if (count > 0)
            {
                MessageBox.Show("Car Ordered Successfully!");
            }
            else if (count <= 0)
            {
                MessageBox.Show("Car not exists");
            }
        }

        private void btnbackcustfunctionality2_Click(object sender, EventArgs e)
        {
            this.Hide();     
        }

        private void CustomerFunctionality2_Load(object sender, EventArgs e)
        {

        }
    }
}
