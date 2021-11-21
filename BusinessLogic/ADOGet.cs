using DataLayer;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLogic
{
    /// <summary>
    /// Principio SOLID # 1.  Principio de responsabilidad única
    /// </summary>
    public class ADOGet : IGet
    {
        public List<IIATA> GetIATA()
        {
            List<IIATA> iataList = DL_IATA.Instance.GetIATA();
            return iataList;
        }
    }
}
