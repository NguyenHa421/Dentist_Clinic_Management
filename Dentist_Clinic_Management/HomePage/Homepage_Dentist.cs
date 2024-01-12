using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.HomePage
{
    public partial class Homepage_Dentist : Form
    {
        public Homepage_Dentist()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tb_Birth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Clock_TextChanged(object sender, EventArgs e)
        {

        }

        private void C_bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void C_pc_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void C_bt_View_Click(object sender, EventArgs e)
        {
            Dentist.Info_Dentist info_Dentist = new Dentist.Info_Dentist();
            info_Dentist.ShowDialog();
        }

        private void C_bt_Update_Click(object sender, EventArgs e)
        {
            Dentist.Update_Info_Client update_Info_Client = new Dentist.Update_Info_Client();
            update_Info_Client.ShowDialog();
        }

        private void C_bt_View_Cld_Click(object sender, EventArgs e)
        {
            Dentist.Update_Schedule update_Schedule = new Dentist.Update_Schedule();
            update_Schedule.ShowDialog();
        }
    }
}
