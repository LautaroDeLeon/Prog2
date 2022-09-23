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
            int aux = 0;
            Console.WriteLine("1: Alumno y edad aleatoria");
            Console.WriteLine("2: Alumno aleatorio");
            Console.WriteLine("3: Ingresar alumno");
            Console.WriteLine("");
            aux = int.Parse(Console.ReadLine());

            if (aux == 1)
            {
                Alumno miAlumno = new Alumno();
                var random = new Random();
                int nroRandom = random.Next(18, 40);
                var random2 = new Random();
                int nroRandomNombre = random2.Next(1, 5);
                string nombre = "";

                switch (nroRandomNombre)
                {
                    case 1: nombre = "Martin";
                        break;
                    case 2:
                        nombre = "Lucas";
                        break;
                    case 3:
                        nombre = "Sofia";
                        break;
                    case 4:
                        nombre = "German";
                        break;
                    case 5:
                        nombre = "Benicio";
                        break;
                }

                miAlumno.setNombre(nombre);
                miAlumno.setEdad(nroRandom);
                Console.Clear();
                Console.WriteLine("Alumno generado aleatoriamente: ");
                Console.WriteLine("");
                miAlumno.imprimirNombreEdad();
                Console.WriteLine("");
            }

            if (aux == 2)
            {
                Alumno miAlumno2 = new Alumno();
               
                var random2 = new Random();
                int nroRandomNombre = random2.Next(1, 5);
                string nombre = "";

                switch (nroRandomNombre)
                {
                    case 1:
                        nombre = "Martin";
                        break;
                    case 2:
                        nombre = "Lucas";
                        break;
                    case 3:
                        nombre = "Sofia";
                        break;
                    case 4:
                        nombre = "German";
                        break;
                    case 5:
                        nombre = "Benicio";
                        break;
                }

                miAlumno2.setNombre(nombre);               
                Console.Clear();
                Console.WriteLine("Alumno generado aleatoriamente: ");
                Console.WriteLine("");
                miAlumno2.imprimirNombre();
                Console.WriteLine("");
            }

            if (aux == 3)
            {
                Console.Clear();
                string nombre = "";
                Console.WriteLine("Ingrese el nombre del alumno");
                Console.WriteLine(  "");
                nombre = Console.ReadLine();
                Console.Clear();


                int edad = 0;
                Console.WriteLine("Ingrese la edad del alumno");
                Console.WriteLine("");
                edad = int.Parse(Console.ReadLine());
                Console.Clear();

                Alumno miAlumno3 = new Alumno(nombre, edad);
                miAlumno3.imprimirNombreEdad();
                Console.WriteLine("");
            }
        }
    }
}
