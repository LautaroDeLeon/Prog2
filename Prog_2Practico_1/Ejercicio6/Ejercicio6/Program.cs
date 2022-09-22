using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bucle = true;
            int horas = 0;
            int minutos = 0;
            int segundos = 0;
            int miliseg = 0;

            while (bucle == true)
            {
                if (horas < 10)
                {
                    Console.Write("0");
                }
                Console.Write(horas + ":");

                if (minutos < 10)
                {
                    Console.Write("0");
                }
                Console.Write(minutos + ":");

                if (segundos < 10)
                {
                    Console.Write("0");
                }
                Console.Write(segundos + ":");

                if (miliseg < 10)
                {
                    Console.Write("0");
                }
                Console.Write(miliseg);

                miliseg += 1;
                
                if(miliseg == 10)
                {
                    segundos += 1;
                    miliseg = 0;
                    if (segundos == 60)
                    {
                        minutos += 1;
                        segundos = 0;
                        if (minutos == 60)
                        {
                            horas += 1;
                            minutos = 0;
                            if (horas == 24)
                            {
                                horas = 0;
                            }
                        }
                    }
                }
                Thread.Sleep(1);
                Console.Clear();
            }
        }
    }
}
