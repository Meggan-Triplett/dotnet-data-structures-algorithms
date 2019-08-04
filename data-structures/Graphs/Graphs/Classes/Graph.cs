using System;
using System.Collections.Generic;
using System.Text;


namespace Graphs.Classes
{
    class Graph<T>
    {

        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; } 

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        

    }
}
