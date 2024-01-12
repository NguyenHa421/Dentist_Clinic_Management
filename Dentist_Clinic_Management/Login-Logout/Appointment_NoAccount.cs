using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Login_Logout
{
    public partial class Appointment_NoAccount : Form
    {
       
        public Appointment_NoAccount()
        {
            InitializeComponent();
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void bt_rg_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_rg_Register_Click(object sender, EventArgs e)
        {
            bool Error_Register = false;

            if (tb_name.Text.Length == 0)
            {
                Error_Register = true;
                MessageBox.Show("Vui lòng nhập họ và tên của bạn!", "Thông tin đặt hẹn không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Error_Register == false)
            {
                if (tb_addr.Text.Length == 0)
                {
                    Error_Register = true;
                    MessageBox.Show("Vui lòng nhập địa chỉ của bạn!", "Thông tin đặt hẹn không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (Error_Register == false)
            {
                if (tb_phone.Text.Length == 0)
                {
                    Error_Register = true;
                    MessageBox.Show("Vui lòng nhập số điện thoại của bạn!", "Thông tin đặt hẹn không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (string.IsNullOrEmpty(tb_dentist.Text))
            {
                Error_Register = true;
                MessageBox.Show("Vui lòng chọn nha sĩ!", "Thông tin lịch hẹn không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Error_Register == false)
            {
                Client.Confirm_Appointment confirm_Appointment = new Client.Confirm_Appointment();
                this.Hide();
                confirm_Appointment.Show();
                this.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
