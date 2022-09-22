using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
        class Matriz
        {
            private int[,] MatrizA;
            private int[,] MatrizB;
            private int[,] MatrizC;
            int n = 0;
            int m = 0;
        public void pedirDatos()
        {
            Console.Write("Ingrese alto de la matriz: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese ancho de la matriz: ");
            m = int.Parse(Console.ReadLine());
        }

        public void Cargar()
            {
                MatrizA = new int[10, 10];
                MatrizB = new int[10, 10];
                MatrizC = new int[10, 10];
                Console.Clear();
                Console.WriteLine("Ingresando datos al matriz A");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                        string linea;
                        linea = Console.ReadLine();
                        MatrizA[i, j] = int.Parse(linea);
                    }
                }
                Console.Clear();
                Console.WriteLine("Ingresando datos al matriz B");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                        string linea;
                        linea = Console.ReadLine();
                        MatrizB[i, j] = int.Parse(linea);
                    }
                }
                
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        MatrizC[i, j] = MatrizA[i, j] + MatrizB[i, j];
                    }
                }
            }
            
            public void visualizar()
            {
                Console.Clear();
                Console.WriteLine("La suma de la MatrizA y MatrizB es :");
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("\n");
                    for (int j = 1; j <= m; j++)
                    {
                        Console.Write(MatrizC[i, j] + "  ");
                    }
                }
                Console.ReadLine();
            }

        public void aleatoria()
        {
            int modificacion = 0;

            Console.Write("Ingrese alto de la matriz: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese ancho de la matriz: ");
            m = int.Parse(Console.ReadLine());
            var random = new Random();
            

            int[,] matrizAleatoria = new int[n, m];
           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int randomNumber = random.Next(1, 10);
                    matrizAleatoria[i, j] = randomNumber;
                    Console.Write($"{matrizAleatoria[i, j]}" + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            Console.WriteLine("¿Quiere modificar algun numero?");
            Console.WriteLine("1: SI");
            Console.WriteLine("2: NO");
            modificacion = int.Parse(Console.ReadLine());
            
            if(modificacion == 1)
            {
                int columna = 0;
                int fila = 0;

                Console.Write("Ingrese la fila del numero: ");
                fila = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la columna del numero: ");
                columna = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el nuevo numero: ");
                matrizAleatoria[fila, columna] = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                 
                        Console.Write($"{matrizAleatoria[i, j]}" + " ");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                Console.ReadLine(); 
            }
        }
        }
}