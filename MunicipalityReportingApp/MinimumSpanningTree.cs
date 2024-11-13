using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityReportingApp
{
    public class MinimumSpanningTree
    {
        public static List<(string, string, int)> Prim(Graph graph, string startVertex)
        {
            var mstEdges = new List<(string, string, int)>();
            var visited = new HashSet<string>();
            var edgeList = new List<(string, string, int)>();

            visited.Add(startVertex);
            foreach (var neighbor in graph.GetNeighbors(startVertex))
            {
                edgeList.Add((startVertex, neighbor, 1)); // Assuming weight is 1 for simplicity
            }

            while (edgeList.Count > 0)
            {
                edgeList.Sort((x, y) => x.Item3.CompareTo(y.Item3)); // Sort edges by weight
                var edge = edgeList[0];
                edgeList.RemoveAt(0);

                if (!visited.Contains(edge.Item2))
                {
                    visited.Add(edge.Item2);
                    mstEdges.Add(edge);

                    foreach (var neighbor in graph.GetNeighbors(edge.Item2))
                    {
                        edgeList.Add((edge.Item2, neighbor, 1)); // Assuming weight is 1 for simplicity
                    }
                }
            }

            return mstEdges;
        }
    }
}
