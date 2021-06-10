using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Interface
{
    public interface ICalculates
    {
        decimal CalcularArea(FormaGeometrica forma);
        decimal CalcularPerimetro(FormaGeometrica forma);
    }
}
