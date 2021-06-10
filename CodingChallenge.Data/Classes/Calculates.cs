using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Calculates : ICalculates
    {
        public decimal CalcularArea(FormaGeometrica forma)
        {
            switch (forma.Tipo)
            {
                case (int)Shapes.Cuadrado: 
                    return forma._lado * forma._lado;
                case (int)Shapes.Circulo: 
                    return (decimal)Math.PI * (forma._lado / 2) * (forma._lado / 2);
                case (int)Shapes.TrianguloEquilatero: 
                    return ((decimal)Math.Sqrt(3) / 4) * forma._lado * forma._lado;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }

        public decimal CalcularPerimetro(FormaGeometrica forma)
        {
            switch (forma.Tipo)
            {
                case (int)Shapes.Cuadrado:
                    return forma._lado * 4;
                case (int)Shapes.Circulo:
                    return (decimal)Math.PI * forma._lado;
                case (int)Shapes.TrianguloEquilatero:
                    return forma._lado * 3;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }
    }
}
