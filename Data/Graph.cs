using System; 
using System.Collections.Generic; 

namespace CHR_Country_list.Data
{
    //Basic Graph data structure
    public class Graph 
    { 
        private int vertices;
        private List<int>[] adj; 
        private string [] countries;

        //Constructor, Inputs: v- # of verticies, countries- list of countries
        public Graph(int v, string [] countries) 
        { 
            vertices = v; 
            adj = new List<int>[v]; 
            for (int i = 0; i < v; ++i) 
                adj[i] = new List<int>(); 
            this.countries = countries;
            
        } 

        public void AddEdge(int v, int w) 
        { 
            adj[v].Add(w);
        } 

        //DepthFirstSearchUtil Recursive helper function for DepthFirstSearch
        //Inputs: v- current vertice, visited- visited verticies, target- string being searched for
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
    
        // DepthFirstSearch Inputs: v- vertice to start search from, target- string to search for 
        public List <string> DepthFirstSearch(int v, string target) 
        { 
            bool[] visited = new bool[vertices]; 
    
            return DepthFirstSearchUtil(v, visited, target); 
        } 
    } 
}