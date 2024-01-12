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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pc_lg_Hide_Click(object sender, EventArgs e)
        {
            tb_Hp_Login_Password.UseSystemPasswordChar = false;
            pt_lg_Unhide.Visible = true;
            pc_lg_Hide.Visible = false;
        }

        private void pt_lg_Unhide_Click(object sender, EventArgs e)
        {
            tb_Hp_Login_Password.UseSystemPasswordChar = true;
            pc_lg_Hide.Visible = true;
            pt_lg_Unhide.Visible = false;
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void bt_Lg_Login_Click(object sender, EventArgs e)
        {
            if (tb_Hp_Login_Username.Text == "1")
            {
                HomePage.Homepage_Dentist homepage_Dentist = new HomePage.Homepage_Dentist();
                this.Hide();
                homepage_Dentist.ShowDialog();
                this.Show();
            }
            else if (tb_Hp_Login_Username.Text == "2")
            {
                HomePage.Homepage_Staff homepage_Staff = new HomePage.Homepage_Staff();
                this.Hide();
                homepage_Staff.ShowDialog();
                this.Show();
            }
            else if (tb_Hp_Login_Username.Text == "admin" && tb_Hp_Login_Password.Text == "admin")
            {
                HomePage.Homepage_Admin homepage_Admin = new HomePage.Homepage_Admin(); 
                this.Hide();
                homepage_Admin.ShowDialog();
                this.Show();
            }
            else
            {
                HomePage.Homepage_Client homepage_Client = new HomePage.Homepage_Client();
                this.Hide();
                homepage_Client.ShowDialog();
                this.Show();
            }
        }

        private void Login_Appoint_Click(object sender, EventArgs e)
        {

        }

        private void bt_Login_am_Click(object sender, EventArgs e)
        {
            Appointment_NoAccount appointment_NoAccount = new Appointment_NoAccount();
            this.Hide();
            appointment_NoAccount.ShowDialog();
            this.Show();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void lb_Lg_Info_Click(object sender, EventArgs e)
        {

        }

        private void lb_Lg_Info2_Click(object sender, EventArgs e)
        {

        }

        private void pn_Hp_Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pc_Lg_Deco2_Click(object sender, EventArgs e)
        {

        }

        private void pc_Lg_Deco1_Click(object sender, EventArgs e)
        {

        }
    }
}
