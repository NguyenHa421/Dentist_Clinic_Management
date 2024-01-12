﻿using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Mangement
{
    public class DentistDAO
    {
        private static DentistDAO instance;

        public static DentistDAO Instance
        {
            get { if (instance == null) instance = new DentistDAO(); return instance; }
            private set { instance = value; }
        }

        private DentistDAO() { }

        public DataTable GetListDate()
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_Dentist");
        }
        public DataTable GetDayWork2(DateTime day, string ma)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_DateWork2 @date , @maNS", new object[] {day, ma});
        }
    }

}
