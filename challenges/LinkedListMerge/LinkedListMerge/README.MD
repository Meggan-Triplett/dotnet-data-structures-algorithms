# Merge Linked Lists
#### *Author: Meggan Triplett*

------------------------------

## Problem Domain
Write a function called mergeLists which takes two linked lists as arguments. 
Zip the two linked lists together into one so that the nodes alternate between the two lists 
and return a reference to the head of the zipped list. 

------------------------------

## Inputs and Expected Outputs

**| Input | Expected Output |**
| LinkedList1, LinkedList2| MergedLinkList |
| :----------- | :----------- |
| head -> [1] -> [3] -> [2] -> X, head -> [5] -> [9] -> [4] -> X | head -> [1] -> [5] -> [3] -> [9] -> [2] -> [4] -> X |
| head -> [1] -> [3] -> X, head -> [5] -> [9] -> [4] -> X | head -> [1] -> [5] -> [3] -> [9] -> [4] -> X |


------------------------------

## Big O


| Time | Space |
| :----------- |
| O(n) | O(1) |


------------------------------


## Whiteboard Visual
![White Board Solution](https://github.com/Meggan-Triplett/dotnet-data-structures-algorithms/blob/master/assets/LinkedListMergeWhiteBoard.jpg?raw=true)

------------------------------

## Change Log
1.2 - Fixed Image Link In README, 

------------------------------
