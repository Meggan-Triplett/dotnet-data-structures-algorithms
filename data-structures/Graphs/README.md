# Graph
#### *Author: Meggan Triplett*

------------------------------

## Description

**A C# implementation of a *Graph* data structures.**

A *graph* is a non-linear data structure that is a collection of vertices(nodes) that can be connected with lines called edges.

- `Vertex`(node) is a data object that has a value.
- `Edge` is a connection between two nodes.
- `Neighbor`is a an adjacent vertex that is connected to another vertex via by edge.
- `Degree` is the number of edges connected to a given vertex.


Methods included in this `Graph` are `AddNode`, `AddEdge`, `GetNodes`, `GetNeighbors` and `Size`.

------------------------------

## Methods

| Linked List Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| `AddVertex` | Takes in a value and creates a vertex with that value and returns the new vertex | O(1) | O(1) | graph.AddVertex(42); |
| `AddDirectedEdge` |Takes in two nodes and the weight between them, and adds a directed edge connecting the two nodes with the weight as it's value | O(1) | O(1) | graph.AddDirectedEdge(first, second, 7); |
| `AddUndirectedEdge` | Takes in two nodes and the weight between them, and adds an undirected edge connecting the two nodes with the weight as it's value | O(1) | O(1) | graph.AddUndirectedEdge(first, second, 7); |
| `GetVertices` | | O(n) | O(n) | graph.GetVertices(); |
| `GetNeighbors` | | O(1) | O(1) | graph.GetNeighbors(); |
| `Size` | | O(1) | O(1) | graph.Size(); |

------------------------------

## Visuals

##### AddVertex Method
*The AddVertex method takes in a value and creates a vertex with the value being the input and returns the added node*
![Graph AddVertex Method Example]()

##### AddDirectedEdge Method
*The AddEdge method takes in two nodes and the weight between them, and adds a directed edge connecting the two nodes with the weight as it's value*
![Graph AddDirectedEdge Method Example]()

##### AddUndirectedEdge Method
*The AddUndirectedEdge method takes in two nodes and the weight between them, and adds an undirected edge connecting the two nodes with the weight as it's value*
![Graph AddUndirectedEdge Method Example]()

##### GetVertices Method
*The GetVertices method returns all of the vertices in the graph as a list*
![Graph GetVertices Method Example]()

##### GetNeighbors Method
*The GetNeighbors method takes in a given vertex and returns a collection of connected vertices with their weight if applicable*
![Graph GetNeighbors Method Example]()

##### Size Method
*The Size method returns the total number of vertices contained in the graph*
![Graph Size Method Example]()

------------------------------

## Change Log
1.01 Completed methods, updated README.md, and added some unit tests - 8/4/2019 - M.Triplett