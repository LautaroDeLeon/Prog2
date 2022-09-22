using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Alumno
    {
        private string nombre;
        private int edad;
        public Alumno()
        {
            this.nombre = "Nombre no definido";
            this.edad = 0;
        }
        public Alumno(int edad)
        {
            this.nombre = "Nombre no definido";
            this.edad = edad;
        }
        public Alumno(string nombre)
        {
            this.nombre = nombre;
            this.edad = 0;
        }
        public Alumno(string nombre, int edad) 
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public int getEdad()
        {
            return (this.edad);
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return (this.nombre);
        }
        public void imprimirNombre()
        { 
            Console.WriteLine(nombre);
        }
        public void imprimirNombreEdad()
        {
            Console.WriteLine(nombre + ", " + edad + " años");
        }
    }
}
