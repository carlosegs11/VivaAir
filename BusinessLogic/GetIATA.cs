using ModelLayer;
using System.Collections.Generic;

namespace BusinessLogic
{
    /// <summary>
    /// Principio SOLID # 5.  Dependency Inversion Principle. Esta clase desacopla el código.  Esta clase recibe una abstracción como parámetro.
    /// </summary>
    public class GetIATA
    {
        private IGet _get;
        public GetIATA(IGet get)
        {
            _get = get;
        }

        public List<IIATA> Get()
        {
            return _get.GetIATA();
        }
    }
}
