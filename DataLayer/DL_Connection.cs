using System.Configuration;

namespace DataLayer
{
    /// <summary>
    /// Permite consultar las diferentes configuraciones del web.config
    /// </summary>
    public class DL_Connection
    {
        public static string CN = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        public static string Service = ConfigurationManager.AppSettings["URLVivaAir"];
    }
}
