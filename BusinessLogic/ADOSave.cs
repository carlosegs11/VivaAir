using System;

namespace BusinessLogic
{
    /// <summary>
    /// Principio SOLID # 1.  Principio de responsabilidad única
    /// </summary>
    public class ADOSave : ISave
    {
        public void SaveReservation(string departureStation, string arrivalStation, DateTime departureDate, string flightNumber, decimal price, string currency)
        {
            // Se debería implementar el método guardar utilizando la librería de clases de ADO .Net
        }
    }
}
