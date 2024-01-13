﻿using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Mangement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Clinic_Management.Users
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
            LoadListStaff();
        }

        private void pic_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadListStaff()
        {
            data_list_staff.DataSource = StaffDAO.Instance.GetStaffList();
        }

        private void but_Add_den_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string pass = tb_pass.Text;
            if (StaffDAO.Instance.InsertStaff(id, name, pass))
                LoadListStaff();
        }

        private void but_Seen_Click(object sender, EventArgs e)
        {
            LoadListStaff();
        }
    }
}
