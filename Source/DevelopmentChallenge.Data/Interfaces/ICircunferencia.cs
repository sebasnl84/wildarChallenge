namespace DevelopmentChallenge.Data.Interfaces
{
    /// <summary>
    /// Contrato para la implementación de circunferencias
    /// </summary>
    public interface ICircunferencia: IFormaGeometrica
    {
        decimal Diametro { get; }
    }
}
