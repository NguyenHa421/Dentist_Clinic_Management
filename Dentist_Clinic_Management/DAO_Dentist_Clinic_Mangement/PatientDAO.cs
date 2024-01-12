using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Mangement
{
    public class PatientDAO
    {
        private static PatientDAO instance;

        public static PatientDAO Instance
        {
            get { if (instance == null) instance = new PatientDAO(); return PatientDAO.instance; }
            private set { PatientDAO.instance = value; }
        }

        private PatientDAO() { }

        public List<PatientDTO> GetPatientList(int id)
        {
            List<PatientDTO> list = new List<PatientDTO>();
            string query = "select * from BenhNhan where MaBenhNhan = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow dr in data.Rows)
            {
                PatientDTO patient = new PatientDTO(dr);
                list.Add(patient);
            }
            return list;
        } 

        public List<PatientDTO> GetListPatient()
        {
            List <PatientDTO> list = new List<PatientDTO>();
            string query = "select * from BenhNhan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow dr in data.Rows)
            {
                PatientDTO patient= new PatientDTO(dr);
                list.Add(patient);
            }
            return list;
        }

        public List<PatientDTO> SearchPatient(string name)
        {
            List<PatientDTO> list = new List<PatientDTO>();
            string query = string.Format("select * from dbo.BenhNhan where TenBenhNhan like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                PatientDTO patient = new PatientDTO(dr);
                list.Add(patient);
            }
            return list;
        }

        public DataTable GetListBN()
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_BenhNhan");
        }

        public DataTable FindPt(string a)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_Find2 @Word", new object[] { a });
        }
        public bool InsertPatient(string id, string name, int age, string gender, string phone, string email, string addr, string teeth, string alg, float sum, float pay)
        {
            string query = string.Format("INSERT dbo.BenhNhan (MaBenhNhan, TenBenhNhan, Tuoi, GioiTinh, SDT, Email, DiaChi, MoTaDiUng, TinhTrangSK, TongTien, TongTienDaTT) VALUES ('{0}', N'{1}', {2}, N'{3}', '{4}', '{5}', N'{6}', N'{7}', N'{8}', {9}, {10}", id, name, age, gender, phone, email, addr, teeth, alg, sum, pay);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdatePatient(string id, string name, int age, string gender, string phone, string email, string addr, string teeth, string alg, decimal sum, decimal pay)
        {
            string query = string.Format("UPDATE dbo.BenhNhan SET TenBenhNhan = N'{0}', Tuoi = {1}, GioiTinh = N'{2}', SDT = '{3}', Email = '{4}', DiaChi = N'{5}', MoTaDiUng = N'{6}', TinhTrangSK = N'{7}', TongTien = {8}, TongTienDaTT = {9} WHERE MaBenhNhan = '{10}'", name, age, gender, phone, email, addr, teeth, alg, sum, pay, id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
