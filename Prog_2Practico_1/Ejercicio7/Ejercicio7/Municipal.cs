using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Municipal
    {
        private int importe;
        private int partida;

        public void setImporte(int numero)
        {
            this.importe = numero;
        }
        public void setPartida(int numero)
        {
            this.partida = numero;
        }
        public void imprimirMunicipal()
        {
            Console.WriteLine("El importe de la municipal es: " + importe + "$");
            Console.WriteLine("La partida de la municipal es: " + partida);
        }
    }
}
