using System; 
using System.Collections.Generic; 

namespace CHR_Country_list.Data
{
    public class Graph 
    { 
        private int V;
        private List<int>[] adj; 
        private string [] countries;
    
        public Graph(int v, string [] countries) 
        { 
            V = v; 
            adj = new List<int>[v]; 
            this.countries = new string [v];
            for (int i = 0; i < v; ++i) 
                adj[i] = new List<int>(); 
            this.countries = countries;

            
        } 

        public void AddEdge(int v, int w) 
        { 
            adj[v].Add(w);
        } 

        public List <string> DepthFirstSearchUtil(int v, bool[] visited, string target) 
        { 
            visited[v] = true;
            if (countries[v].Equals(target))
            {
                List <string> path = new List<string>();
                path.Add(countries[v]);
                return path;
            } 
            List<int> vList = adj[v]; 
            foreach (var n in vList) 
            { 
                if (!visited[n]){
                    var temp = DepthFirstSearchUtil(n, visited, target); 
                    if (temp != null)
                    {
                        temp.Insert(0, countries[v]);
                        return temp;
                    }
                }
            } 
            return null;
        } 
    
        public List <string> DepthFirstSearch(int v, string target) 
        { 
            bool[] visited = new bool[V]; 
    
            return DepthFirstSearchUtil(v, visited, target); 
        } 
    } 
}