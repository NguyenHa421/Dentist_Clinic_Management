using Dentist_Clinic_Management.DAO_Dentist_Clinic_Management;
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
    public partial class Update_Client : Form
    {
        public Update_Client()
        {
            InitializeComponent();
        }

        void LoadList()
        {
            dataGridView1.DataSource = ClientDAO.Instance.GetListRecL();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Dentist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lb_Success_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Error_Add = false;

            if (tb_Dentist.Text.Length == 0)
            {
                Error_Add = true;
                MessageBox.Show("Vui lòng nhập tên nha sĩ!", "Thông tin cập nhật không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Error_Add == false)
            {
                if (tb_Use.Text.Length == 0)
                {
                    Error_Add = true;
                    MessageBox.Show("Vui lòng nhập dịch vụ đã sữ dụng!", "Thông tin cập nhật không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (Error_Add == false)
            {
                lb_Success.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
