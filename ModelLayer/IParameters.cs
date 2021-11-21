using System;


namespace ModelLayer
{
    /// <summary>
    /// Contrato que deben respetar todas las clases que hereden de esta interfaz
    /// </summary>
    public interface IParameters
    {
        string Origin { get; set; }
        string Destination { get; set; }
        DateTime From { get; set; }
    }
}
