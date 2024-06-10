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
    public partial class CustomerFunctionality3 : Form
    {
        public CustomerFunctionality3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerFunctionality3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = getBill();
            dataGridView1.Refresh();
        }
        private List<Order> getBill()
        {
            List<Order> ord = new List<Order>();
            foreach (var i in customerDL.orderinfo)
            {
                ord.Add(i);
            }
            return ord;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
