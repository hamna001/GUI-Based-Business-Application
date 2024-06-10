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
    public partial class CustomerFunctionality4 : Form
    {
        public CustomerFunctionality4()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string name = txtnameforpaying.Text;
            string price = txtpriceforpaying.Text;
            foreach(Order order in customerDL.orderinfo)
            {
              if(name==order.GetUsername() && price==order.Get_productPricetoOrder())
              {
                    MessageBox.Show("BILL PAYED SUCCESSFULLY!!!");
              }
              else if(name!=order.GetUsername() && price!=order.Get_productPricetoOrder())
              {
                    MessageBox.Show("INVALID USERNAME ORR INVALID PRICEE");
              }
            }
        }
    }
}
