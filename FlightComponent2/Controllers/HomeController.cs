using BusinessLogic;
using DataLayer;
using FlightComponent2.Utilities;
using ModelLayer;
using ServicesLayer;
using System;
using System.Collections.Generic;
using System.Web.Mvc;


namespace FlightComponent2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Manejo de Excepciones
            try
            {
                // Inyección de dependencias (Se esta utilizando la clase ADO .net para guardar pero se prodría cambiar en cualquier momomento por la clase EntityFramework)
                var provider = new ADOGet();
                var getIATA = new GetIATA(provider);
                List<IIATA> iataList = getIATA.Get();
                ViewBag.iataList = FlightFun.GetIataView(iataList);
                return View();
            }
            catch (Exception ex) 
            { 
                // Logging personalizado
                CustomLog log = new CustomLog(@"C:\Applog\");
                log.Add(ex.ToString());
                ViewBag.MessageInfo = "An error occurred please contact the administrator";
                return View("~/Views/Shared/Error.cshtml"); 
            }
        }

        [HttpPost]
        public ActionResult AvailableFlights(string originCode, string originName, string destinationCode, string destinationName, DateTime arrivaldate)
        {
            // Manejo de Excepciones
            try
            {
                IParameters parameters = new VivaAirParameters() { Origin = originCode, Destination = destinationCode, From = arrivaldate };

                // Inyección de dependencias (Se esta utilizando la WebApi de VivaAir, pero se poodría cambiar en cualquier momento por  la de Avianca o cualquier otro proveedor)
                var provider = new VivaAirApi();
                var service = new Service(provider);
                List<FlightReservation> flightReservationList = service.GetApi(parameters, DL_Connection.Service);

                if (flightReservationList.Count.Equals(0))
                {
                    ViewBag.MessageInfo = "There aren't flights for the chosen options... try again please";
                    return View("~/Views/Shared/Error.cshtml");
                }

                return PartialView(FlightFun.GetResponseView(flightReservationList, originName, destinationName));
            }
            catch (Exception ex)
            {
                // Logging personalizado
                CustomLog log = new CustomLog(@"C:\Applog\");
                log.Add(ex.ToString());
                ViewBag.MessageInfo = "An error occurred please contact the administrator";
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        public ActionResult SaveReservation(string departureStation, string arrivalStation, DateTime departureDate, string flightNumber, decimal price, string currency)
        {
            // Manejo de Excepciones
            try
            {
                // Inyección de dependencias (Se esta utilizando la clase EntityFramework para guardar pero se prodría cambiar en cualquier momomento por la clase ADO .net)
                var provider = new EFSave();
                var saveReservation = new SaveReservation(provider);
                saveReservation.Save(departureStation, arrivalStation, departureDate, flightNumber, price, currency);
                ViewBag.MessageInfo = "Successfully booked flight";
                return View();
            }
            catch (Exception ex)
            {
                // Logging personalizado
                CustomLog log = new CustomLog(@"C:\Applog\");
                log.Add(ex.ToString());
                ViewBag.MessageInfo = "An error occurred please contact the administrator";
                return View("~/Views/Shared/Error.cshtml");
            }
        }
    }
}