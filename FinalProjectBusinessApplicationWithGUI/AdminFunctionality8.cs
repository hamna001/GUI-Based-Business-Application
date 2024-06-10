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
    public partial class AdminFunctionality8 : Form
    {
        public AdminFunctionality8()
        {
            InitializeComponent();
        }

        private void btnadminfeedbackback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminFunctionality8_Load(object sender, EventArgs e)
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
