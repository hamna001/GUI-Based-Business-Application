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
    public partial class CustomerFunctionality1 : Form
    {
        public CustomerFunctionality1()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CustomerFunctionality1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = getcars();
            dataGridView1.Refresh();
        }
        private List<Cars> getcars()
        {
            List<Cars> car = new List<Cars>();
            foreach (var i in CarsDL.carinfo)
            {

                car.Add(i);

            }
            return car;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
