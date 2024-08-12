using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    internal class Cocina
    {
       public Alacena Alacena { get; private set; }
       public Amasador Amasador { get; private set; }
       public Cocinera Cocinera { get; private set; }

        public  Cocina(Alacena alacena, Amasador amasador, Cocinera cocinera)
        {
            this.Alacena = alacena;
            this.Amasador = amasador;
            this.Cocinera = cocinera;
        }
    }
}
