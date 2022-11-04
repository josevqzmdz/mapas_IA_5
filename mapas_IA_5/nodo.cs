using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapas_IA_5
{
    public class nodo
    {
            public string nombre { get; set; } 
            public nodo(string nombre)
            {
                this.nombre = nombre;
                vecinos = new List<nodo>();
                vertices = new List<vertice>();
            }
            public List<nodo> vecinos { get; set; }
            public List<vertice> vertices { get; set; }
            public int distancia { get; set;}
    }
}
