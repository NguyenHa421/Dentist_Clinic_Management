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
    public partial class UpdateMedicine : Form
    {

        public UpdateMedicine()
        {
            InitializeComponent();
            LoadListMedicine();
            AddMedicineBiding();
        }
        void LoadListMedicine()
        {
            data_list_medi.DataSource = MedicineDAO.Instance.GetListMedicine();
        }
        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void AddMedicineBiding()
        {
            tb_name.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "IDThuoc"));
            tb_age.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Ten_Thuoc"));
            textBox3.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Loai_Thuoc"));
            textBox4.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Mo_ta"));
            textBox5.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "DonVi_Tinh"));
            textBox1.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Ngay_HetHan".ToString()));
        }
        private void but_Update_Click(object sender, EventArgs e)
        {
            string id = tb_name.Text;
            string name = tb_age.Text;
            string type = textBox3.Text;
            string dentail = textBox4.Text;
            string unit = textBox5.Text;
            DateTime enddate = textBox1.Value;
            if (MedicineDAO.Instance.UpdateMedicine(id, name, type, dentail, unit, enddate))
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
