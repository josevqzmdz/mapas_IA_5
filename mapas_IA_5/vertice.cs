using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapas_IA_5
{
    public class vertice
    {
        nodo inicio { get; set; }
        nodo fin { get; set; }
        int distancia { get; set; } 

        public vertice(nodo inicio, nodo fin, int distancia)
        {
            this.inicio = inicio;
            this.fin = fin;
            this.distancia = distancia;
        }
    }
}
