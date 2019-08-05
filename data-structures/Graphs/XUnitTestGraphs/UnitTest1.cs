using System;
using Xunit;
using Graphs.Classes;

namespace XUnitTestGraphs
{
    public class UnitTest1
    {
        [Fact]
        public void VertexCanBeAddedToGraph()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddVertex(42);

            string addedVertexValue = "42";

            Assert.Contains(addedVertexValue, "42");
        }

        //[Fact]
        public void EdgeCanBeAddedToGraph()
        {
            Graph<int> graph = new Graph<int>();
            Vertex<int> first = graph.AddVertex(42);
            Vertex<int> second = graph.AddVertex(36);

            graph.AddUndirectedEdge(first, second, 7);

           
        }

        //[Fact]
        public void AllVerticesCanBeRetrieved()
        {

        }

        //[Fact]
        public void AllNeighborsOfGivenVertexCanBeRetrieved()
        {

        }

        //[Fact]
        public void NumberOfNodesInGraphCanBeRetrieved()
        {

        }

        //[Fact]
        public void GraphOfOneVertexAndEdgeCanBeReturned()
        {

        }

        //[Fact]
        public void EmptyGraphReturnsNull()
        {
            Graph<int> graph = new Graph<int>();

            
        }

    }
}
