using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Staff
{
    public partial class AppointmentInfo_Staff : Form
    {
        public AppointmentInfo_Staff()
        {
            InitializeComponent();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
