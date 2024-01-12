using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Mangement
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool login(string usename, string password, string role)
        {
            string query = "USP_Login @user , @pass , @role";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {usename, password, role});

            return result.Rows.Count > 0;
        }

        public DataTable name(string username, string password)
        {
            string query = "select TenNguoiDung from NguoiDung where TenDangNhap = '" + username + "' and MatKhau = '" + password + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
    }
}
