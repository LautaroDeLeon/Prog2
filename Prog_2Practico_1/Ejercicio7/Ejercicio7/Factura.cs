using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Factura
    {
        private int fecha;
        private int importe;

        public void setFechaFactura(int numero)
        {
            this.fecha = numero;   
        }
        public void setImporteFactura(int numero)
        {
            this.importe = numero;
        }
        public void imprimirFactura()
        {

            Console.WriteLine("La fecha de su factura data en el dia: " + fecha);
            Console.WriteLine("El importe de su remito es igual a " + importe + "$");
        }
    }
}
