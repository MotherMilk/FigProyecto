using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluciones
{
    public class Tetraedro : CalculoTridimensionales
    {
        private double lado;
        public Tetraedro(double lado) 
        {
            this.lado = lado;
        }
    }
}
