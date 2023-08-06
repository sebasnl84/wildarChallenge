using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Exceptions;
using DevelopmentChallenge.Data.Interfaces;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Clase que ofrece la estructura base para la traducción de elementos
    /// </summary>
    /// <typeparam name="E">Elemento a traducir</typeparam>
    /// <typeparam name="T">Resultado de la traducción</typeparam>
    public abstract class Traductor<E, T> : ITraductor<E, Idioma, T>
    {
        public abstract IReadOnlyDictionary<E, IReadOnlyDictionary<Idioma, T>> Diccionario { get; }

        public T Traducir(E elemento, Idioma idioma)
        {
            try
            {
                return Diccionario[elemento][idioma];
            }
            catch (System.Exception ex)
            {
                throw new TraduccionException("No se pudo obtener la traducción para el elemento e idioma establecido", ex);
            }            
        }
    }
}
