using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    internal class Amasador
    {
        public Amasador() { }   
        public double Amasar (double harina)
        {
            double masa = harina * 1.3;
            return masa;
        }
    }
}
