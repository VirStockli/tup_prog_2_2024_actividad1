using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    internal class Cocinera
    {
        //<<readonly>>+Nombre - atributo
        public string Nombre { get; private set; }
        string estadoTareas;

        //<<create>>+Cocinera(:string) - constructor
        public Cocinera (string nombre)
        {
            this.Nombre = nombre;
        }

        //métodos:
        public void FormaLaMasa() { estadoTareas = "Formando la Masa"; }
        public void CortaLaMasa() { estadoTareas = "Cortando la Masa"; }
        public void Hornea() { estadoTareas = "Horneando";  }
        public string ContestarEnQueEtapaEsta()
        {
            return estadoTareas;
        }

    }
}
