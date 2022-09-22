using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            Console.WriteLine("1: Ingresar dimensiones y suma de matrices");
            Console.WriteLine("2: Matriz aleatoria");
            Console.Write("Ingrese un numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());
            Matriz miMatriz = new Matriz();

            switch (numeroIngresado)
                {
                    case 1:
                    Console.Clear();                  
                    miMatriz.pedirDatos();
                    miMatriz.Cargar();
                    miMatriz.visualizar();
                    Console.Read();
                    break;
                   
                    case 2:
                    Console.Clear();
                    miMatriz.aleatoria();
                    break;                      
                }              
        }
    }
}
