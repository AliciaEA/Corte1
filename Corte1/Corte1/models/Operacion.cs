using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Operacion
    {
        public int Edad;

        public Operacion(int edad)
        {
            this.Edad = edad;
        }

        public string MayorEdad()
        {
            if (Edad >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }
    }
}
