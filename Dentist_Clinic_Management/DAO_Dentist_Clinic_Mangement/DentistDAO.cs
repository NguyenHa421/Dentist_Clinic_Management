using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
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
        public List<DentistDTO> GetListDentist()
        {
            List<DentistDTO> list = new List<DentistDTO>();
            string query = "select * from NguoiDung, NhaSi where NhaSi.MaNS = NguoiDung.MaNguoiDung";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                DentistDTO dentist = new DentistDTO(dr);
                list.Add(dentist);
            }
            return list;
        }
        public List<DentistDTO> SearchDentist(string name)
        {
            List<DentistDTO> list = new List<DentistDTO>();
            string query = string.Format("select * from NguoiDung, NhaSi where NhaSi.MaNS = NguoiDung.MaNguoiDung and NguoiDung.HoTen like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                DentistDTO dentist = new DentistDTO(dr);
                list.Add(dentist);
            }
            return list;
        }
    }

}
