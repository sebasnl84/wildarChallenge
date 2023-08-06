using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Exceptions;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Reporte.Imprimir(new List<IFormaGeometrica>(), Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Reporte.Imprimir(new List<IFormaGeometrica>(), Idioma.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

            var resumen = Reporte.Imprimir(cuadrados, Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Área 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = Reporte.Imprimir(cuadrados, Idioma.Ingles);

            Assert.AreEqual("<h1>Shapes Report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Reporte.Imprimir(formas, Idioma.Ingles);

            Assert.AreEqual(
                "<h1>Shapes Report</h1>2 Squares | Area 29 | Perimeter 28 <br/>3 Equilateral Triangles | Area 49,64 | Perimeter 51,6 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Reporte.Imprimir(formas, Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>3 Triángulos Equiláteros | Área 49,64 | Perímetro 51,6 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>TOTAL:<br/>7 formas Perímetro 97,66 Área 91,65",
                resumen);
        }

        [TestCase]        
        public void TestResumenListaConMasTiposIdiomaDesconocido()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            Assert.Throws<TraduccionException>(() => Reporte.Imprimir(formas, 0));
        }

        [TestCase]
        public void TestResumenListaConDosTrapecios()
        {
            var figuras = new List<IFormaGeometrica>
            {
                new Trapecio(5, 2, 3, 5, 6),
                new Trapecio(5, 2, 3, 5, 7)
            };

            var resumen = Reporte.Imprimir(figuras, Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Trapecios | Área 21 | Perímetro 37 <br/>TOTAL:<br/>2 formas Perímetro 37 Área 21", resumen);
        }

        [TestCase]
        public void TestFigurasConValoresCero()
        {
            Assert.Throws<ArgumentException>(() => new Cuadrado(0));
            Assert.Throws<ArgumentException>(() => new Rectangulo(5, 0));
            Assert.Throws<ArgumentException>(() => new Circulo(0));
            Assert.Throws<ArgumentException>(() => new TrianguloEquilatero(0));
            Assert.Throws<ArgumentException>(() => new Trapecio(10, 0, 30, 25, 0));
        }

        [TestCase]
        public void TestCuadradoLadosIguales()
        {
            var figura = new Cuadrado(5);
            Assert.AreEqual(figura.Altura, figura.Base);
        }

        [TestCase]
        public void TestRectanguloTraduccionPluralSingular()
        {
            var figura = new Rectangulo(5, 2);
            var traduccion = figura.Traducir(Idioma.Castellano);

            Assert.AreEqual("Rectángulo", traduccion.Singular);
            Assert.AreEqual("Rectángulos", traduccion.Plural);
        }

        [TestCase]
        public void TestFigurasTipos()
        {
            Assert.AreEqual(new Cuadrado(5).Tipo, TipoForma.Cuadrado);
            Assert.AreEqual(new Rectangulo(5, 2).Tipo, TipoForma.Rectangulo);
            Assert.AreEqual(new Circulo(10).Tipo, TipoForma.Circulo);
            Assert.AreEqual(new TrianguloEquilatero(10).Tipo, TipoForma.TrianguloEquilatero);
            Assert.AreEqual(new Trapecio(10, 15, 30, 25, 10).Tipo, TipoForma.Trapecio);
        }

        [TestCase]
        public void TestRectanguloConValoresDeCuadrado()
        {
            Assert.Throws<ArgumentException>(() => new Rectangulo(5, 5));
        }

        [TestCase]
        public void TestTrapecioConLadosIguales()
        {
            Assert.Throws<ArgumentException>(() => new Trapecio(5, 5, 5, 5, 5));
        }

        [TestCase]
        public void TestVerificacionInicializacionPropiedadesCuadrado()
        {
            const decimal valorTest = 10;
            var figura = new Cuadrado(valorTest);

            Assert.AreEqual(valorTest, figura.Altura);
            Assert.AreEqual(valorTest, figura.Base);
        }

        [TestCase]
        public void TestVerificacionInicializacionPropiedadesRectangulo()
        {
            const decimal testBase = 10;
            const decimal testAltura = 20;
            var figura = new Rectangulo(testBase, testAltura);

            Assert.AreEqual(testAltura, figura.Altura);
            Assert.AreEqual(testBase, figura.Base);
        }

        [TestCase]
        public void TestVerificacionInicializacionPropiedadesTrianguloEquilatero()
        {
            const decimal valorTest = 10;
            var figura = new TrianguloEquilatero(valorTest);

            Assert.AreEqual(valorTest, figura.Base);
        }

        [TestCase]
        public void TestVerificacionCalculoAlturaTrianguloEquilaterio()
        {
            const decimal baseTest = 10;
            decimal alturaTest = (decimal)Math.Sqrt(3) * baseTest / 2;
            var figura = new TrianguloEquilatero(baseTest);

            Assert.AreEqual(alturaTest, figura.Altura);
        }

        [TestCase]
        public void TestVerificacionInicializacionPropiedadesCirculo()
        {
            const decimal valorTest = 10;
            var figura = new Circulo(valorTest);

            Assert.AreEqual(valorTest, figura.Diametro);
        }

        [TestCase]
        public void TestVerificacionCalculoRadioCirculo()
        {
            const decimal valorTest = 10 / 2;
            const decimal radio = valorTest / 2;
            var figura = new Circulo(valorTest);

            Assert.AreEqual(radio, figura.Radio);
        }

        [TestCase]
        public void TestVerificacionInicializacionPropiedadesTrapecio()
        {
            const decimal baseTest = 10;
            const decimal baseSuperiorTest = 15;
            const decimal alturaTest = 30;
            const decimal catetoIzquierdoTest = 25;
            const decimal catetoDerechoTest = 10;

            var figura = new Trapecio(baseSuperiorTest, baseTest, alturaTest, catetoIzquierdoTest, catetoDerechoTest);

            Assert.AreEqual(baseTest, figura.Base);
            Assert.AreEqual(baseSuperiorTest, figura.BaseSuperior);
            Assert.AreEqual(alturaTest, figura.Altura);
            Assert.AreEqual(catetoIzquierdoTest, figura.CatetoIzquierdo);
            Assert.AreEqual(catetoDerechoTest, figura.CatetoDerecho);
        }
    }
}
