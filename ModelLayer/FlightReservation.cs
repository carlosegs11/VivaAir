using BusinessLogic;
using System;

namespace ModelLayer
{
    /// <summary>
    /// Herencia múltiple que en c# solo se permite a través de las Interfaces
    /// </summary>
    public class FlightReservation : IReservation, ITransport
    {


        # region Propiedades de la interfaz IReservation
        public string Id { get; set; }
        public string ReservationNumber { get; set; }
        public string DepartureStation { get; set; }
        public string DepartureStationName { get; set; }
        public string ArrivalStation { get; set; }
        public string ArrivalStationName { get; set; }
        public DateTime DepartureDate { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        #endregion

        #region Propiedades de la interfaz ITransport
        public string IdTransport { get; set; }
        public transportType TransportType  { get; set; }
  
        #endregion

        #region Propiedades propias de la clase FlightReservation
        public string FlightNumber { get; set; }
        #endregion

        /// <summary>
        /// Polimorfismo -> Se sobre escribe el método y se le brinda una funcionalidad diferente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Id},{ReservationNumber},{DepartureStation}, {DepartureStationName},{ArrivalStation}, {ArrivalStationName},{DepartureDate},{Price},{Currency}";
        }
    }
}
