﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    internal class Cocina
    {
       public Alacena Alacena { get; private set; }

        public  Cocina(Alacena a)
        {
            this.Alacena = a;
        }
    }
}
