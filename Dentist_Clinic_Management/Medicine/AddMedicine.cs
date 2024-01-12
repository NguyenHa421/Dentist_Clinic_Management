using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Mangement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Medicine
{
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
            LoadListMedicine();
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadListMedicine()
        {
            data_list_patient.DataSource = MedicineDAO.Instance.GetListMedicine();
        }
        private void but_Add_Click(object sender, EventArgs e)
        {
            string id = tb_name.Text;
            string name = tb_age.Text;
            string type = textBox3.Text;
            string dentail = textBox4.Text;
            string unit = textBox5.Text;
            DateTime enddate = textBox1.Value;
            if (MedicineDAO.Instance.InsertMedicine(id, name, type, dentail, unit, enddate))
            {
                LoadListMedicine();
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
            }

        }

        private void but_Seen_Click(object sender, EventArgs e)
        {
            LoadListMedicine();
        }
    }
}
