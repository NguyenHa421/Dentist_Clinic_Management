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
    public partial class PatientRecord_Staff : Form
    {
        public PatientRecord_Staff()
        {
            InitializeComponent();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            lb_success.Visible = true;
        }
    }
}