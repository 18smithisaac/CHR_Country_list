using CHR_Country_list.Models;
using CHR_Country_list.Data;

namespace CHR_Country_list.Data
{
    public class MockCountryList : ICountryListRepo
    {
        public Route GetRoute(string name)
        {
            Graph g = new Graph(10,new string[] {"CAN","USA","MEX","BLZ","GTM","SLV","HND","NIC","CRI","PAN"}); 
    
            g.AddEdge(1, 0); //USA - CAN
            g.AddEdge(1, 2); //USA - MEX
            g.AddEdge(2, 3); //MEX - BLZ
            g.AddEdge(2, 4); //MEX - GTM
            g.AddEdge(4, 5); //GTM - SLV
            g.AddEdge(4, 6); //GTM - HND
            g.AddEdge(6, 7); //HND - NIC
            g.AddEdge(7, 8); //NIC - CRI
            g.AddEdge(8, 9); //CRI - PAN
            var temp = g.DepthFirstSearch(1, name); 

            return new Route{destination = name, path = temp}; 
        }
    }
}