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
    public partial class Info_Client : Form
    {
        public Info_Client()
        {
            InitializeComponent();
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            Info_Client_Update info_Client_Update = new Info_Client_Update();
            this.Hide();
            info_Client_Update.ShowDialog();
            this.Show();
        }

        private void bt_Beck_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
