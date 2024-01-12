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
    public partial class Add_Client : Form
    {
        public Add_Client()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Error_Add = false;

            if (tb_Name.Text.Length == 0)
            {
                Error_Add = true;
                MessageBox.Show("Vui lòng nhập họ và tên của bệnh nhân!", "Thông tin hồ sơ không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Error_Add == false)
            {
                if (tb_Address.Text.Length == 0)
                {
                    Error_Add = true;
                    MessageBox.Show("Vui lòng nhập địa chỉ của bệnh nhân!", "Thông tin hồ sơ không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (Error_Add == false)
            {
                if (tb_Phone.Text.Length == 0)
                {
                    Error_Add = true;
                    MessageBox.Show("Vui lòng nhập số điện thoại của bệnh nhân!", "Thông tin hồ sơ không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(Error_Add == false)
            {
                lb_Success.Visible = true;
            }
        }

        private void lb_Success_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_rg_phone_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lb_rg_datebirth_Click(object sender, EventArgs e)
        {

        }

        private void lb_rg_Name_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_rg_Addr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_rg_Name_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_rg_Phone_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
