using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //Con abstract hacemos que una clase no se pueda instanciar.
    //con instanciar se refiere a que no podemos crear una variable como:
    //Animal ejemplo = new Animal(); porque es sólo para definir datos,
    //no para la creación de objetos como tal.
    abstract class Animal
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }

        //
        abstract public string desplazar();
    }
}
