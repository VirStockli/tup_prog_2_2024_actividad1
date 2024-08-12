using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    internal class Alacena
    {
        public double Harina { get; private set; }

        public void ReponerHarina(double cantidad)
        {
            this.Harina = cantidad; /// Esto es igual que decir: Harina += cantidad
        }
        public double Fruta { get; set; }
        public void ReponerFruta(double cantidad)
        {
            this.Fruta = cantidad; //Esto es igual que decir: Fruta+= cantidad
        }
        public double TomarHarina(double requerido)
        {
            if (requerido <= Harina)
            {
                Harina -= requerido;
                return requerido;
            }
            else
            {
                double restante = Harina;
                Harina = 0;
                return restante;
            }
        }
        public double TomarFruta(double requerido)
        {
            if (requerido <= Fruta)
            {
                Fruta -= requerido;
                return requerido;
            }
            else
            {
                double restante = Fruta;
                Fruta = 0;
                return restante;
            }
        }
    }
}
