using System;

namespace DevelopmentChallenge.Data.Exceptions
{
    /// <summary>
    /// Excepción personalizada para el tratamiento de errores en el proceso de traducción.
    /// </summary>
    public class TraduccionException : Exception
    {
        public TraduccionException(string message) : base(message)
        { }

        public TraduccionException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
