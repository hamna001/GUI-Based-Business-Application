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
    public partial class AdminFunctionality4 : Form
    {
        public static int check;
        public AdminFunctionality4()
        {
            InitializeComponent();
        }

        private void AdminFunctionality4_Load(object sender, EventArgs e)
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

        private void datagridcarshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = CarsDL.carinfo;
            //dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int s = dataGridView1.SelectedCells[0].RowIndex;
            string name = (string)dataGridView1.Rows[s].Cells[0].Value;
            check = CarsDL.checkExixtingCar(name);
            if(check==-1)
            {
                MessageBox.Show("Car does not Exists!");
            }
            else
            {
                Updateform form = new Updateform();
                this.Hide();
                form.Show();
            }
           
        }

        private void btnnextupdate_Click(object sender, EventArgs e)
        {
              
        }

        private void btnbackupdate_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblvewcarsadmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
