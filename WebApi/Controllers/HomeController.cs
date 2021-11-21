using ModelLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;



namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        public async ActionResult Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://testapi.vivaair.com/otatest/api/values");
            var flightReservationList = JsonConvert.DeserializeObject<List<FlightReservation>>(json);

            return View(flightReservationList);
        }
    }
}
