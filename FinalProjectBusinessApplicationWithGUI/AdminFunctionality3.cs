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
    public partial class AdminFunctionality3 : Form
    {
        public AdminFunctionality3()
        {
            InitializeComponent();
        }

        private void btnBackadminFunction3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnfunction3adminNext_Click(object sender, EventArgs e)
        {
           
        }

        private void AdminFunctionality3_Load(object sender, EventArgs e)
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

        private void btnbackdelete_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int s = dataGridView1.SelectedCells[0].RowIndex;
            string carname = (string)dataGridView1.Rows[s].Cells[0].Value;
            bool check = CarsDL.RemoveCar(carname);
            if(check==true)
            {
               // CarsDL.Add_Cars_To_File();
                AdminInterfaceScreen from = new AdminInterfaceScreen();
                from.Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
