using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class FacturaLuz
    {
        private int codigoPago;
        private int importe;

        public void setCodigoPago(int numero)
        {
            this.codigoPago = numero;
        }
        public void setImporteFacturaLuz(int numero)
        {
            this.importe = numero;
        }
        public  void imprimirFacturaLuz()
        {
            Console.WriteLine("El codigo de pago de su factura de luz es: " + codigoPago);
            Console.WriteLine("El importe de su factura de luz es igual a: " + importe + "$");
        }
    }
}
