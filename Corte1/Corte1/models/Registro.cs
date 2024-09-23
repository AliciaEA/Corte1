using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Registro
    {
        Persona[] personas = new Persona[30];

        public void AgregarPersona(Persona persona, int posicion)
        {
            personas[posicion] = persona;
        }

        public Persona[] GetPersonas()
        {
            return personas;
        }

        
    }
}
