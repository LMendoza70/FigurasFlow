using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasFlow
{
    internal class Cuadrado : Clsfiguras

    {
        public double lado {  get; set; }
         

        public override double CalcularArea()
        {
            return lado * lado;

        }

        public override double CalcularPerimetro()
        {
            return lado * 4;
        }
    }
}
