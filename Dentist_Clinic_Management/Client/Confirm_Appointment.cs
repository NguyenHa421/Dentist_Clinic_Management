using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Client
{
    public partial class Confirm_Appointment : Form
    {
        public Confirm_Appointment()
        {
            InitializeComponent();
           
        }

        private void tb_rg_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_rg_Phone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Clock_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            lb_Success.Visible = true;
        }
    }
}
