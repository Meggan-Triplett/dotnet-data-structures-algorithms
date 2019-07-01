# Binary Tree
#### *Author: Meggan Triplett*

------------------------------

## Description

**A C# implementation of *Binary Search Tree* data structures.**

A binary search tree is a data structure that can link together two successor nodes two a base node.
The node values are integers in sorted order
- A base node is often referred to as the `Root`
- The two successor nodes are traditionally referred to as `Left` and `Right`

Each `Node` in the binary tree will have three properties that can be set.
1. `Value`, which is the value being stored in said node
2. `Left`, which is the pointer to the left successor node, it's value is less than the value of the root node
3. `Right`, which is the pointer to the right successor node, it's value is less than the value of the root node

The `Binary Tree` itself will have two additional properties.
1. `Root`, which dictates the first `Node` in the `Binary Tree`

Methods included in the `Binary Tree` class are `PreOrder`, `InOrder` and `PostOrder`.
Methods included in the `Binary Search Tree` class are `Add` and `Contains`.

------------------------------

## Methods

| Binary Tree Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| `PreOrder` | Will traverse a `Binary Tree` collecting the `Value`s of the `Root` then existing `Left` `Node`, then existing `Right` `Node`, until all `Node` `Value`s have been collected, that collection will then be returned| O(n) | O(1) | binaryTree.PreOrder() |
| `InOrder` | Will traverse a `Binary Tree` collecting the `Value`s of the existing `Left` `Node`, then `Root`, then existing `Right` `Node`, until all `Node` `Value`s have been collected, that collection will then be returned | O(n) | O(1) | binaryTree.InOrder() |
| `PostOrder` | Will traverse a `Binary Tree` collecting the `Value`s of the existing `Left` `Node`, then existing `Right` `Node`, then `Root`, until all `Node` `Value`s have been collected, that collection will then be returned | O(n) | O(1) | binaryTree.PostOrder() |

| Binary Search Tree Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| `Add` | Accepts int `Value` and will then traverse the tree, checking if the `Root` `Value` is less than or greater than given int `Value`. | O(n) | O(1) | binarySearchTree.Add(42) |
| `Contains` | Takes in int `Value` and will then traverse the tree, checking if the `Root` `Value` is less than, greater than or equal to the given int `Value`. Will then traverse to `Left` `Node` if int `Value` is less than `Root` `Value`, will then traverse to `Right` `Node` if int `Value` is greater than `Root` `Value`, if `Root` `Value` is equal to given `Value`, returns true, else continue traversal until all `Node` `Value`s have been check and return false | O(log n) | O(1) | binarySearchTree.Contains(42) |
| 

------------------------------

## Visuals

##### PreOrder Method
*The PreOrder Method traverses a Binary Tree, collecting the values of the root then existing left node, 
then existing right node, until all node values have been collected, that collection will then be returned*
![Binary Tree PreOrder Method Example]()

##### InOrder Method
*The InOrder Method traverses a Binary Tree, collecting the values of the existing left node, then root, 
then existing right node, until all node values have been collected, that collection will then be returned*
![Binary Tree InOrder Method Example]()

##### PostOrder Method
*The PostOrder Method traverses a Binary Tree, collecting the values of the existing left node, then existing right node,
 then root, until all node values have been collected, that collection will then be returned*
![Binary Tree PostOrder Method Examples]()

##### Add Method
*The Add Method *
![Binary Search Tree Add Method Examples]()

##### Contains Method
*The Contains Method accepts int value and will then traverse the tree, checking if the root value is less than, 
greater than or equal to the given int value. Will then traverse to left node if int value is less than root value, 
will then traverse to right node if int value is greater than root value, if root value is equal to given value,
returns true, else continue traversal until all node values have been check and return false*
![Binary Search Tree Includes Method Examples]()

------------------------------

## Change Log
