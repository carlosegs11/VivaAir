using System;

namespace BusinessLogic
{
    public class SaveReservation 
    {
        /// Principio SOLID # 5.  Dependency Inversion Principle. Esta clase desacopla el código.  Esta clase recibe una abstracción como parámetro.
        private ISave _save;
        public SaveReservation (ISave save)
        {
            _save = save;
        }

        public void Save(string departureStation, string arrivalStation, DateTime departureDate, string flightNumber, decimal price, string currency)
        {
            _save.SaveReservation(departureStation, arrivalStation, departureDate, flightNumber, price, currency);
        }
    }
}
