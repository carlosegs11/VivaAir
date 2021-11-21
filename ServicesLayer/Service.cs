using ModelLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ServicesLayer
{
    public class Service
    {
        private IWebApi _webApi;
        public Service(IWebApi webApi)
        {
            _webApi = webApi;
        }

        public List<FlightReservation> GetApi(IParameters parameters, string urlService)
        {
            return _webApi.getApiRequest(parameters, urlService);
        }
    }
}
