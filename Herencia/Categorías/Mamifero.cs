using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Mamifero : Animal
    {
        override public string desplazar()
        {
            return "Soy " + Nombre + " y estoy caminando";
        }
    }
}
