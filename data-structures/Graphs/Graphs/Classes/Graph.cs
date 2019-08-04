using System;
using System.Collections.Generic;
using System.Text;


namespace Graphs.Classes
{
    class Graph<T>
    {
        //Collection of key value pairs of Vertices and their Edges
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; } 

        //Graph constructor that is built from an AdjacencyList
        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> vertex = new Vertex<T>(value);
            AdjacencyList.Add(vertex, new List<Edge<T>>());

            return vertex;
        }

    }
}
