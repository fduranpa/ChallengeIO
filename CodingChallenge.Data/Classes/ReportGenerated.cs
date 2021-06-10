using CodingChallenge.Data.Classes.Entities;
using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ReportGenerated : IReportGenerated
    {
        public void EnglishReport(StringBuilder sb, Cuadrado cuadrado, Circulo circulo, TrianguloEquilatero triangulo, Languages language)
        {
            sb.Append("<h1>Shapes report</h1>");
            sb.Append(ObtenerLinea(cuadrado.numeroCuadrados, cuadrado.areaCuadrados, cuadrado.perimetroCuadrados, (int)Shapes.Cuadrado, (int)language));
            sb.Append(ObtenerLinea(circulo.numeroCirculos, circulo.areaCirculos, circulo.perimetroCirculos, (int)Shapes.Circulo, (int)language));
            sb.Append(ObtenerLinea(triangulo.numeroTriangulos, triangulo.areaTriangulos, triangulo.perimetroTriangulos, (int)Shapes.TrianguloEquilatero, (int)language));

            // FOOTER
            sb.Append("TOTAL:<br/>");
            sb.Append(cuadrado.numeroCuadrados + circulo.numeroCirculos + triangulo.numeroTriangulos + " " + "shapes" + " ");
            sb.Append("Perimeter " + (cuadrado.perimetroCuadrados + triangulo.perimetroTriangulos + circulo.perimetroCirculos).ToString("#.##") + " ");
            sb.Append("Area " + (cuadrado.areaCuadrados + circulo.areaCirculos + triangulo.areaTriangulos).ToString("#.##"));
        }

        public void SpanishReport(StringBuilder sb, Cuadrado cuadrado, Circulo circulo, TrianguloEquilatero triangulo, Languages language)
        {
            sb.Append("<h1>Reporte de Formas</h1>");
            sb.Append(ObtenerLinea(cuadrado.numeroCuadrados, cuadrado.areaCuadrados, cuadrado.perimetroCuadrados, (int)Shapes.Cuadrado, (int)language));
            sb.Append(ObtenerLinea(circulo.numeroCirculos, circulo.areaCirculos, circulo.perimetroCirculos, (int)Shapes.Circulo, (int)language));
            sb.Append(ObtenerLinea(triangulo.numeroTriangulos, triangulo.areaTriangulos, triangulo.perimetroTriangulos, (int)Shapes.TrianguloEquilatero, (int)language));

            // FOOTER
            sb.Append("TOTAL:<br/>");
            sb.Append(cuadrado.numeroCuadrados + circulo.numeroCirculos + triangulo.numeroTriangulos + " " + "formas" + " ");
            sb.Append("Perimetro " + (cuadrado.perimetroCuadrados + triangulo.perimetroTriangulos + circulo.perimetroCirculos).ToString("#.##") + " ");
            sb.Append("Area " + (cuadrado.areaCuadrados + circulo.areaCirculos + triangulo.areaTriangulos).ToString("#.##"));
        }

        public static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma)
        {
            if (cantidad > 0)
            {
                switch (idioma)
                {
                    case (int)Languages.Castellano:
                        return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                    case (int)Languages.Ingles:
                        return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
                    default:
                        break;
                }
            }

            return string.Empty;
        }

        public static string TraducirForma(int tipo, int cantidad, int idioma)
        {
            switch (tipo)
            {
                case (int)Shapes.Cuadrado:
                    if (idioma == (int)Languages.Castellano) return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    else return cantidad == 1 ? "Square" : "Squares";

                case (int)Shapes.Circulo:
                    if (idioma == (int)Languages.Castellano) return cantidad == 1 ? "Círculo" : "Círculos";
                    else return cantidad == 1 ? "Circle" : "Circles";

                case (int)Shapes.TrianguloEquilatero:
                    if (idioma == (int)Languages.Castellano) return cantidad == 1 ? "Triángulo" : "Triángulos";
                    else return cantidad == 1 ? "Triangle" : "Triangles";

                default: return null;
            }
        }
    }
}
