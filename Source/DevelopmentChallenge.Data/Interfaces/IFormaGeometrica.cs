using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Interfaces
{
    /// <summary>
    /// Contrato para las figuras indicando que deben implementar los métodos para calcular el área y perímetro.
    /// </summary>
    public interface IFormaGeometrica
    {
        TipoForma Tipo { get; }
        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}
