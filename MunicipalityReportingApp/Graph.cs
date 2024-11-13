using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityReportingApp
{
    public class Graph
{
    public Dictionary<string, List<string>> AdjacencyList { get; private set; }

    public Graph()
    {
        AdjacencyList = new Dictionary<string, List<string>>();
    }

    public void AddVertex(string id)
    {
        if (!AdjacencyList.ContainsKey(id))
        {
            AdjacencyList[id] = new List<string>();
        }
    }

    public void AddEdge(string from, string to)
    {
        if (!AdjacencyList.ContainsKey(from))
        {
            AddVertex(from);
        }
        if (!AdjacencyList.ContainsKey(to))
        {
            AddVertex(to);
        }
        AdjacencyList[from].Add(to);
    }

    public List<string> GetNeighbors(string id)
    {
        if (AdjacencyList.ContainsKey(id))
        {
            return AdjacencyList[id];
        }
        return new List<string>();
    }

    public void TraverseDepthFirst(string startId)
    {
        HashSet<string> visited = new HashSet<string>();
        TraverseDepthFirstHelper(startId, visited);
    }

    private void TraverseDepthFirstHelper(string id, HashSet<string> visited)
    {
        if (visited.Contains(id)) return;

        visited.Add(id);
        Console.WriteLine(id); // Process the node

        foreach (var neighbor in GetNeighbors(id))
        {
            TraverseDepthFirstHelper(neighbor, visited);
        }
    }
}
}
