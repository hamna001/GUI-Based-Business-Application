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
    public partial class AdminInterfaceScreen : Form
    {
        public AdminInterfaceScreen()
        {
            InitializeComponent();
        }

        private void btnbackAdminInterface_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdminAddcar_Click(object sender, EventArgs e)
        {
            AdminFunctionality1 form = new AdminFunctionality1();
            form.Show();
           // this.Hide();
        }

        private void btnAdminAdd_Click(object sender, EventArgs e)
        {
            AdminFunctionality2 form = new AdminFunctionality2();
            form.Show();
            this.Hide();
        }

        private void btnAdminDeleteCar_Click(object sender, EventArgs e)
        {
            AdminFunctionality3 form = new AdminFunctionality3();
           form.Show();
           //   this.Hide();
        }

        private void btnAdminViewCars_Click(object sender, EventArgs e)
        {
            AdminFunctionality5 form = new AdminFunctionality5();
            form.Show();
        }

        private void btnAdminSeeListOfCustomers_Click(object sender, EventArgs e)
        {
            AdminFunctionality6 form = new AdminFunctionality6();
            form.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminInterfaceScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminUpdate_Click(object sender, EventArgs e)
        {
            AdminFunctionality4 form = new AdminFunctionality4();
            form.Show();
            this.Hide();
        }

        private void btnAdminListOfOrders_Click(object sender, EventArgs e)
        {
            AdminFunctionality7 form = new AdminFunctionality7();
            form.Show();
        //    this.Hide();
        }

        private void btnAdminfeedback_Click(object sender, EventArgs e)
        {
            AdminFunctionality8 form = new AdminFunctionality8();
            this.Hide();
            form.Show();
        }
    }
}
