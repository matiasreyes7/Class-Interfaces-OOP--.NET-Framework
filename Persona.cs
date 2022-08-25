using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Reyes
{
    internal class Persona:IEquatable<Persona>, IComparable
    {
        uint legajo;
        string dni;
        string apellido;
        string nombre;
        public Persona()
        {
            legajo = 0;
            dni = "sin asignar";
            apellido = "sin asignar";
            nombre = "sin asignar";
        }
        public Persona(uint leg, string dni, string ape, string nom)
        {
            legajo = leg;
            this.dni = dni;
            apellido = ape;
            nombre = nom;
        }
        public Persona(uint leg)
        {
            legajo = leg;
            this.dni = "sin asignar";
            apellido = "sin asignar";
            nombre = "sin asignar";
        }
        public void setLegajo(uint leg)
        {
            legajo = leg;
        }
        public uint getLegajo()
        {
            return legajo;
        }
        public void setDni(string dni)
        {
            this.dni = dni;
        }
        public string getDni()
        {
            return dni;
        }
        public void setApellido(string ape)
        {
            apellido = ape;
        }
        public string getApellido()
        {
            return apellido;
        }
        public void setNombre(string nom)
        {
            nombre = nom;
        }
        public string getNombre()
        {
            return nombre;
        }
        public bool Equals(Persona other)
        {
            if(other is Persona)
            {
                if(this.legajo== other.legajo)
                {
                    return true;
                }
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            if(obj is Persona)
            {
                Persona objAux = (Persona)obj;
                if(this.legajo== objAux.legajo)
                {
                    return 0;
                }
                if (this.legajo > objAux.legajo)
                {
                    return 1;
                }
                if(this.legajo < objAux.legajo)
                {
                    return -1;
                }
            }
            return int.MaxValue;
        }
        public virtual string darDatos()
        {
            return "Legajo: " + legajo + "\nNombre: " + nombre + "\nApellido: " + apellido + "\nDNI: " + dni;
        }
    }
}
