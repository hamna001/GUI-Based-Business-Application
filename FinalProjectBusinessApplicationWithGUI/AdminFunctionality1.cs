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
    public partial class AdminFunctionality1 : Form
    {
        public AdminFunctionality1()
        {
            InitializeComponent();
        }

        private void btnNextadminFunction1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnfunction1adminNext_Click(object sender, EventArgs e)
        {
            string carname = txtAdminfnction1Carname.Text;
            string carmodel = txtadminfunction1carmodel.Text;
            string carcolor = txtAdminFunction1CarColor.Text;
            string Quantity = txtAdminfunction1Quantity.Text;
            string price = txtAdminfunction1Price.Text;
            Cars car = new Cars(carname, carmodel, carcolor, Quantity, price);


            if (carname == car.GetCarName())
            {
                MessageBox.Show("This Car Already Exists! OR valid input needed!");
            }
            if (carname != car.GetCarName())
            {
                CarsDL.Add_Cars_to_List(car);
                CarsDL.Add_Cars_To_File();
                MessageBox.Show("Car Added Successfully!!!");
            }




        }

        private void lblAdminfnction1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminFunctionality1_Load(object sender, EventArgs e)
        {

        }
    }
}
