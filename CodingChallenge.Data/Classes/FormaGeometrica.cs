/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public readonly decimal _lado;

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }

        public static string Imprimir(List<FormaGeometrica> formas, Languages language)
        {
            var sb = new StringBuilder();
            var report = new ReportGenerated();

            if (!formas.Any())
            {
                switch (language)
                {
                    case Languages.Castellano:
                        sb.Append("<h1>Lista vacía de formas!</h1>");
                        break;
                    case Languages.Ingles:
                        sb.Append("<h1>Empty list of shapes!</h1>");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Cuadrado cuadrado = new Cuadrado();
                Circulo circulo = new Circulo();
                TrianguloEquilatero triangulo = new TrianguloEquilatero();

                for (var i = 0; i < formas.Count; i++)
                {
                    var calculate = new Calculates();
                    switch (formas[i].Tipo)
                    {
                        case (int)Shapes.Cuadrado:
                            cuadrado.numeroCuadrados++;
                            cuadrado.areaCuadrados += calculate.CalcularArea(formas[i]);
                            cuadrado.perimetroCuadrados += calculate.CalcularPerimetro(formas[i]);
                            break;
                        case (int)Shapes.Circulo:
                            circulo.numeroCirculos++;
                            circulo.areaCirculos += calculate.CalcularArea(formas[i]);
                            circulo.perimetroCirculos += calculate.CalcularPerimetro(formas[i]);
                            break;
                        case (int)Shapes.TrianguloEquilatero:
                            triangulo.numeroTriangulos++;
                            triangulo.areaTriangulos += calculate.CalcularArea(formas[i]);
                            triangulo.perimetroTriangulos += calculate.CalcularPerimetro(formas[i]);
                            break;
                    }
                }

                switch (language)
                {
                    case Languages.Castellano:
                        report.SpanishReport(sb, cuadrado, circulo, triangulo, language);
                        break;

                    case Languages.Ingles:
                        report.EnglishReport(sb, cuadrado, circulo, triangulo, language);
                        break;
                }

            }

            return sb.ToString();
        }

    }
}
