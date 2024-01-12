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
    public partial class Info_Client_Update : Form
    {
        public Info_Client_Update()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pc_lg_Hide_Click(object sender, EventArgs e)
        {
            tb_oldPass.UseSystemPasswordChar = false;
            Hide_1.Visible = false;
            Unhide_1.Visible = true;
        }

        private void Unhide_1_Click(object sender, EventArgs e)
        {
            tb_oldPass.UseSystemPasswordChar = true;
            Hide_1.Visible = true;
            Unhide_1.Visible = false;
        }

        private void Unhide_2_Click(object sender, EventArgs e)
        {
            tb_newPass.UseSystemPasswordChar = true;
            Hide_2.Visible = true;
            Unhide_2.Visible = false;
        }

        private void Hide_2_Click(object sender, EventArgs e)
        {
            tb_newPass.UseSystemPasswordChar = false;
            Hide_2.Visible = false;
            Unhide_2.Visible = true;
        }

        private void Unhide_3_Click(object sender, EventArgs e)
        {
            tb_anewPass.UseSystemPasswordChar = true;
            Hide_3.Visible = true;
            Unhide_3.Visible = false;
        }

        private void Hide_3_Click(object sender, EventArgs e)
        {
            tb_anewPass.UseSystemPasswordChar = false;
            Hide_3.Visible = false;
            Unhide_3.Visible = true;
        }

        private void bt_Beck_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_Birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            bool Error = false;
            if(tb_oldPass.Text.Length == 0)
            {
                Error = true;
                MessageBox.Show("Mật khẩu cũ không chính xác", "Thông tin cập nhật không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Error == false)
            {
                if (tb_anewPass.Text != tb_newPass.Text)
                {
                    Error = true;
                    MessageBox.Show("Mật khẩu nhập lại sai", "Thông tin cập nhật không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(Error == false)
            {
                lb_Success.Visible = true;
            }
           
        }
    }
}
