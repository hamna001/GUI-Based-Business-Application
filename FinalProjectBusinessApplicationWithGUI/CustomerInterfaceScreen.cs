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
    public partial class CustomerInterfaceScreen : Form
    {
        public CustomerInterfaceScreen()
        {
            InitializeComponent();
        }

        private void CustomerInterfaceScreen_Load(object sender, EventArgs e)
        {

        }

        private void btncustomerSeecars_Click(object sender, EventArgs e)
        {
            CustomerFunctionality1 form = new CustomerFunctionality1();
            form.Show();
            this.Hide();
        }

        private void btncustomerSelectACar_Click(object sender, EventArgs e)
        {
            CustomerFunctionality2 form = new CustomerFunctionality2();
            this.Hide();
            form.Show();
        
        }

        private void btnbackCustomernterface_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCustomerfunctionalityGivefeedback_Click(object sender, EventArgs e)
        {
            customerfunctionality5 form = new customerfunctionality5();
              this.Hide();
            form.Show();
        
        }

        private void btnCustomerFunctionalitydisplaybill_Click(object sender, EventArgs e)
        {
            CustomerFunctionality3 form = new CustomerFunctionality3();
            this.Hide();
            form.Show();
        }

        private void btnCustomerFunctionalitypaybill_Click(object sender, EventArgs e)
        {
            CustomerFunctionality4 form = new CustomerFunctionality4();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CutomerFunctionaity6 form = new CutomerFunctionaity6();
            this.Hide();
            form.Show();
                
        }

        private void btncustomercancelfeedback_Click(object sender, EventArgs e)
        {

        }
    }
}
