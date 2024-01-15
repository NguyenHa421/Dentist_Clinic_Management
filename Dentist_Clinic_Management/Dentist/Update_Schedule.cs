using Dentist_Clinic_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Dentist
{
    public partial class Update_Schedule : Form
    {
        BindingSource schedule = new BindingSource();
        public Update_Schedule()
        {
            InitializeComponent();

        }


        void Load()
        {
            dataGridView1.DataSource = DentistDAO.Instance.LoadSchedule();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_Date_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void lb_rg_phone_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_Success.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_Success2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
