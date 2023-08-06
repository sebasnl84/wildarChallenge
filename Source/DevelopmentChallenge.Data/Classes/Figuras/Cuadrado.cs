using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado: Poligono
    {
        public override TipoForma Tipo { get; } = TipoForma.Cuadrado;

        public Cuadrado(decimal lado)
        {
            if (lado <= decimal.Zero)
                throw new ArgumentException("No se admite valores menores o iguales a cero.");

            Base = lado;
            Altura = lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Base * 4;
        }

        public override decimal CalcularArea()
        {
            return (Base * Altura);
        }
    }
}
