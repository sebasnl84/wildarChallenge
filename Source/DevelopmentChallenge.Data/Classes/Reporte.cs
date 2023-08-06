using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Clase encargada de generar el reporte.
    /// Admite una lista de cualquier tipo que implemente la interfaz IFormaGeometrica.
    /// Delega la responsabilidad de traducir a la clase que implementa la interfaz ITraductor.
    /// </summary>
    public static class Reporte
    {
        private static Traductor<int, string> _traductorReporte = new TraductorReporte();

        private static string GetTraduccion(int msjId, Idioma idioma)
        {
            return _traductorReporte.Traducir(msjId, idioma);
        }

        public static string Imprimir(List<IFormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{GetTraduccion(ReporteMensajes.ListaVacia, idioma)}</h1>");
                return sb.ToString();
            }

            sb.Append($"<h1>{GetTraduccion(ReporteMensajes.Header, idioma)}</h1>");

            foreach (var tipo in Enum.GetValues(typeof(TipoForma)))
            {
                var resultado = formas.Where(f => f.Tipo == (TipoForma)tipo).ToList();

                if (resultado.Any())
                {
                    var cantidad = resultado.Count;
                    var area = resultado.Sum(f => f.CalcularArea());
                    var perimetro = resultado.Sum(f => f.CalcularPerimetro());

                    var texto = resultado.First().Traducir(idioma);

                    sb.Append($"{cantidad} {(cantidad == 1 ? texto?.Singular : texto?.Plural)} | {GetTraduccion(ReporteMensajes.Area, idioma)} {area:#.##} | {GetTraduccion(ReporteMensajes.Perimetro, idioma)} {perimetro:#.##} <br/>");
                }
            }

            // FOOTER
            sb.Append($"{GetTraduccion(ReporteMensajes.Total, idioma).ToUpperInvariant()}:<br/>");
            sb.Append($"{formas.Count} {GetTraduccion(ReporteMensajes.Formas, idioma).ToLowerInvariant()} ");
            sb.Append($"{GetTraduccion(ReporteMensajes.Perimetro, idioma)} {formas.Sum(f => f.CalcularPerimetro()):#.##} ");
            sb.Append($"{GetTraduccion(ReporteMensajes.Area, idioma)} {formas.Sum(f => f.CalcularArea()):#.##}");

            return sb.ToString();
        }
    }
}
