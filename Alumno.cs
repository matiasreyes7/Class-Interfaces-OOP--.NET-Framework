using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Reyes
{
    internal class Alumno:Persona
    {
        string tituloSec;
        public Alumno():base()
        {
            tituloSec = "sin asignar";
        }
        public Alumno(uint legajo, string dni, string apellido, string nombre, string titulo) : base(legajo, dni, apellido, nombre)
        {
            tituloSec = titulo;
        }
        public void setTitulo(string titulo)
        {
            tituloSec = titulo;
        }
        public string getTitulo()
        {
            return tituloSec;
        }
        public override string darDatos()
        {
            return "DATOS DEL ALUMNO:\n" + base.darDatos() + "\nTitulo secundario: " + tituloSec;
        }
    }
}
