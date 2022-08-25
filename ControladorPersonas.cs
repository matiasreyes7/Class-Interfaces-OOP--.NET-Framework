using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Reyes
{
    internal class ControladorPersonas
    {
        List<Persona> listaPersonas;
        public ControladorPersonas()
        {
            listaPersonas = new List<Persona>();
        }
        public void agregarProfesor(uint legajo, string dni, string apellido, string nombre, string categoria)
        {
            listaPersonas.Add(new Profesor(legajo, dni, apellido, nombre, categoria));
        }
        public void agregarAlumno(uint legajo, string dni, string apellido, string nombre, string titulo)
        {
            listaPersonas.Add(new Alumno(legajo, dni, apellido, nombre, titulo));
        }
        public string mostrarLista()
        {
            string lista = "";
            listaPersonas.Sort();
            foreach(Persona persona in listaPersonas)
            {
                if(persona is Alumno)
                {
                    Persona auxA = (Alumno)persona;
                    lista = lista + auxA.darDatos() + "\n\n";
                }
                if (persona is Profesor)
                {
                    Persona auxP = (Profesor)persona;
                    lista = lista + auxP.darDatos() + "\n\n";
                }
            }
            return lista;
        }
        public void buscar(uint legajo)
        {
            int indice;
            Persona persona;
            persona = new Persona(legajo);
            indice=listaPersonas.IndexOf(persona);
            if (indice >= 0)
            {
                if(listaPersonas[indice] is Alumno)
                {
                    Interfaz.escribirMensaje("\n\nEl legajo ingresado corresponde a un alumno.");
                }
                else
                {
                    if (listaPersonas[indice] is Profesor)
                    {
                        Interfaz.escribirMensaje("\n\nEl legajo ingresado corresponde a un profesor.");
                    }
                    else
                    {
                        Interfaz.escribirMensaje("\n\nEl legajo ingresado no se encuentra en la lista.");
                    }
                }
                

            }
        }
        public void eliminar(uint legajo)
        {
            Persona persona;
            persona = new Persona(legajo);
            listaPersonas.Remove(persona);
        }
    }
}
