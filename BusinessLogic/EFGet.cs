using ModelLayer;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    /// <summary>
    /// Principio SOLID # 1.  Principio de responsabilidad única
    /// </summary>
    public class EFGet : IGet
    {
        public List<IIATA> GetIATA()
        {
            // Se debería implementar el método obtener codigos IATA utilizando Entity Framework
            throw new NotImplementedException();
        }
    }
}
