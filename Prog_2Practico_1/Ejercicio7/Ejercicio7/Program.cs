using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Remito miRemito = new Remito();
            Factura miFactura = new Factura();
            FacturaLuz miFacturaLuz = new FacturaLuz();
            Municipal miMunicipal = new Municipal();
            ReciboSueldo miReciboSueldo = new ReciboSueldo();

            int eleccion = 0;
            Console.WriteLine("MENU DE OPCIONES");
            Console.WriteLine("");
            Console.WriteLine("1: Ingresar y ver remito");
            Console.WriteLine("2: Ingresar y ver factura");
            Console.WriteLine("3: Ingresar y ver factura de luz");
            Console.WriteLine("4: Ingresar y ver municipal");
            Console.WriteLine("5: Ingresar y ver recibo de sueldo");
            Console.WriteLine("");
            eleccion = int.Parse(Console.ReadLine());
            
            while(eleccion < 1 || eleccion > 5)
            {
                Console.WriteLine("Ingrese una opcion correcta");
                Console.WriteLine("");
                eleccion = int.Parse(Console.ReadLine());              
            }

            switch(eleccion){
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ingrese cantidad de bultos");
                    int bultos = Int32.Parse(Console.ReadLine());
                    miRemito.setCantBultos(bultos);

                    Console.WriteLine("Ingrese fecha");
                    int fecha = Int32.Parse(Console.ReadLine());
                    miRemito.setFecha(fecha);

                    Console.WriteLine("Ingrese numero de remito");
                    int nroRemito = Int32.Parse(Console.ReadLine());
                    miRemito.setNumeroRemito(nroRemito);
                    Console.Clear();
                    Console.WriteLine("REMITO");
                    Console.WriteLine("");
                    miRemito.imprimirRemito();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese la fecha de la factura");
                    int factura = Int32.Parse(Console.ReadLine());
                    miFactura.setFechaFactura(factura);

                    Console.WriteLine("Ingrese el importe de la factura");
                    int importe = Int32.Parse(Console.ReadLine());
                    miFactura.setImporteFactura(importe);
                    Console.Clear();
                    Console.WriteLine("FACTURA");
                    Console.WriteLine("");
                    miFactura.imprimirFactura();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Ingrese el codigo de pago");
                    int codigoPago = Int32.Parse(Console.ReadLine());
                    miFacturaLuz.setCodigoPago(codigoPago);

                    Console.WriteLine("Ingrese el importe de la factura de luz ");
                    int importeLuz = Int32.Parse(Console.ReadLine());
                    miFacturaLuz.setImporteFacturaLuz(importeLuz);
                    Console.Clear();
                    Console.WriteLine("FACTURA LUZ");
                    miFacturaLuz.imprimirFacturaLuz();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Ingrese partida de municipal");
                    int partidaMunicipal = Int32.Parse(Console.ReadLine());
                    miMunicipal.setPartida(partidaMunicipal);

                    Console.WriteLine("Ingrese el importe municipal");
                    int importeMunicipal = Int32.Parse(Console.ReadLine());
                    miMunicipal.setImporte(importeMunicipal);
                    Console.Clear();
                    Console.WriteLine("MUNICIPAL");
                    miMunicipal.imprimirMunicipal();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Ingrese el legajo ");
                    int LegajoReciboDeSueldo = Int32.Parse(Console.ReadLine());
                    miReciboSueldo.setLegajo(LegajoReciboDeSueldo);

                    Console.WriteLine("Ingrese el total : ");
                    int Total = Int32.Parse(Console.ReadLine());
                    miReciboSueldo.setTotal(Total);
                    Console.Clear();
                    Console.WriteLine("RECIBO SUELDO");
                    miReciboSueldo.imprimirReciboSueldo();                   
                    break;
            }
        }
    }
}
