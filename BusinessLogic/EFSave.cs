using DataLayerEF2;
using System;

namespace BusinessLogic
{
    /// <summary>
    /// Principio SOLID # 1.  Principio de responsabilidad única
    /// </summary>
    public class EFSave : ISave
    {
        public void SaveReservation(string departureStation, string arrivalStation, DateTime departureDate, string flightNumber, decimal price, string currency)
        {
            using (ReservationEntities db = new ReservationEntities())
            {
                Reservation flightReservation = new Reservation
                {
                    DepartureStation = departureStation,
                    ArrivalStation = arrivalStation,
                    DepartureDate = departureDate,
                    Number = flightNumber,
                    Price = price,
                    Currency = currency
                };
                db.Reservation.Add(flightReservation);
                db.SaveChanges();
            }
        }
    }
}
