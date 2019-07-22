# Hash Table
#### *Author: Meggan Triplett*

------------------------------

## Description

**A C# implementation of a *Hash Table* data structures.**

A *hash table* is an array that allows for a quick search through key value pairs.

Each index in the array contains a linked list made up of `Node`s that will have two properties.
1. `Key`, which is the array index
2. `Value`, which is the value being stored in said node
3. `Next`, which is the pointer to the next node in the linked list

Methods included in this `Hash Table` are `Add`, `Get`, `Contains` and `Hash`.

------------------------------

## Methods

| Linked List Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| `Add` | Takes in a `key` and it's `value` and creates a `node` that will be stored on the table| O() | O() | hashtable.Add(key, value) |
| `Get` | Takes in a `key` and retrieves the matching value from the table | O() | O() | hashtable.Get(key) |
| `Contains` | Takes in a `key` and returns a boolean, indicating if the key already exists on the table | O() | O() | hashtable.Contains(key) |
| `Hash` | Takes in an arbitrary `key` and returns an index in the collection| O() | O() | hashtable.Hash(key) |

------------------------------

## Visuals

##### Add Method
*The Add method takes in a key and it's value and create a node that will be stored on the hashtable.*
![Hash Table Add Method Example]()

##### Get Method
*The Get method*
![Hash Table Get Method Example]()

##### Contains Method
*The Contains method*
![Hash Table Contains Method Example]()

##### Hash Method
*The Hash method*
![Hash Table Hash Method Example]()

------------------------------

## Change Log