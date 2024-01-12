using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management
{
    public class PatientDTO
    {
        public PatientDTO(string MaBN, string TenBN, int Tuoi, string GioiTinh, string SDT, string Email, string DiaChi, string MoTaDiUng, string TinhTrangSK, decimal TongTien, decimal TongTienDaTT)
        {
            this.Ma_BN = MaBN;
            this.Ten_BN = TenBN;
            this.TuoiBN = Tuoi;
            this.Gioi_tinh = GioiTinh;
            this.Sdt = SDT;
            this.EmailBN = Email;
            this.DiaChiBN = DiaChi;
            this.MoTa_DiUng = MoTaDiUng;
            this.TinhTrang_SK = TinhTrangSK;
            this.TongTien_CanTT = TongTien;
            this.TongTien_DaTT = TongTienDaTT;
        }
        public PatientDTO(string MaBN, string TenBN, int Tuoi, string GioiTinh, string SDT, string Email, string DiaChi, string MoTaDiUng, string TinhTrangSK)
        {
            this.Ma_BN = MaBN;
            this.Ten_BN = TenBN;
            this.TuoiBN = Tuoi;
            this.Gioi_tinh = GioiTinh;
            this.Sdt = SDT;
            this.EmailBN = Email;
            this.DiaChiBN = DiaChi;
            this.MoTa_DiUng = MoTaDiUng;
            this.TinhTrang_SK = TinhTrangSK;
        }

        public PatientDTO(DataRow row)
        {
            this.Ma_BN = row["MaBenhNhan"].ToString();
            this.Ten_BN = row["TenBenhNhan"].ToString();
            this.TuoiBN = (int)row["Tuoi"];
            this.Gioi_tinh = row["GioiTinh"].ToString();
            this.Sdt = row["SDT"].ToString();
            this.EmailBN = row["Email"].ToString();
            this.DiaChiBN = row["DiaChi"].ToString();
            this.MoTa_DiUng = row["MoTaDiUng"].ToString();
            this.TinhTrang_SK = row["TinhTrangSK"].ToString();
            this.TongTien_CanTT = (decimal)Convert.ToDouble(row["TongTien"].ToString());
            this.TongTien_DaTT = (decimal)Convert.ToDouble(row["TongTienDaTT"].ToString());
        }

        private string MaBenhNhan;

        public string Ma_BN { get => MaBenhNhan; set => MaBenhNhan = value; }
        private string TenBenhNhan;
        public string Ten_BN { get => TenBenhNhan; set => TenBenhNhan = value; }
        private int Tuoi;
        public int TuoiBN { get => Tuoi; set => Tuoi = value; }
        private string GioiTinh;
        public string Gioi_tinh { get => GioiTinh; set => GioiTinh = value; }
        private string SDT;
        public string Sdt { get => SDT; set => SDT = value; }
        private string Email;
        public string EmailBN { get => Email; set => Email = value; }
        private string DiaChi;
        public string DiaChiBN { get => DiaChi; set => DiaChi = value; }
        private string MoTaDiUng;
        public string MoTa_DiUng { get => MoTaDiUng; set => MoTaDiUng = value; }
        private string TinhTrangSK;
        public string TinhTrang_SK { get => TinhTrangSK; set => TinhTrangSK = value; }
        private decimal TongTien;
        public decimal TongTien_CanTT { get => TongTien; set => TongTien = value; }
        private decimal TongTienDaTT;
        public decimal TongTien_DaTT { get => TongTienDaTT; set => TongTienDaTT = value; }
    }
}
