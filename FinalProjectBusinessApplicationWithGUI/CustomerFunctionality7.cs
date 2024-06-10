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
    public partial class CustomerFunctionality7 : Form
    {
        public CustomerFunctionality7()
        {
            InitializeComponent();
        }

        private void lblCustomer7_Click(object sender, EventArgs e)
        {

        }

        private void CustomerFunctionality7_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = getFeedback();
            dataGridView1.Refresh();
        }
        private List<Customer> getFeedback()
        {
            List<Customer> feedback = new List<Customer>();
            foreach (var i in customerDL.Feedbackinfo)
            {
                feedback.Add(i);
            }
            return feedback;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int s = dataGridView1.SelectedCells[0].RowIndex;
            string username = (string)dataGridView1.Rows[s].Cells[0].Value;
            bool check = customerDL.RemoveFeedBack(username);
            if (check == true)
            {
                // CarsDL.Add_Cars_To_File();
                CustomerInterfaceScreen form = new CustomerInterfaceScreen();
                form.Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
