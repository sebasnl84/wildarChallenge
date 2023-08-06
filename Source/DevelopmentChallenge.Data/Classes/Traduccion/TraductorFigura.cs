using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Clase para traducir el nombre de una figura
    /// </summary>
    public class TraductorFigura: Traductor<TipoForma, Traduccion>
    {
        /// <summary>
        /// Definición del diccionario para traducir el nombre de las figuras
        /// </summary>
        public override IReadOnlyDictionary<TipoForma, IReadOnlyDictionary<Idioma, Traduccion>> Diccionario { get; } = new Dictionary<TipoForma, IReadOnlyDictionary<Idioma, Traduccion>>
        {
            { 
                TipoForma.Circulo, new Dictionary<Idioma, Traduccion>
                {
                    { Idioma.Castellano, new Traduccion { Singular = "Círculo", Plural = "Círculos" } },
                    { Idioma.Ingles, new Traduccion { Singular = "Circle", Plural = "Circles" } },
                    { Idioma.Portugues, new Traduccion { Singular = "Círculo", Plural = "Círculos" } },
                    { Idioma.Italiano, new Traduccion { Singular = "Cerchio", Plural = "Cerchi" } }
                }
            },
            { 
                TipoForma.Cuadrado, new Dictionary<Idioma, Traduccion>
                {
                    { Idioma.Castellano, new Traduccion { Singular = "Cuadrado", Plural = "Cuadrados" } },
                    { Idioma.Ingles, new Traduccion { Singular = "Square", Plural = "Squares" } },
                    { Idioma.Portugues, new Traduccion { Singular = "Quadrado", Plural = "Quadrados" } },
                    { Idioma.Italiano, new Traduccion { Singular = "Quadrato", Plural = "Quadrati" } }
                }
            },
            { 
                TipoForma.Rectangulo, new Dictionary<Idioma, Traduccion>
                {
                    { Idioma.Castellano, new Traduccion { Singular = "Rectángulo", Plural = "Rectángulos" } },
                    { Idioma.Ingles, new Traduccion { Singular = "Rectangle", Plural = "Rectangles" } },
                    { Idioma.Portugues, new Traduccion { Singular = "Retângulo", Plural = "Retângulos" } },
                    { Idioma.Italiano, new Traduccion { Singular = "Rettangolo", Plural = "Rettangoli" } }
                }
            },
            {
                TipoForma.TrianguloEquilatero, new Dictionary<Idioma, Traduccion>
                {
                    { Idioma.Castellano, new Traduccion { Singular = "Triángulo Equilátero", Plural = "Triángulos Equiláteros" } },
                    { Idioma.Ingles, new Traduccion { Singular = "Equilateral Triangle", Plural = "Equilateral Triangles" } },
                    { Idioma.Portugues, new Traduccion { Singular = "Triângulo Equilátero", Plural = "Triângulos Equiláteros" } },
                    { Idioma.Italiano, new Traduccion { Singular = "Triangolo Equilatero", Plural = "Triangoli Equilateri" } }
                }
            },
            {
                TipoForma.Trapecio, new Dictionary<Idioma, Traduccion>
                {
                    { Idioma.Castellano, new Traduccion { Singular = "Trapecio", Plural = "Trapecios" } },
                    { Idioma.Ingles, new Traduccion { Singular = "Trapezoid", Plural = "Trapezoids" } },
                    { Idioma.Portugues, new Traduccion { Singular = "Trapézio", Plural = "Trapézios" } },
                    { Idioma.Italiano, new Traduccion { Singular = "Trapezio", Plural = "Trapezi" } }
                }
            }
        };

        /// <summary>
        /// Método de extensión para traducir el nombre de una figura
        /// </summary>
        /// <param name="figura">Tipo de figura</param>
        /// <param name="idioma">Idioma para la traducción</param>
        /// <returns></returns>
        public Traduccion Traducir(IFormaGeometrica figura, Idioma idioma)
        {
            return Traducir(figura.Tipo, idioma);
        }
    }
}
