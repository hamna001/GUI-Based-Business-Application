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
    public partial class AdminFunctionality7 : Form
    {
        public AdminFunctionality7()
        {
            InitializeComponent();
        }
        private void dataBind()
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AdminFunctionality7_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = getorders();
            dataGridView1.Refresh();
        }

        private void btnadminvieworders_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private List<Order> getorders()
        {
            List<Order> order = new List<Order>();
            foreach (var i in customerDL.orderinfo)
            {

                order.Add(i);

            }
            return order;
        }
    }
}
