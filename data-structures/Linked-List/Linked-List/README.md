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

Methods included in this `Linked List` are `Insert`, `Includes` and `Print`.

------------------------------

## Methods

| Linked List Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| `Insert` | Takes in a new int that will be the `Value` and creates a new `Node` that gets added as the `Head` of the `Linked List` | O(1) | O(1) | linklist.Insert(42) |
| `Includes` | Takes in any int, returns a boolean depending on whether the `Value` exists as a `Node`'s `Value` somewhere in the `Linked List` | O(n) | O(1) | linklist.Includes(42) |
| `Print` | Will display to console the `Value` of each `Node` in the `Linked List` | O(n) | O(1) | linklist.Print() |

------------------------------

## Visuals

##### Insert Method
*The Insert Method takes in a new int that will be the Value and creates a new Node that gets added as the Head 
of the Linked List.*
![Linked List Insert Method Example](https://github.com/Meggan-Triplett/dotnet-data-structures-algorithms/blob/master/assets/LinkedList-InsertMethodExample.JPG?raw=true)

##### Includes Method
*The Includes Method Takes in any int, returns a boolean depending on whether the Value exists as a Node's Value 
somewhere in the Linked List.*
![Linked List Includes Method Example](https://github.com/Meggan-Triplett/dotnet-data-structures-algorithms/blob/master/assets/LinkedList-IncludesMethodExample.JPG?raw=true)

##### Print Method
*The Print Method will display to console the Value of each Node in the Linked List.**
![Linked List Print Method Example](https://github.com/Meggan-Triplett/dotnet-data-structures-algorithms/blob/master/assets/LinkedList-PrintMethodExample.JPG?raw=true)


------------------------------

## Change Log
1.2 - Updated README with images, completed unit tests. 6/28/2019 - Changes made by M.Triplett
