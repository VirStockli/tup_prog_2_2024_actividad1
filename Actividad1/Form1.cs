using Actividad1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{
    public partial class Form1 : Form
    {
        Cocina miCocina;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e) //botón Crear Cocina
        {
            Alacena alacena = new Alacena();
            Amasador amasador = new Amasador();
            //atributo nombre entonces se debe "mandar" el atributo al crear el objeto
            Cocinera cocinera = new Cocinera("Anita"); 

            miCocina = new Cocina(alacena, amasador, cocinera);
            
        }

        private void ReponerIngrediente_Click(object sender, EventArgs e)
        {
            Alacena a = miCocina.Alacena;
            a.ReponerHarina(Convert.ToDouble(tbxharina.Text));
            a.ReponerFruta(Convert.ToDouble(tbxfruta.Text));
        }

        private void btnCocinar_Click(object sender, EventArgs e)
        {
            //pido a la cocina su alacena
            Alacena alacena = miCocina.Alacena;
            //saca harina de la alacena
            double cantHarina = alacena.TomarHarina(Convert.ToDouble(tbxharina.Text));
            //saca fruta de la alacena
            double cantFruta = alacena.TomarFruta(Convert.ToDouble(tbxfruta.Text));
            //pido a la cocina su amasadora
            Amasador amasador = miCocina.Amasador;
            //introduce los ingredientes
            double masaProducida = amasador.Amasar(cantHarina);
            //Llama a la cocinera que haga su parte
            Cocinera Anita = miCocina.Cocinera;

            lbMensaje.Items.Add("Misterio - Ana, reportate?");
            lbMensaje.Items.Add($"Ana - {Anita.ContestarEnQueEtapaEsta()}");

            Anita.FormaLaMasa();
            lbMensaje.Items.Add("Misterio - Ana, reportate?");
            lbMensaje.Items.Add($"Ana - {Anita.ContestarEnQueEtapaEsta()}");

            Anita.CortaLaMasa();
            lbMensaje.Items.Add("Misterio - Ana, reportate?");
            lbMensaje.Items.Add($"Ana - {Anita.ContestarEnQueEtapaEsta()}");

            Anita.Hornea();
            lbMensaje.Items.Add("Misterio - Ana, reportate?");
            lbMensaje.Items.Add($"Ana - {Anita.ContestarEnQueEtapaEsta()}");

        }
    }
}
