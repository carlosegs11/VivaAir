using ModelLayer;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FlightComponent2.Utilities
{
    /// <summary>
    /// Clase abstracta que no permite crear objetos a partir de ella.  Se utiliza para funcionalidades adicinales del aplicativo
    /// </summary>
    public abstract class FlightFun
    {
        public static List<SelectListItem> GetIataView (List<IIATA> iataList)
        {
            List<SelectListItem> iataListView = new List<SelectListItem>();

            foreach (var item in iataList)
            {
                SelectListItem iataItem = new SelectListItem();
                iataItem.Text = item.Name;
                iataItem.Value = item.Code;
                iataListView.Add(iataItem);
            }

            return iataListView;
        }

        public static List<FlightReservation> GetResponseView (List<FlightReservation> flightReservationList, string originName, string destinationName)
        {
            List<FlightReservation> flightReservationListView = new List<FlightReservation>();
            foreach (var item in flightReservationList)
            {
                FlightReservation flightReservation = new FlightReservation();
                flightReservation.Id = item.Id;
                flightReservation.ArrivalStation = item.ArrivalStation;
                flightReservation.ArrivalStationName = destinationName;
                flightReservation.DepartureStation = item.DepartureStation;
                flightReservation.DepartureStationName = originName;
                flightReservation.FlightNumber = item.FlightNumber;
                flightReservation.DepartureDate = item.DepartureDate;
                flightReservation.Price = item.Price;
                flightReservation.Currency = item.Currency;
                flightReservation.TransportType = transportType.Airplane;
                flightReservation.IdTransport = "HK-41-P";


                flightReservationListView.Add(flightReservation);
            }

            return flightReservationListView;
        }
    }
}