using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GG.Graphs
{
    public class Graph
    {
        private int _v;
        private LinkedList<int>[] _adj;

        public int Verteces { get { return _v; } }
        public LinkedList<int>[] Adj { get { return _adj; } }

        public Graph(int v)
        {
            _adj = new LinkedList<int>[v];
            for(int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
            }

            _v = v;
        }

        public void AddEdge(int v, int w)
        {
            _adj[v].AddLast(w);
        }
    }
}
