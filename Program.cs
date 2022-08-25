using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Reyes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            uint legajo;
            string nombre, apellido, dni, categoria, titulo;
            ControladorPersonas controlador = new ControladorPersonas();
            opcion = int.Parse(Interfaz.mostrarMenu());
            while (opcion != 6 && opcion >=1 && opcion < 6)
            {
                if (opcion == 1)
                {
                    Interfaz.escribirMensaje("\n\nDATOS DEL PROFESOR: ");
                    nombre= Interfaz.leerDato("Nombre: ");
                    apellido= Interfaz.leerDato("Apellido: ");
                    legajo = uint.Parse(Interfaz.leerDato("Legajo (numero mayor a cero): "));
                    dni = Interfaz.leerDato("DNI: ");
                    categoria = Interfaz.leerDato("Categoria (Profesor Titular, Profesor Adjunto, Jefe de Trabajos Practicos o Ayudante de Trabajos Practicos): ");
                    while(categoria!="Profesor Titular"&&categoria!="Profesor Adjunto"&&categoria!="Jefe de Trabajos Practicos"&&categoria!="Ayudante de Trabajos Practicos")
                    {
                        Interfaz.escribirMensaje("\n\nDebe ingresar alguna de las opciones que aparecen entre parentesis.");
                        categoria = Interfaz.leerDato("Categoria (Profesor Titular, Profesor Adjunto, Jefe de Trabajos Practicos o Ayudante de Trabajos Practicos): ");
                    }
                    controlador.agregarProfesor(legajo, dni, apellido, nombre, categoria);
                }
                if (opcion == 2)
                {
                    Interfaz.escribirMensaje("\n\nDATOS DEL ALUMNO: ");
                    nombre = Interfaz.leerDato("Nombre: ");
                    apellido = Interfaz.leerDato("Apellido: ");
                    legajo = uint.Parse(Interfaz.leerDato("Legajo (numero mayor a cero): "));
                    dni = Interfaz.leerDato("DNI: ");
                    titulo = Interfaz.leerDato("Titulo secundario: ");
                    controlador.agregarAlumno(legajo, dni, apellido, nombre, titulo);
                }
                if (opcion == 3)
                {
                    Interfaz.escribirMensaje("\n\nLISTA COMPLETA:\n"+controlador.mostrarLista());
                    Interfaz.escribirMensaje("\n\nPresione una tecla para continuar");
                    Console.ReadKey();
                }
                if (opcion == 4)
                {
                    legajo=uint.Parse(Interfaz.leerDato("\n\nIngrese el legajo a buscar: "));
                    controlador.buscar(legajo);
                    Interfaz.escribirMensaje("\n\nPresione una tecla para continuar");
                    Console.ReadKey();
                }
                if (opcion == 5)
                {
                    legajo = uint.Parse(Interfaz.leerDato("\n\nIngrese el legajo a buscar: "));
                    controlador.eliminar(legajo);
                }
                opcion= int.Parse(Interfaz.mostrarMenu());
            }
            Interfaz.escribirMensaje("\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
