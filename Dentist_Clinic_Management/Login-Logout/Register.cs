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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void pt_lg_Unhide_Click(object sender, EventArgs e)
        {
            tb_rg_pw.UseSystemPasswordChar = true;
            pt_lg_Unhide.Visible = false;
            pc_lg_Hide.Visible = true;
        }

        private void pc_lg_Hide_Click(object sender, EventArgs e)
        {
            tb_rg_pw.UseSystemPasswordChar = false;
            pt_lg_Unhide.Visible = true;
            pc_lg_Hide.Visible = false;
        }

        private void bt_rg_Register_Click(object sender, EventArgs e)
        {
            bool Error_Register = false;

            if(tb_rg_Name.Text.Length == 0)
            {
                Error_Register = true;
                MessageBox.Show("Vui lòng nhập họ và tên của bạn!", "Thông tin đăng ký không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(Error_Register == false)
            {
                if (tb_rg_Address.Text.Length == 0)
                {
                    Error_Register = true;
                    MessageBox.Show("Vui lòng nhập địa chỉ của bạn!", "Thông tin đăng ký không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (Error_Register == false)
            {
                if (tb_rg_Phone.Text.Length == 0)
                {
                    Error_Register = true;
                    MessageBox.Show("Vui lòng nhập số điện thoại của bạn!", "Thông tin đăng ký không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (Error_Register == false)
            {
                if (tb_rg_pw.Text.Length < 6)
                {
                    Error_Register = true;
                    MessageBox.Show("Mật khẩu phải có tối thiểu 6 ký tự!", "Thông tin đăng ký không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (Error_Register == false)
            {
                if (tb_rg_pw_ag.Text != tb_rg_pw.Text)
                {
                    Error_Register = true;
                    MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông tin đăng ký không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (Error_Register == false)
            {
                ln_Rg_Success.Visible = true;
                bt_rg_Login.Visible = true;
            }
        }

        private void bt_rg_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTime_rg_ValueChanged(object sender, EventArgs e)
        {
            dateTime_rg.MaxDate = DateTime.Now;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pc_Lg_Deco2_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_rgr_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }
    }
}
