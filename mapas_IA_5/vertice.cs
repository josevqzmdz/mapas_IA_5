using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapas_IA_5
{
    public class vertice
    {
        public nodo inicio { get; set; }
        public nodo fin { get; set; }
        public int distancia { get; set; } 
        public string distanciaVecinos { get; set; }    
        public vertice(nodo inicio, nodo fin, int distancia)
        {
            this.inicio = inicio;
            this.fin = fin;
            this.distancia = distancia;
            this.distanciaVecinos = inicio.nombre + " - " + fin.nombre + " = " + distancia.ToString();
        }
    }
}
