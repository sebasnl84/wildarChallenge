/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * OPCIONAL: Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// La clase se refactorizó y se convirtió en una clase abstracta para establecer un árbol de herencia. 
    /// Su antiguo comportamiento fue delegado a las nuevas clases correspondientes.
    /// </summary>
    public abstract class FormaGeometrica: IFormaGeometrica
    {
        public abstract TipoForma Tipo { get; }

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();
    }
}
