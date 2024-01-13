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
    public partial class Homepage_Staff : Form
    {
        public Homepage_Staff()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnShowForm.Controls.Add(childForm);
            pnShowForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void C_bt_ViewProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.Info_Staff());
        }

        private void C_bt_AddAppointment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.Appointment_Staff());
        }

        private void C_bt_ViewMedicine_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.ViewMedicine_Staff());
        }

        private void C_bt_PatientRecord_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.PatientRecord_Staff());
        }
        private void C_bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
