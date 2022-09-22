using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto miAuto = new Auto();

            Console.WriteLine(miAuto.getClim());
            Console.WriteLine(miAuto.getTap());
            Console.WriteLine("");

            miAuto.setClim("Climatizador de 4ta generacion");
            Console.WriteLine(miAuto.getClim());
            miAuto.setTap("Tapiceria roja");
            Console.WriteLine(miAuto.getTap());
            Console.WriteLine("");

            Auto miAuto2 = new Auto("Climatizador de 4ta generacion", "Tapiceria roja");
            Console.WriteLine(miAuto2.getClim());
            Console.WriteLine(miAuto2.getTap());
            Console.WriteLine("");
        }
    }
}
