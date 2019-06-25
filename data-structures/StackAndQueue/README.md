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
| Push | Adds a new `Node` to the `Linked List` | O(1) | O(1) | myList.Insert(99) |
| Includes | Takes in a value and returns a boolean depending on if the value is in the `LinkedList` | O(n) | O(1) | myList.Includes(99) |
| Print | Prints the `Linked List` to the console | O(n) | O(1) | myList.Print() |

| Queue Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Insert | Adds a new `Node` to the `Linked List` | O(1) | O(1) | myList.Insert(99) |
| Includes | Takes in a value and returns a boolean depending on if the value is in the `LinkedList` | O(n) | O(1) | myList.Includes(99) |
| Print | Prints the `Linked List` to the console | O(n) | O(1) | myList.Print() |
------------------------------

## Visuals
***[Add screenshots of your methods in action]***

##### Insert Method
***[In your own words explain what this method is doing]***
*The Insert Method takes in an int as a parameter. A new Node is then created using the* 
*int param as its Value. The new Node is then placed in the Linked List at the Head and*
*the previous Head is assigned as the new Nodes Next.*
![Image 1](https://via.placeholder.com/750x500)
##### Includes Method
***[In your own words explain what this method is doing]***
*The Includes Method takes in an int as a parameter then iterates through the Nodes of the*
*Linked List checking all the Values. If the value is found True is returned, if not then*
*False is returned.*
![Image 1](https://via.placeholder.com/750x500)
##### Print Method
***[In your own words explain what this method is doing]***
*The Print Method displays a well formatted depiction of the current state of the*
*Linked List by iterating over all Nodes.*
![Image 1](https://via.placeholder.com/750x500)

------------------------------

## Change Log