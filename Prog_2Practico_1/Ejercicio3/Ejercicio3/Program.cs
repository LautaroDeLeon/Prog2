using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vectores miVector = new Vectores();

            int numero = 0;
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;

            Console.WriteLine("Bienvenido a la calculadora de vectores !");
            Console.WriteLine("");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese el numero x1");
            x1 = int.Parse(Console.ReadLine());
            miVector.setX1(x1);
            Console.Clear();

            Console.WriteLine("Ingrese el numero x2");
            x2 = int.Parse(Console.ReadLine());
            miVector.setX2(x2);
            Console.Clear();

            Console.WriteLine("Ingrese el numero y1");
            y1 = int.Parse(Console.ReadLine());
            miVector.setY1(y1);
            Console.Clear();

            Console.WriteLine("Ingrese el numero y2");
            y2 = int.Parse(Console.ReadLine());
            miVector.setY2(y2);
            Console.Clear();

            Console.WriteLine("1: Suma de vectores");
            Console.WriteLine("2: Resta de vectores");
            Console.WriteLine("3: Distancia entre vectores");
            Console.WriteLine("");
            Console.WriteLine("Ingrese un 0 si desea salir");
            Console.WriteLine("");
            numero = int.Parse(Console.ReadLine());

            while(numero != 0 && numero != 1 && numero != 2 && numero != 3)
            {
                Console.WriteLine("Ingrese un numero correcto");
                Console.WriteLine("");
                numero = int.Parse(Console.ReadLine());
            }

           while (numero == 1 || numero == 2 || numero == 3)
            {
                if(numero == 1)
                {
                    Console.Clear();
                    miVector.devuelveSuma();
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("1: Suma de vectores");
                    Console.WriteLine("2: Resta de vectores");
                    Console.WriteLine("3: Distancia entre vectores");
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese un 0 si desea salir");
                    Console.WriteLine("");
                    numero = int.Parse(Console.ReadLine());
                }
                if (numero == 2)
                {
                    Console.Clear();
                    miVector.devuelveResta();
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("1: Suma de vectores");
                    Console.WriteLine("2: Resta de vectores");
                    Console.WriteLine("3: Distancia entre vectores");
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese un 0 si desea salir");
                    Console.WriteLine("");
                    numero = int.Parse(Console.ReadLine());
                }
                if (numero == 3)
                {
                    Console.Clear();
                    miVector.distanciaEntreVectores();
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("1: Suma de vectores");
                    Console.WriteLine("2: Resta de vectores");
                    Console.WriteLine("3: Distancia entre vectores");
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese un 0 si desea salir");
                    Console.WriteLine("");
                    numero = int.Parse(Console.ReadLine());
                }
            }
        }
    }   
}