using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management
{
    public class StaffDTO
    {
        public StaffDTO(string MaNhanVien, string SDT, string GioiTinh, string PhongKham)
        {
            this.Ma_NhanVien = MaNhanVien;
            this.So_DienThoai = SDT;
            this.Gioi_Tinh = GioiTinh;
            this.Phong_Kham = PhongKham;
        }
        public StaffDTO(DataRow row)
        {
            this.Ma_NhanVien = row["MaNhanVien"].ToString();
            this.So_DienThoai = row["SDT"].ToString();
            this.Gioi_Tinh = row["GioiTinh"].ToString();
            this.Phong_Kham = row["PhongKham"].ToString();
        }
        private string MaNhanVien;

        public string Ma_NhanVien { get => MaNhanVien; set => MaNhanVien = value; }

        private string SDT;
        public string So_DienThoai { get => SDT; set => SDT = value; }

        private string GioiTinh;
        public string Gioi_Tinh { get => GioiTinh; set => GioiTinh = value; }

        private string PhongKham;
        public string Phong_Kham { get => PhongKham; set => PhongKham = value; }

    }
}
