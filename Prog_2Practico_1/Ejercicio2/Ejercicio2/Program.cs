using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno miAlumno = new Alumno();
            miAlumno.imprimirNombre();
            miAlumno.imprimirNombreEdad();
            Console.WriteLine("");

            Alumno miAlumno2 = new Alumno(20);
            miAlumno2.imprimirNombre();
            miAlumno2.imprimirNombreEdad();
            Console.WriteLine("");

            Alumno miAlumno3 = new Alumno("Gerardo");
            miAlumno3.imprimirNombre();
            miAlumno3.imprimirNombreEdad();
            Console.WriteLine("");

            Alumno miAlumno4 = new Alumno("Matias", 15);
            miAlumno4.imprimirNombre();
            miAlumno4.imprimirNombreEdad();
            Console.WriteLine("");
        }
    }
}
