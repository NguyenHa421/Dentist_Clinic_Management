using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Mangement
{
    public class AppointmentDAO
    {
        private static AppointmentDAO instance = new AppointmentDAO();
        public static AppointmentDAO Instance
        {
            get { if (instance == null) instance = new AppointmentDAO(); return AppointmentDAO.instance; }
            private set { AppointmentDAO.instance = value; }
        }
        private AppointmentDAO() { }

        public List<AppointmentDTO> GetListAppoint()
        {
            List<AppointmentDTO> list = new List<AppointmentDTO>();
            string query = "elect ap.NgayHen, ap.ThoiGianHen, bn.TenBenhNhan, ns.TenNguoiDung, ns2.TenNguoiDung, ap.PhongKham, ap.TinhTrang"
                            + "from CuocHen ap, BenhNhan bn, NguoiDung ns, NguoiDung ns2"
                            + "where ap.MaBenhNhan = bn.MaBenhNhan and ap.MaNhaSi = ns.MaNguoiDung and ap.MaTroKham = ns2.MaNguoiDung";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AppointmentDTO appointmentDTO = new AppointmentDTO(row);
                list.Add(appointmentDTO);
            }
            return list;
        }
        public DataTable GetList()
        {
           return DataProvider.Instance.ExecuteQuery("exec USP_getAppointMent");
        }

        public DataTable GetListDate(DateTime date)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_getAppointMent_Time @date", new object[] { date });
        }
        public DataTable ThongKe(DateTime start, DateTime end)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_ThongKeAppoint @startDay , @endDay", new object[] { start, end });
        }
        public DataTable ThongKe2(DateTime start, DateTime end, string NhaSi)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_ThongKeAppointNhaSi @startDay , @endDay , @nhaSi", new object[] { start, end, NhaSi });
        }
        public DataTable NhaSiTK(DateTime date, string NhaSi)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_ThongKeAppointNhieu @Day , @nhaSi", new object[]{ date, NhaSi });
        }
    }
}
