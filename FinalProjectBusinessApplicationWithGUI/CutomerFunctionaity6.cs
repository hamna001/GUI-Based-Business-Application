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
    public partial class CutomerFunctionaity6 : Form
    {
        public CutomerFunctionaity6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CutomerFunctionaity6_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = getorders();
            dataGridView1.Refresh();
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int s = dataGridView1.SelectedCells[0].RowIndex;
            string carname = (string)dataGridView1.Rows[s].Cells[0].Value;
            bool check = customerDL.RemoveOrder(carname);
            if (check == true)
            {
                // CarsDL.Add_Cars_To_File();
                CustomerInterfaceScreen form = new CustomerInterfaceScreen();
                form.Show();
                this.Hide();
            }
        }
    }
}
