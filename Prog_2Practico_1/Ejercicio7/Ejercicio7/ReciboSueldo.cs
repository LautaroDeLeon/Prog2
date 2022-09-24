using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class ReciboSueldo
    {
        private int legajo;
        private int total;

        public void setLegajo(int numero)
        {
            this.legajo = numero;
        }
        public void setTotal(int numero)
        {
            this.total = numero;
        }
        public void imprimirReciboSueldo()
        {
            Console.WriteLine("El legajo de su recibo de sueldo es de: " + legajo + "$");
            Console.WriteLine("El total de su recibo de sueldo es de: " + total + "$");
        }

    }
}
