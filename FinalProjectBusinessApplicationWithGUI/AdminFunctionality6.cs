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
    public partial class AdminFunctionality6 : Form
    {
        public AdminFunctionality6()
        {
            InitializeComponent();
        }
       
        
           
        

        private void AdminFunctionality6_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = getusers();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private List<Musers> getusers()
        {
            List<Musers> user = new List<Musers>();
            foreach (var i in MusersDL.userinfo)
            {

                user.Add(i);

            }
            return user;
        }

        private void lblshowusers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backbuttonviewusers_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
