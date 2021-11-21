using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    public interface IWebApi
    {
        List<FlightReservation> getApiRequest(IParameters parameters, string urlService);
    }
}
