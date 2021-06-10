using CodingChallenge.Data.Classes.Entities;
using CodingChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Interface
{
    interface IReportGenerated
    {
        void SpanishReport(StringBuilder sb, Cuadrado cuadrado, Circulo circulo, TrianguloEquilatero triangulo, Languages language);
        void EnglishReport(StringBuilder sb, Cuadrado cuadrado, Circulo circulo, TrianguloEquilatero triangulo, Languages language);
    }
}
