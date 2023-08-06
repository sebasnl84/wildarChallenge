using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Clase que ofrece la estructura base para las figuras geométricas del tipo polígono
    /// </summary>
    public abstract class Poligono : FormaGeometrica, IPoligono
    {
        public virtual decimal Base { get; protected set; }
        public virtual decimal Altura { get; protected set; }
    }
}
