using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : Poligono
    {
        public override TipoForma Tipo { get; } = TipoForma.Trapecio;
        public decimal CatetoIzquierdo { get; protected set; }
        public decimal CatetoDerecho { get; protected set; }
        public decimal BaseSuperior { get; protected set; }

        public Trapecio(decimal baseSuperior, decimal baseInferior, decimal altura, decimal catetoIzquierdo, decimal catetoDerecho)
        {
            if (baseSuperior <= decimal.Zero || baseInferior <= decimal.Zero || altura <= decimal.Zero || catetoIzquierdo <= decimal.Zero || catetoDerecho <= decimal.Zero)
                throw new ArgumentException("No se admite valores menores o iguales a cero.");

            if (baseSuperior.Equals(baseInferior) && baseInferior.Equals(catetoIzquierdo) && catetoIzquierdo.Equals(catetoDerecho))
                throw new ArgumentException("Los lados no pueden ser iguales en un trapecio.");

            BaseSuperior = baseSuperior;
            Base = baseInferior;
            Altura = altura;
            CatetoIzquierdo = catetoIzquierdo;
            CatetoDerecho = catetoDerecho;
        }

        public override decimal CalcularArea()
        {
            return (Base + BaseSuperior) * Altura / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return Base + BaseSuperior + CatetoDerecho + CatetoIzquierdo;
        }
    }
}
