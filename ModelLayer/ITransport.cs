using ModelLayer;
using System.Net;

namespace BusinessLogic
{
    /// <summary>
    /// Contrato que deben respetar todas las clases que hereden de esta interfaz
    /// </summary>
    public interface ITransport
    {
        string IdTransport { get; set; }
        transportType TransportType { get; set; }
    }
}
