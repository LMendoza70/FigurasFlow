using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasFlow
{
    internal class Clsrectangulo : Clsfiguras
    {
        public double ladoMayor { get; set; }
        public double ladoMenor { get; set; }
        public override double CalcularArea()
        {
            return ladoMayor * ladoMenor;
        }

        public override double CalcularPerimetro()
        {
           return 2 * (ladoMayor + ladoMenor);
        }
    }
}
