using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Reyes
{
    internal class Profesor:Persona
    {
        string categoria;
        public Profesor():base()
        {
            categoria = "sin asignar";
        }
        public Profesor(uint legajo, string dni, string apellido, string nombre, string categoria) : base(legajo, dni, apellido, nombre)
        {
            this.categoria = categoria;
        }
        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }
        public string getCategoria()
        {
            return categoria;
        }
        public override string darDatos()
        {
            return "DATOS DEL PROFESOR:\n"+base.darDatos() + "\nCategoria: "+categoria;
        }
    }
}
