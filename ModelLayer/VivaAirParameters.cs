using System;

namespace ModelLayer
{
    /// <summary>
    /// Hereda de la Interfaz IParameters
    /// </summary>
    public class VivaAirParameters : IParameters
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime From { get; set; }
    }
}
