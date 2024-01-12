using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management
{
    public class DentistDTO
    {
        public DentistDTO(string MaNhaSi, string GioiTinh, string ChuyenMon, string PhongKham)
        {
            this.Ma_NhaSi = MaNhaSi;
            
            this.GioiTinh1 = GioiTinh;
            this.Chuyen_Mon = ChuyenMon;
            this.Phong_Kham = PhongKham;
        }

        public DentistDTO(DataRow row)
        {
            this.Ma_NhaSi = row["MaNhaSi"].ToString();
            this.GioiTinh1 = row["GioiTinh"].ToString();
            this.Chuyen_Mon = row["ChuyenMon"].ToString();
            this.Phong_Kham = row["PhongKham"].ToString();
        }
        private string MaNhaSi;

        public string Ma_NhaSi { get => MaNhaSi; set => MaNhaSi = value; }

        private string GioiTinh;
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }

        private string ChuyenMon;

        public string Chuyen_Mon { get => ChuyenMon; set => ChuyenMon = value; }

        private string PhongKham;
        public string Phong_Kham { get => PhongKham; set => PhongKham = value; }

    }
}
