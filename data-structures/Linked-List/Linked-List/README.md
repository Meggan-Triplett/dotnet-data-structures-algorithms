# Linked List
#### *Author: Meggan Triplett*

------------------------------

## Description

**A C# implementation of a *Singly Linked List* data structures.**

A singly linked list is a data structure that can chain together different nodes.

Each `Node` in the linked list will have two properties.
1. `Value`, which is the value being stored in said node
2. `Next`, which is the pointer to the next node in the linked list

The `Linked List` itself will have two additional properties.
1. `Head`, which dictates the first `Node` in the `Linked List`
2. `Current`, which is utilized while traversing a `Linked List`, and will dictate the `Current` `Node`

Methods included in this `Linked List` are `Push`, `Pop` and `Peek`.

------------------------------

## Methods

| Linked List Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Push | Adds a new `Node` to the `Stack` | O(1) | O(1) | stack.Push(42) |
| Pop | Removes the top `Node` from the `Top` of the `Stack` | O(1) | O(1) | stack.Pop() |
| Peek | Will return the `Value` of the `Node` at the `Top` of the `Stack` | O(1) | O(1) | stack.Peek() |

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