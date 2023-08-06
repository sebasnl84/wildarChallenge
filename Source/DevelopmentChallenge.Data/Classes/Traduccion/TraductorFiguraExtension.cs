using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Clase que extiende a Figuras que permite traducir las figuras de forma directa
    /// </summary>
    public static class TraductorFiguraExtension
    {
        private static readonly TraductorFigura TraductorFigura = new TraductorFigura();
        public static Traduccion Traducir(this IFormaGeometrica figura, Idioma idioma)
        {
            return TraductorFigura.Traducir(figura, idioma);
        }
    }
}
