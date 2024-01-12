using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management
{
    public class AccountDTO
    {
        public AccountDTO(string MaNguoiDung, string TenDangNhap, string MatKhau, string TenNguoiDung, string VaiTro)
        {
            this.MaNguoiDung1 = MaNguoiDung;
            this.TenDangNhap1 = TenDangNhap;
            this.MatKhau1 = MatKhau;
            this.TenNguoiDung1 = TenNguoiDung;
            this.VaiTro1 = VaiTro;
        }

        public AccountDTO(DataRow row)
        {
            this.MaNguoiDung1 = row["MaNguoiDung"].ToString();
            this.TenDangNhap1 = row["TenDangNhap"].ToString();
            this.MatKhau1 = row["MatKhau"].ToString();
            this.TenNguoiDung1 = row["TenNguoiDung"].ToString();
            this.VaiTro1 = row["VaiTro"].ToString();
        }
        private string MaNguoiDung;

        public string MaNguoiDung1 { get => MaNguoiDung; set => MaNguoiDung = value; }

        private string TenDangNhap;
        public string TenDangNhap1 { get => TenDangNhap; set => TenDangNhap = value; }

        private string MatKhau;
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        
        private string TenNguoiDung;
        public string TenNguoiDung1 { get => TenNguoiDung; set => TenNguoiDung = value; }

        private string VaiTro;
        public string VaiTro1 { get => VaiTro; set => VaiTro = value; }
    }
}
