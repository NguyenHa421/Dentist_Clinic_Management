using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Mangement
{
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            private set { instance = value; }
        }
        private StaffDAO() { }
        public List<StaffDTO> GetListStaff()
        {
            List<StaffDTO> list = new List<StaffDTO>();
            string query = "select * from NguoiDung where VaiTro = 2";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                StaffDTO staff = new StaffDTO(dr);
                list.Add(staff);
            }
            return list;
        }
        public List<StaffDTO> SearchStaff(string name)
        {
            List<StaffDTO> list = new List<StaffDTO>();
            string query = string.Format("select * from NguoiDung where VaiTro = 2 and HoTen like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                StaffDTO staff = new StaffDTO(dr);
                list.Add(staff);
            }
            return list;
        }
    }
}
