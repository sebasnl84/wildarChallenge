using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : Poligono
    {
        public override TipoForma Tipo { get; } = TipoForma.Rectangulo;

        public Rectangulo(decimal @base, decimal altura)
        {
            if (@base <= decimal.Zero || altura <= decimal.Zero)
                throw new ArgumentException("No se admite valores menores o iguales a cero.");

            if (@base.Equals(altura))
                throw new ArgumentException("Los lados no pueden ser iguales en un rectángulo.");

            Base = @base;
            Altura = altura;
        }

        public override decimal CalcularPerimetro()
        {
            return (Base * 2) + (Altura * 2);
        }

        public override decimal CalcularArea()
        {
            return (Base * Altura);
        }
    }
}
