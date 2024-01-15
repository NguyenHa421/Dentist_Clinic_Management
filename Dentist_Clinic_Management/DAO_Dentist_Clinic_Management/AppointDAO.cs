using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Mangement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management.DAO_Dentist_Clinic_Management
{
    public class AppointDAO
    {
        private static AppointDAO instance;

        public static AppointDAO Instance
        {
            get { if (instance == null) instance = new AppointDAO(); return AppointDAO.instance; }
            private set { AppointDAO.instance = value; }
        }
        private AppointDAO() { }

        public string ID_C { get; set; }
        public DateTime Date { get; set; }
        public string Dentist {  get; set; }
        public string Day { get; set; }
        public string Hour { get; set; }
        public string ID_D { get; set; }
        public string ID_S { get; set;}
        public DateTime Date_Book { get; set; }
        public int Status { get; set; }

        public string GetIDDentist(string name)
        {
            string query = "USP_Get_ID @Hoten";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { name });
            return result.ToString();
        }
        public DataTable GetListDentist(DateTime date)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_Dentist_Ranh @Hen", new object[] { date });
        }

        public bool Insert_Appoint(string id_K, DateTime date, string id_N, DateTime book)
        {
            string query = "USP_AddAppoint @id , @date , @id2 , @book";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_K , date , id_N ,  book });
            return result > 0;
        }
        public DataTable GetListAppoint(string id)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_ListAppoint @id", new object[] { id });
        }
        public bool CancelAppoint(string id, DateTime hen)
        {
            string query = "USP_CanceledAppoint @id , @hen";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id , hen });
            return result > 0;
        }
    }
}
