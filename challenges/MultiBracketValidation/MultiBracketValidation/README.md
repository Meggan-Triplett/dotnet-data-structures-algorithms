# Multi Bracket Validation
#### *Author: Meggan Triplett*

------------------------------

## Problem Domain
Create a method called public static bool MultiBracketValidation(string input)
	Input <- string input
	Output <- boolean balanced
The method will take in a string as its only argument.
It will return a boolean representing whether or not the brackets in the string are balanced.

This method will determine if a string has syntactically correct use of brackets.


------------------------------

## Inputs and Expected Outputs

| Input | Output |
| :----------- | :----------- |
| {} | true |
| {}(){} | true
| {}{Code}{Fellows}(()) | true |
| [({}] | False |
| (]( | False |
| {(}) | False |

------------------------------

## Big O


| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |


------------------------------


## Whiteboard Visual

![White Board Solution for Multi Bracket Validation](\assets\MultiBracketValidationWhiteBoard.jpg)

------------------------------

## Change Log