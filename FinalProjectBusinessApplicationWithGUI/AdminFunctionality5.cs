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
    public partial class AdminFunctionality5 : Form
    {
        public AdminFunctionality5()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void AdminFunctionality5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = getcars();
            dataGridView1.Refresh();

         //   dataGridView1.DataSource = CarsDL.carinfo.Select(c => new { c.Car_name }).ToList();
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbackviewcarsadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
