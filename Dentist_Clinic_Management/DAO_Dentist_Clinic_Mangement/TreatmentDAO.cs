using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Mangement
{
    public class TreatmentDAO
    {
        private static TreatmentDAO instance;
        public static TreatmentDAO Instance
        {
            get { if (instance == null) instance = new TreatmentDAO(); return TreatmentDAO.instance; }
            private set { TreatmentDAO.instance = value; }
        }

        private TreatmentDAO() { }



        public DataTable ThongKe(DateTime start, DateTime end)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_KeHoachDieuTri @startDay , @endDay", new object[] { start, end });
        }
    }
}
