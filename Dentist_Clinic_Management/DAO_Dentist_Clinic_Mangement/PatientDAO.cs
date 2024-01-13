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
            string query = "select * from NguoiDung, KhachHang where KhachHang.MaKH = NguoiDung.MaNguoiDung and KhachHang.MaKH = " + id;
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
            string query = "select * from NguoiDung, KhachHang where KhachHang.MaKH = NguoiDung.MaNguoiDung";
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
            string query = string.Format("select * from NguoiDung, KhachHang where KhachHang.MaKH = NguoiDung.MaNguoiDung and NguoiDung.HoTen like N'%{0}%'", name);
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
        public bool InsertPatient(string id, string name, int role, string pass, DateTime dob, string addr, string phone)
        {
            string query = string.Format("INSERT dbo.NguoiDung (MaNguoiDung, HoTen, VaiTro, MatKhau) VALUES ('{0}', N'{1}', {2}, '{3}'", id, name, role, pass);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("INSERT dbo.KhachHang (MaKH,NgaySinh,DiaChi,SDT) VALUES ('{0}', '{1}', N'{2}', '{3}'", id,dob,addr,phone);
            result += DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdatePatient(string id, string name, int role, string pass, DateTime dob, string addr, string phone)
        {
            string query = string.Format("UPDATE dbo.NguoiDung SET Hoten = N'{0}', VaiTro = {1}, MatKhau = '{2}' WHERE MaNguoiDung = '{3}'", name, role, pass, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("UPDATE dbo.KhachHang SET NgaySinh = '{0}', DiaChi = N'{1}', SDT = '{2}' WHERE MaKH = '{3}'", name, role, pass, id);
            result += DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
