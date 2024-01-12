using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Mangement;
using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
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
    public partial class MedList_Admin : Form
    {
        BindingSource medicineListt = new BindingSource();
        public MedList_Admin()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            data_list_medi.DataSource = medicineListt;
            LoadListMedicine();
            AddMedicineBiding();
        }
        void LoadListMedicine()
        {
            medicineListt.DataSource = MedicineDAO.Instance.GetListMedicine();
        }
        void AddMedicineBiding()
        {
            tb_name.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "IDThuoc"));
            tb_age.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Ten_Thuoc"));
            textBox3.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Loai_Thuoc"));
            textBox4.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Mo_ta"));
            textBox5.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "DonVi_Tinh"));
            textBox1.DataBindings.Add(new Binding("Text", data_list_medi.DataSource, "Ngay_HetHan"));
        }

        List<MedicineDTO> SearchMedicine(string name)
        {
            List<MedicineDTO> listMedicine = MedicineDAO.Instance.SearchMedicine(name);
            return listMedicine;
        }

        private void tb_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            AddMedicine add_Medicine = new AddMedicine();
            this.Hide();
            add_Medicine.ShowDialog();
            this.Show();
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label1.Visible = false;
            UpdateMedicine update_Mdc = new UpdateMedicine();
            this.Hide();
            update_Mdc.ShowDialog();
            this.Show();
        }

        private void but_Seen_Click(object sender, EventArgs e)
        {
            LoadListMedicine();
            label1.Visible = false;
        }

        private void but_find_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            medicineListt.DataSource = SearchMedicine(text_name_cli.Text);
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            string id = tb_name.Text;

            if (MedicineDAO.Instance.DeleteMedicine(id))
            {
                LoadListMedicine();
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
