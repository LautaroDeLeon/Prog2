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
            miVector.devuelveRestaSuma();

            Vectores miVector2 = new Vectores();
            miVector2.setX1(2);
            miVector2.setX2(1);
            miVector2.setY1(-3);
            miVector2.setY2(2);
            miVector2.devuelveRestaSuma();

            miVector2.distanciaEntreVectores();
        }
    }
}
