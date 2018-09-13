using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Pez : Animal
    {
        //override es para indicar que el abstracto desplazar() en
        //la clase animal se va a usar aquí.
        override public string desplazar()
        {
            return "Soy " + Nombre + " y estoy nadando";
        }
    }
}
