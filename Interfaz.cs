using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Reyes
{
    internal static class Interfaz
    {
        public static string mostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("UNIVERSIDAD APP - MENU PRINCIPAL");
            Console.WriteLine("\n1. Registrar a un profesor");
            Console.WriteLine("2. Registrar a un alumno");
            Console.WriteLine("3. Visualizar los datos de todos los alumnos y profesores");
            Console.WriteLine("4. Ingresar un legajo para obtener si es alumno o profesor");
            Console.WriteLine("5. Ingresar un legajo para eliminar de la lista");
            Console.WriteLine("6. Salir");
            Console.Write("\nIngrese una opcion entre 1 y 6: ");
            return Console.ReadLine();
        }
        public static void escribirMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        public static string leerDato(string mensaje)
        {
            string devolucion;
            Console.Write(mensaje);
            devolucion = Console.ReadLine();
            return devolucion;
        }
    }
}
