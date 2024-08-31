using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaLista
{
    public class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        // Sobrescribimos ToString para mostrar el nombre en el ListBox.
        public override string ToString()
        {
            return Nombre;
        }
    }

}
