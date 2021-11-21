using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    public class AviancaApi : IWebApi
    {
        public List<FlightReservation> getApiRequest(IParameters parameters, string urlService)
        {
            // Se debería implementar el llamado a la WebApi de Avianca
            throw new NotImplementedException();
        }
    }
}
