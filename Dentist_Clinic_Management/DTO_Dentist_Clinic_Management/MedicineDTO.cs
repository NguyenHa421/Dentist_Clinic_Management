using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management
{
    public class MedicineDTO
    {
        public MedicineDTO(string MaThuoc, string TenThuoc, string LoaiThuoc, string MoTa, string DVT, DateTime NgayHetHan)
        {
            this.IDThuoc = MaThuoc;
            this.Ten_Thuoc = TenThuoc;
            this.Loai_Thuoc= LoaiThuoc;
            this.Mo_ta = MoTa;
            this.DonVi_Tinh = DVT;
            this.Ngay_HetHan = NgayHetHan;
        }

        public MedicineDTO(DataRow row)
        {
            this.IDThuoc = row["MaThuoc"].ToString();
            this.Ten_Thuoc = row["TenThuoc"].ToString();
            this.Loai_Thuoc = row["LoaiThuoc"].ToString();
            this.Mo_ta = row["MoTa"].ToString();
            this.DonVi_Tinh = row["DVT"].ToString();
            this.Ngay_HetHan = (DateTime)row["NgayHetHan"];
        }
        private string MaThuoc;

        public string IDThuoc { get => MaThuoc; set => MaThuoc = value; }

        private string TenThuoc;
        public string Ten_Thuoc { get => TenThuoc; set => TenThuoc = value; }


        private string LoaiThuoc;

        public string Loai_Thuoc { get => LoaiThuoc; set => LoaiThuoc = value; }

        private string MoTa;
        public string Mo_ta { get => MoTa; set => MoTa = value; }
        private string DVT;
        public string DonVi_Tinh { get => DVT; set => DVT = value; }
        private DateTime NgayHetHan; 
        public DateTime Ngay_HetHan { get => NgayHetHan; set => NgayHetHan = value; }
         }
}
