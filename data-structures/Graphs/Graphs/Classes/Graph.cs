using System;
using System.Collections.Generic;
using System.Text;


namespace Graphs.Classes
{
    class Graph<T>
    {
        //Collection of key value pairs of Vertices and their Edges
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        public int size = 0;

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

            size++;

            return vertex;
        }

        /// <summary>
        /// Adds a directed edge between two vertices on the graph
        /// </summary>
        /// <param name="first">Reference to the first vertex</param>
        /// <param name="second">Reference to the second vertex</param>
        /// <param name="weight">Weight value of the edge between the first and second vertices</param>
        public void AddDirectedEdge(Vertex<T> first, Vertex<T> second, int weight)
        {
            AdjacencyList[first].Add(
                new Edge<T>
                {
                    Vertex = second,
                    Weight = weight
                });
        }

        /// <summary>
        /// Adds a undirected edge between two vertices on the graph
        /// </summary>
        /// <param name="first">Reference to the first vertex</param>
        /// <param name="second">Reference to the second vertex</param>
        /// <param name="weight">Weight value of the edge between the first and second vertices</param>
        public void AddUndirectedEdge(Vertex<T> first, Vertex<T> second, int weight)
        {
            AddDirectedEdge(first, second, weight);
            AddDirectedEdge(second, first, weight);
        }

        /// <summary>
        /// Retrieves all vertices contained in the adjacency list
        /// </summary>
        /// <returns>List that contains all vertices</returns>
        public List<Vertex<T>> GetVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();

            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);
            }

            return vertices;
        }

        /// <summary>
        /// Retrieves a list of all edges connected to a particular vertex
        /// </summary>
        /// <param name="vertex">The vertex from which the list of neighbors should be provided of</param>
        /// <returns>A list of all edges connected to a particular vertex and each edge's respective weight</returns>
        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            return AdjacencyList[vertex];
        }

        /// <summary>
        /// Retrieves total number of verticies in the graph
        /// </summary>
        /// <returns>Total number of verticies in the graph</returns>
        public int Size()
        {
            return size;
        }

    }
}
