using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapas_IA_5
{
    public class nodo
    {
        public Dictionary<nodo, int> vecinos { get; set; } = new Dictionary<nodo, int>();   
        public string nombre { get; set; }
        public nodo(string nombre) => this.nombre = nombre;

        public static void SetVecinos(nodo inicio, nodo fin, int distancia)
        {
            inicio.vecinos.Add(fin, distancia);
            fin.vecinos.Add(inicio, distancia);
        }

        public IEnumerable<(nodo, nodo, int)> busquedaProfundidad()
        {
            List<nodo> nodosRecorridos = new List<nodo>();
            Stack<(nodo n, int distancia)> stack = new Stack<(nodo, int)>();
            stack.Push((this, 0));

            while (stack.Count > 0)
            {
                var vertice = stack.Pop();
                yield return (this, vertice.n, vertice.distancia);
                if (nodosRecorridos.Contains(vertice.n))
                {
                    continue;
                }
                nodosRecorridos.Add(vertice.n);

                foreach( var vecino in vertice.n.vecinos)
                {
                    if (!nodosRecorridos.Contains(vecino.Key))
                    {
                        stack.Push((vecino.Key, vecino.Value + vertice.distancia));
                    }
                }
            }
        }// fin de DFS

        /*public IEnumerable<(nodo, nodo, int)> BusquedaAnchura()
        {
            var nodosRecorridos = new List<nodo>();
            Queue<(nodo n, int distancia)> fila = new Queue<(nodo n, int distancia)>();
            fila.Enqueue((this, 0));

            while (fila.Any())
            {
                var s = fila.First();
                fila.Dequeue();
                nodosRecorridos.Add(s.n);

                foreach (var val in fila)
                {
                    if (!nodosRecorridos.Contains(s.n))
                    {
                        fila.Append(());
                    }
                }
            }
        }*/

        public void dijkstra(int[,] grafo, int fuente)
        {
            
        }
    }
}
