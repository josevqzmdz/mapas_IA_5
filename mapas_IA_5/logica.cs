using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapas_IA_5
{
    internal class logica
    {

        public logica()
        {


        } // fin de constructor

        // algoritmo de busqueda de profundidad
        // # de nodos
        static int n = 14;

        // v = posicion de nodo recorrido

        // https://www.koderdojo.com/blog/depth-first-search-algorithm-in-csharp-and-net-core
        public List<nodo> busquedaProfundidad(List<nodo> grafo, nodo inicio)
        {
            List<nodo> nodosRecorridos = new List<nodo>();
            
            if (!grafo.Contains(inicio))
            {
                return nodosRecorridos;
            }
            

            var stack = new Stack<nodo>();
            stack.Push(inicio);

            while (stack.Count > 0)
            {
                var vertice = stack.Pop();
                if (nodosRecorridos.Contains(vertice))
                {
                    continue;
                }
                nodosRecorridos.Add(vertice);

                foreach(var vecino in grafo)
                {
                    if (!nodosRecorridos.Contains(vecino))
                    {
                        stack.Push(vecino);
                        
                    }
                }
            }
            return nodosRecorridos;
        }
    }
}
