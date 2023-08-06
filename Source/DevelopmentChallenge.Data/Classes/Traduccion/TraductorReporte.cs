using DevelopmentChallenge.Data.Enums;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Clase para traducir los códigos de etiquetas del reporte en el idioma correspondiente
    /// </summary>
    public class TraductorReporte : Traductor<int, string>
    {
        /// <summary>
        /// Definición del diccionario para traducir las etiquetas del reporte
        /// </summary>
        public override IReadOnlyDictionary<int, IReadOnlyDictionary<Idioma, string>> Diccionario { get; } = new Dictionary<int, IReadOnlyDictionary<Idioma, string>>
        {
            {
                ReporteMensajes.Header, new Dictionary<Idioma, string>
                {
                    { Idioma.Castellano, "Reporte de Formas" },
                    { Idioma.Ingles, "Shapes Report" },
                    { Idioma.Portugues, "Relatório de Formas" },
                    { Idioma.Italiano, "Rapporto di Forme" }
                }
            },
            {
                ReporteMensajes.ListaVacia, new Dictionary<Idioma, string>
                {
                    { Idioma.Castellano, "Lista vacía de formas!" },
                    { Idioma.Ingles, "Empty list of shapes!" },
                    { Idioma.Portugues, "Lista vazia de formas!" },
                    { Idioma.Italiano, "Lista vuota di forme!" }
                }
            },
            {
                ReporteMensajes.Total, new Dictionary<Idioma, string>
                {
                    { Idioma.Castellano, "Total" },
                    { Idioma.Ingles, "Total" },
                    { Idioma.Portugues, "Total" },
                    { Idioma.Italiano, "Totale" }
                }
            },
            {
                ReporteMensajes.Formas, new Dictionary<Idioma, string>
                {
                    { Idioma.Castellano, "Formas" },
                    { Idioma.Ingles, "Shapes" },
                    { Idioma.Portugues, "Formas" },
                    { Idioma.Italiano, "Forme" }
                }
            },
            {
                ReporteMensajes.Perimetro, new Dictionary<Idioma, string>
                {
                    { Idioma.Castellano, "Perímetro" },
                    { Idioma.Ingles, "Perimeter" },
                    { Idioma.Portugues, "Perímetro" },
                    { Idioma.Italiano, "Perimetro" }
                }
            },
            {
                ReporteMensajes.Area, new Dictionary<Idioma, string>
                {
                    { Idioma.Castellano, "Área" },
                    { Idioma.Ingles, "Area" },
                    { Idioma.Portugues, "Área" },
                    { Idioma.Italiano, "Area" }
                }
            }   
        };
    }
}
