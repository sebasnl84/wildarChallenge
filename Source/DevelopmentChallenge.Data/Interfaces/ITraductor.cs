using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Interfaces
{
    /// <summary>
    /// Contrato para la implementación de traductores
    /// </summary>
    /// <typeparam name="E">Elemento</typeparam>    
    /// <typeparam name="I">Idioma</typeparam>
    /// <typeparam name="T">Texto</typeparam>
    public interface ITraductor<E, I, T>
    {
        IReadOnlyDictionary<E, IReadOnlyDictionary<I, T>> Diccionario { get; }
        T Traducir(E elemento, I idioma);
    }
}
