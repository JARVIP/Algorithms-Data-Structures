using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GG.Graphs
{

    public class BFS
    {
        public void Solve(Graph graph, int s)
        {
            // Mark all the vertices as not
            // visited(By default set as false)
            bool[] visited = new bool[graph.Verteces];
            for(int i = 0; i < graph.Verteces; i++)
                visited[i] = false;

            // Create a queue for BFS
            Queue<int> queue = new Queue<int>();

            visited[s] = true;
            queue.Enqueue(s);

            while(queue.Count() > 0)
            {
                // Dequeue a vertex from queue
                // and print it
                s = queue.Dequeue();
                Console.Write(s + " ");

                // Get all adjacent vertices of the
                // dequeued vertex s. If a adjacent
                // has not been visited, then mark it
                // visited and enqueue it
                LinkedList<int> list = graph.Adj[s];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.Enqueue(val);
                    }
                }
            }
        }
    }
}
