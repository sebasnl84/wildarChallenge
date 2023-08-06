using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : Poligono
    {
        public override TipoForma Tipo { get; } = TipoForma.TrianguloEquilatero;
        
        //La altura de un triángulo equilátero se obtiene aplicando el teorema de Pitágoras.
        public override decimal Altura { get { return (decimal)Math.Sqrt(3) * Base / 2; } }

        public TrianguloEquilatero(decimal lado)
        {
            if (lado <= decimal.Zero)
                throw new ArgumentException("No se admite valores menores o iguales a cero.");

            Base = lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Base * 3;
        }

        public override decimal CalcularArea()
        {
            return Base * Altura / 2;
        }
    }
}
