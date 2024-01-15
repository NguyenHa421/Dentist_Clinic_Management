using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management.DAO_Dentist_Clinic_Management
{
    public class ClientDAO
    {

        private static ClientDAO? instance;

        public static ClientDAO Instance
        {
            get { if (instance == null) instance = new ClientDAO(); return ClientDAO.instance; }
            private set { ClientDAO.instance = value; }
        }
        private ClientDAO() { }

        public string ID { get; set; }
        public string Birth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public string GetClientBirth(string sdt, string pass)
        {
            string query = "USP_Client_Birth @SDT , @pass";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { sdt, pass });
            DateTime birth = (DateTime)result;
            return birth.ToString("dd/MM/yyyy");
        }

        public string GetClientPhone(string sdt, string pass)
        {
            string query = "USP_Client_Phone @SDT , @pass";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { sdt, pass });
            return result.ToString();
        }

        public string GetClientAddr(string sdt, string pass)
        {
            string query = "USP_Client_Addr @SDT , @pass";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { sdt, pass });
            return result.ToString();
        }
        public string GetClientID(string sdt, string pass)
        {
            string query = "USP_Client_ID @SDT , @pass";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { sdt, pass });
            return result.ToString();
        }
        public bool Update_Client(string id, string name, DateTime birth, string sddr, string phone, string pass)
        {
            string query = "USP_UpdateClient @id , @name , @birth , @addr , @phone , @pass ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id , name , birth , sddr , phone , pass });
            return result > 0;
        }
        public DataTable GetListPat()
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_List_Pati");
        }
        public DataTable GetListRecL()
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_RecordList");
        }
        
    }
}
