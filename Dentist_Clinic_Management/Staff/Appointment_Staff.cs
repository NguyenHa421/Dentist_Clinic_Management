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
    public partial class Appointment_Staff : Form
    {
        public Appointment_Staff()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Form f = new AppointmentInfo_Staff();
            f.ShowDialog();
        }
    }
}