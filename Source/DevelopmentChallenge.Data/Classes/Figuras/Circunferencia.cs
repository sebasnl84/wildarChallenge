using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Clase que ofrece la estructura base para las figuras geométricas del tipo circunferencia
    /// </summary>
    public abstract class Circunferencia: FormaGeometrica, ICircunferencia
    {
        public decimal PI { get; } = (decimal)Math.PI;
        public virtual decimal Diametro { get; protected set; }

        public decimal Radio
        {
            get
            {
                return Diametro / 2;
            }
        }
    }
}
