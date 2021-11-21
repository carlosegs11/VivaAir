namespace ModelLayer
{
    /// <summary>
    /// Contrato que deben respetar todas las clases que hereden de esta interfaz
    /// </summary>
    public interface IIATA
    {
        string Code { get; set; }
        string Name { get; set; }
    }
}
