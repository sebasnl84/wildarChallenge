using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : Circunferencia
    {
        public override TipoForma Tipo { get; } = TipoForma.Circulo;

        public Circulo(decimal diametro)
        {
            if (diametro <= decimal.Zero)
                throw new ArgumentException("No se admite valores menores o iguales a cero.");

            Diametro = diametro;
        }

        public override decimal CalcularPerimetro()
        {
            return PI * Diametro;
        }

        public override decimal CalcularArea()
        {
            return PI * (decimal)Math.Pow((double)Radio, 2);
        }
    }
}
