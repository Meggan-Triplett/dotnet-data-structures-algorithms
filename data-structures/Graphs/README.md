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
| `AddNode` | | O() | O() |  |
| `AddEdge` | | O() | O() |  |
| `GetNodes` | | O() | O() |  |
| `GetNeighbors` | | O() | O() |  |
| `Size` | | O() | O() |  |

------------------------------

## Visuals

##### AddNode Method
*The AddNode method takes in a value and creates a vertex with the value being the input and returns the added node*
![Graph AddNode Method Example]()

##### AddEdge Method
*The AddEdge method takes in two nodes and the weight between them, if applicable, and adds an edge connecting the two nodes with the weight as it's value*
![Graph AddEdge Method Example]()

##### GetNodes Method
*The GetNodes method returns all of the vertices in the graph as a list*
![Graph GetNodes Method Example]()

##### GetNeighbors Method
*The GetNeighbors method takes in a given vertex and returns a collection of connected vertices with their weight if applicable*
![Graph GetNeighbors Method Example]()

##### Size Method
*The Size method returns the total number of vertices contained in the graph*
![Graph Size Method Example]()

------------------------------

## Change Log