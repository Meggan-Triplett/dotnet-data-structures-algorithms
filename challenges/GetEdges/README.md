# Get Edges
#### *Author: Meggan Triplett*

------------------------------

## Description

**A C# implementation of *retrieving edges from a graph*.**

GetEdges is a method that takes in a graph and an array of city names. 
Returns a tuple that contains whether the full trip is possible with direct flights, and how much it would cost.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| GetEdges | Returns a tuple that contains whether the full trip is possible with direct flights, and how much it would cost | O(n^2) | O(n^2) | GetEdges(vertex, [Narnia, Endor, Porthaven]) |

------------------------------

## Visuals

##### Get Edges Whiteboard
*The GetEdges method utilizes a for loop with a nested foreach and while loop. Will check to see if vertex neighbors contains destination city and will add it's price if it exists*
![Get Edges Whiteboard](https://github.com/Meggan-Triplett/dotnet-data-structures-algorithms/blob/master/assets/GetEdges%20Whiteboard.jpg?raw=true)

------------------------------

## Change Log