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
    public partial class Homepage_Admin : Form
    {
        public Homepage_Admin()
        {
            InitializeComponent();
        }

        private void bt_accountmanager_Click(object sender, EventArgs e)
        {
            General_Function.Patient_Records patient_Records = new General_Function.Patient_Records();
            this.Hide();
            patient_Records.ShowDialog();
            this.Show();
        }

        private void pic_account_Click(object sender, EventArgs e)
        {

        }

        private void but_medicine_Click(object sender, EventArgs e)
        {

        }
    }
}
