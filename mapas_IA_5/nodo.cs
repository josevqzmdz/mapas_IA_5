using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapas_IA_5
{
    internal class nodo
    {
        string nombre { get; set; } 
        public nodo(string nombre)
        {
            this.nombre = nombre;
        }
        public List<nodo> vecinos { get; set; }
        public List<vertice> vertices { get; set; }
        public int distancia { get; set; }  

    }
}
