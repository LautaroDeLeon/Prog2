using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Vectores
    {
        private int x1 = 0;
        private int x2 = 0;
        private int y1 = 0;
        private int y2 = 0;
        public int distancia = 0;

        public void setX1(int numero)
        {
            this.x1 = numero;
        }
        public void setX2(int numero)
        {
            this.x2 = numero;
        }
        public void setY1(int numero)
        {
            this.y1 = numero;
        }
        public void setY2(int numero)
        {
            this.y2 = numero;
        }
        public void devuelveSuma()
        {
            Console.WriteLine("El resultado de la suma de los vectores es:");
            Console.WriteLine((x1 + y1,x2 + y2));
            Console.WriteLine("");
        }
        public void devuelveResta()
        {
            Console.WriteLine("El resultado de la resta de los vectores es:");
            Console.WriteLine((x1 - y1, x2 - y2));
            Console.WriteLine("");
        }
        public void distanciaEntreVectores()
        {
            Console.WriteLine("La distancia entre vectores es:");
            distancia = (((x1 - y1)*(x1 - y1)) + ((x2 - y2) * (x2 - y2)));
            Console.WriteLine(Math.Sqrt(distancia));
            Console.WriteLine("");
        }
    }
}
