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
    public partial class Updateform : Form
    {
        public Updateform()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string price = txtnewPrice.Text;
            if (txtnewPrice.Text.Length == null)
            {
                MessageBox.Show("Enter Valid Price");
            }
            else
            {
                CarsDL.carinfo[AdminFunctionality4.check].setname(price);
                CarsDL.Add_Cars_To_File();
                MessageBox.Show("price updated successfully");
                AdminInterfaceScreen form = new AdminInterfaceScreen();
                this.Hide();
                form.Show();
            }
            
        }

        private void Updateform_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
