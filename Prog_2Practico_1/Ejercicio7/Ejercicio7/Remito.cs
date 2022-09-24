using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Remito
    {
        private int cantBultos;
        private int fecha;
        private int numeroRemito;

        public void setCantBultos(int numero)
        {
            this.cantBultos = numero;
        }
        public void setFecha(int numero)
        {
            this.fecha = numero;
        }
        public void setNumeroRemito(int numero)
        {
            this.numeroRemito = numero;
        }
        public void imprimirRemito()
        {
            
            Console.WriteLine("La cantidad de bultos son: " + cantBultos);
            Console.WriteLine("La fecha del remito es: " + fecha);
            Console.WriteLine("El numero de remito es: " + numeroRemito);
        }
    }
}
