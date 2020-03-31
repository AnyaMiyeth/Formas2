using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2
{
    class Cuadrado : Figura
    {
        public double Lado { get; set; }
        public double Area { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }
        public override double CalcularArea()
        {
             
            return Lado * Lado;
        }

        public override string ToString()
        {
            
            return ($"El area del Cuadrado es{CalcularArea()}");
        }

    }
}
