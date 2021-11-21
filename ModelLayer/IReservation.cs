using System;

namespace ModelLayer
{
    /// <summary>
    /// Contrato que deben respetar todas las clases que hereden de esta interfaz
    /// </summary>
    public interface IReservation
    {
        string Id { get; set; }
        string ReservationNumber { get; set; }
        string DepartureStation { get; set; }
        string DepartureStationName { get; set; }
        string ArrivalStation { get; set; }
        string ArrivalStationName { get; set; }
        DateTime DepartureDate { get; set; }
        decimal Price { get; set; }
        string Currency { get; set; }
    }
}
