# Fizz Buzz Tree
#### *Author: Meggan Triplett*

------------------------------

## Problem Domain

Create a method called FizzBuzzTree which takes a tree as an argument.
Determine if each node is divisible by 3, 5, or both 
Then change the value of each node accordingly:
- If value is divisible by 3, replace the value with "Fizz"
- If value is divisible by 5, replace the value with "Buzz"
- If value is divisible by 3 and 5, replace the value with "FizzBuzz"

------------------------------

## Inputs and Expected Outputs

**PreOrder Traversal Used**
Input <- |8||15||21||40||13||60||35||27||90||51|
Output <- |8||"FizzBuzz"||"Fizz"||"Buzz"||13||"FizzBuzz"||"Buzz"||"Fizz"||"FizzBuzz"||51|

------------------------------

## Big O


| Time | Space |
| :----------- | :----------- |
| O(n) | O(H) h = height of the tree |


------------------------------


## Whiteboard Visual

![White Board Solution for FizzBuzzTree](https://github.com/Meggan-Triplett/dotnet-data-structures-algorithms/blob/master/assets/FizzBuzzTree.jpg?raw=true)

------------------------------

## Change Log