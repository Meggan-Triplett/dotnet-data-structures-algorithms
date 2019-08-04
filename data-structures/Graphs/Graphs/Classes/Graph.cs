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

        /// <summary>
        /// Creates a new vertex that is then added to the adjacency list
        /// </summary>
        /// <param name="value">Desired value of the vertex</param>
        /// <returns>The newly created vertex</returns>
        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> vertex = new Vertex<T>(value);
            AdjacencyList.Add(vertex, new List<Edge<T>>());

            return vertex;
        }

        /// <summary>
        /// Adds a directed edge between two vertices on the graph
        /// </summary>
        /// <param name="first">Reference to the first vertex</param>
        /// <param name="second">Reference to the second vertex</param>
        /// <param name="weight">Weight value of the edge between the first and second vertex</param>
        public void AddDirectedEdge(Vertex<T> first, Vertex<T> second, int weight)
        {
            AdjacencyList[first].Add(
                new Edge<T>
                {
                    Vertex = second,
                    Weight = weight
                });
        }

        public void AddUndirectedEdge(Vertex<T> first, Vertex<T> second, int weight)
        {
            AddDirectedEdge(first, second, weight);
            AddDirectedEdge(second, first, weight);
        }

    }
}
