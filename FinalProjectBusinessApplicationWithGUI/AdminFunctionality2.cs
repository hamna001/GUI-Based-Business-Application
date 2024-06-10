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
    public partial class AdminFunctionality2 : Form
    {
        public AdminFunctionality2()
        {
            InitializeComponent();
        }

        private void btnfunction2adminNext_Click(object sender, EventArgs e)
        {
            string carname = txtAdminfnction2Carname.Text;
            string carmodel = txtadminfunction2carmodel.Text;
            string carcolor = txtAdminFunction2CarColor.Text;
            string Quantity = txtAdminfunction2Quantity.Text;
            string price = txtAdminfunction2Price.Text;
            Cars car = new Cars(carname, carmodel, carcolor, Quantity, price);
         //   if(carname==car.GetCarName())
            {
            //    MessageBox.Show("Car Already Exists! OR Valid Input Required");
            }
           // else if(carname!=car.GetCarName() && txtAdminfnction2Carname!=null & txtAdminFunction2CarColor!=null && txtadminfunction2carmodel!=null && txtAdminfunction2Price!=null && txtAdminfunction2Quantity!=null)
            {
                CarsDL.Add_Cars_to_List(car);
                CarsDL.Add_Cars_To_File();
                MessageBox.Show(" New Car Added Successfully!!!");
            }
            AdminInterfaceScreen frm = new AdminInterfaceScreen();
            frm.Show();
            this.Hide();
            //frm.Hide();
        }

        private void btnBackadminFunction2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminFunctionality2_Load(object sender, EventArgs e)
        {

        }

        private void lblAdminfunction2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
