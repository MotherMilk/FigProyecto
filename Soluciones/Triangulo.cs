using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluciones
{
    public class Triangulo : CalculoBidimensionales
    {
        private double bass;
        private double Altura;


        public Triangulo(double bass, double Altura)
        {
            this.bass = bass;
            this.Altura = Altura;
        }
    }
}
