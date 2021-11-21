﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Principio SOLID # 4.  Interface Segregation Principle.  La interfaz solo obliga a implementar los métodos que realmente van a utilizar los objetos.
    /// </summary>
    public interface ISave
    {
        void SaveReservation(string departureStation, string arrivalStation, DateTime departureDate, string flightNumber, decimal price, string currency);
    }
}
