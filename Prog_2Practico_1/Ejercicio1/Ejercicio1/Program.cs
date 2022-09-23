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
            int usuario = 0;
            Console.WriteLine("Bienvenido al modificador de vehiculos, seleccione una opcion.");
            Console.WriteLine("");
            Console.WriteLine("1: Modificar atributos del vehiculo");
            Console.WriteLine("2: Generador por defecto");
            Console.WriteLine("3: Generador aleatorio");
            Console.WriteLine("");
            usuario = int.Parse(Console.ReadLine());

            if (usuario == 1)
            {
                Console.Clear();
                Auto miAuto2 = new Auto();
                int aux = 0;
                Console.WriteLine("Seleccione el tipo y color de tapiceria");
                Console.WriteLine("");
                Console.WriteLine("1: Cuero negro");
                Console.WriteLine("2: Sintetico negro");
                Console.WriteLine("3: Cuero blanco");
                Console.WriteLine("4: Sintetico blanco");
                Console.WriteLine("5: Cuero gris");
                Console.WriteLine("6: Sintetico gris");
                Console.WriteLine("");
                aux = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (aux)
                {
                    case 1:
                        miAuto2.setTap("Cuero negro");
                        break;
                    case 2:
                        miAuto2.setTap("Sintetico negro");
                        break;
                    case 3:
                        miAuto2.setTap("Cuero blanco");
                        break;
                    case 4:
                        miAuto2.setTap("Sintetico blanco");
                        break;
                    case 5:
                        miAuto2.setTap("Cuero gris");
                        break;
                    case 6:
                        miAuto2.setTap("Sintetico gris");
                        break;
                }

                int aux2 = 0;
                Console.WriteLine("Seleccione el tipo de climatizador");
                Console.WriteLine("");
                Console.WriteLine("1: Aire acondicionado");
                Console.WriteLine("2: Calefaccion");
                Console.WriteLine("3: Sin climatizador");
                Console.WriteLine("");
                aux2 = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (aux2)
                {
                    case 1:
                        miAuto2.setClim("Aire acondicionado");
                        break;
                    case 2:
                        miAuto2.setClim("Calefaccion");
                        break;
                    case 3:
                        miAuto2.setClim("Sin climatizador");
                        break;
                }
                
                Console.WriteLine("Presione enter para ver los cambios");
                Console.Read();
                Console.Clear();

                Console.WriteLine("Su vehiculo estará equipado con: ");
                Console.WriteLine("");
                Console.WriteLine(miAuto2.getTap()); 
               
                Console.WriteLine(miAuto2.getClim());
                Console.WriteLine("");
            }
            if (usuario == 2)
            {
                Console.Clear();
                Auto miAuto = new Auto();
                Console.WriteLine("Su vehiculo estará equipado con: ");
                Console.WriteLine("");
                Console.WriteLine(miAuto.getClim());
                Console.WriteLine(miAuto.getTap());
                Console.WriteLine("");
                Console.Read();
            }
            if (usuario == 3)
            {
                var random1 = new Random();
                var random2 = new Random();
                string tapizado = "";
                string climatizador = "";
                int nroGenerado = random1.Next(1, 6);
                int nroClim = random2.Next(1, 3);

                switch (nroGenerado)
                {
                    case 1:
                        tapizado = "Cuero negro";
                        break;
                    case 2:
                        tapizado = "Sintetico negro";
                        break;
                    case 3:
                        tapizado = "Cuero blanco";
                        break;
                    case 4:
                        tapizado = "Sintetico blanco";
                        break;
                    case 5:
                        tapizado = "Cuero gris";
                        break;
                    case 6:
                        tapizado = "Sintetico gris";
                        break;
                }
                switch (nroClim)
                {
                    case 1:
                        climatizador = "Aire acondicionado";
                        break;
                    case 2:
                        climatizador = "Calefaccion";
                        break;
                    case 3:
                        climatizador = "Sin climatizador";
                        break;
                }

                Console.Clear();
                Auto miAuto3 = new Auto(climatizador, tapizado);
                Console.WriteLine("Su vehiculo estará equipado con: ");
                Console.WriteLine("");
                Console.WriteLine(miAuto3.getClim());
                Console.WriteLine( miAuto3.getTap() ); 
                Console.WriteLine("");
                Console.Read();
            }

        }
    }
}
