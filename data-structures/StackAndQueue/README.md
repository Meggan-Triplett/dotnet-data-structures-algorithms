# Stack and Queue
#### *Author: Meggan Triplett*

------------------------------

## Description

**A C# implementation of *stack* and *queue* data structures.**

Stack is an ordered list that consists of nodes with similar data type, it's open on one end. 
	- Follows First in Last Out, Last in First Out structure.
	- Includes two constructors for `Stack`: 
		1. Instantiates an empty stack 
		2. Instantiates stack with one node
	- These individual nodes that have a reference to the `Next` node in the list as well as a `Value`.
	- Includes new `Node` property `Top`.
	- The methods of this `Stack` are `Push`, `Pop` and `Peek`.

Queue is an ordered list that consists of nodes with similar data type, it's open on both ends.
	- Follows First in First Out, Last in Last Out structure.
	- Includes two constructors for `Queue`: 
		1. Instantiates an empty queue 
		2. Instantiates queue with one node
	- These individual nodes that have a reference to the `Next` node in the list as well as a `Value`.
	- Includes new `Node` properties `Front` and `Rear`.
	- The methods of this `Queue` are `Enqueue`, `Dequeue` and `Peek`.

------------------------------

## Methods

| Stack Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Push | Adds a new `Node` to the `Stack` | O(1) | O(1) | stack.Push(42) |
| Pop | Removes the top `Node` from the `Top` of the `Stack` | O(1) | O(1) | stack.Pop() |
| Peek | Will return the `Value` of the `Node` at the `Top` of the `Stack` | O(1) | O(1) | stack.Peek() |

| Queue Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Enqueue | Adds a new `Node` to the `Rear` of the `Queue` | O(1) | O(1) | queue.Enqueue(42) |
| Dequeue | Remove a `Node` from the `Front` of the `Queue` and returns it's `Value` | O(1) | O(1) | queue.Enqueue(42) |
| Peek | Will return the `Value` of the `Node` at the `Front` of the `Queue` | O(1) | O(1) | queue.Peek() |
------------------------------

## Visuals
**Images still need to be generated and added**

##### Stack Push Method
*The Push Method takes in an int as a parameter and then creates a new Node which sets the int as it's 
Value and adds it to the Top of the Stack.*
![Stack Push Method Example](https://via.placeholder.com/750x500)

##### Stack Pop Method
*The Push Method removes the Node that is currently at the Top of the Stack.*
![Stack Pop Method Example](https://via.placeholder.com/750x500)

##### Stack Peek Method
*The Print Method returns the Value of the Node at the Top of the Stack.
![Stack Peek Method Example](https://via.placeholder.com/750x500)

##### Queue Enqueue Method
*The Enqueue Method takes in an int as a parameter and then creates a new Node which sets the int as it's*
Value and adds it to the Rear of the Queue.*
![Queue Enqueue Method Example](https://via.placeholder.com/750x500)

##### Queue Dequeue Method
*The Push Method removes the Node that is currently at the Front of the Queue and returns it's Value.*
![Queue Dequeue Method Example](https://via.placeholder.com/750x500)

##### Queue Peek Method
*The Peek Method returns the Value of the Node at the Front of the Queue.*
![Queue Peek Method Example](https://via.placeholder.com/750x500)

------------------------------

## Change Log