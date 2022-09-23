using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Auto
    {
        private string tipoClimatizador;
        private string tapiceria;

        public Auto()
        {
            this.tipoClimatizador = "Sin climatizador";
            this.tapiceria = "Tapizado de Cuero rojo";
        }
        public Auto(string tipoClim, string tipoTap)
        {
            this.tipoClimatizador = tipoClim;
            this.tapiceria = tipoTap;
        }
        public void setClim(string climatizador)
        {
            this.tipoClimatizador = climatizador;
        }
        public string getClim()
        {
            return(this.tipoClimatizador);
        }
        public void setTap(string tapiceria)
        {
            this.tapiceria = tapiceria;
        }
        public string getTap()
        {
            return (this.tapiceria);
        }
    }
}
