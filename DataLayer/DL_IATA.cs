using ModelLayer;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DL_IATA
    {
        public static DL_IATA _instance = null;

        private DL_IATA()
        {

        }

        public static DL_IATA Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DL_IATA();
                }
                return _instance;
            }
        }

        public List<IIATA> GetIATA()
        {
            List<IIATA> iataList = new List<IIATA>();
            using (SqlConnection oConnection = new SqlConnection(DL_Connection.CN))
            {
                SqlCommand cmd = new SqlCommand("sp_GetIATA", oConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                oConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    iataList.Add(new IATA()
                    {
                        Code = dr["Code"].ToString(),
                        Name = dr["Name"].ToString()
                    });
                }
                dr.Close();

                return iataList;
            }
        }
    }
}
