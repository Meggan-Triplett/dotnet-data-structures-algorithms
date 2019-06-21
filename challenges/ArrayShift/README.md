# Challenge Summary
Insert and shift an array in C#.

## Challenge Description
Write a function called insertShiftArray which takes in an array and the value to be added. 
Then retun a new array with the new value added at the middle index.

## Approach & Efficiency
**Approach**
We used a for loop to go through the input array. 
Nested in the for loop are if else statements to determine if the element is greater than or less 
than the input array's midpoint.
All elements from the input array that were less than the midpoint  would keep the same index position 
in the new array.
All elements from the input array that were greater than the midpoint would move up an index position 
the new array.
The input value would then into the index postion both less than or equal and greater than or equal to 
the midpoint.

**Space and Time**
- Space: O(n), new array was created for output
- Time: O(n), utilized a for loop that iterated through the whole input array


## Solution

![Whiteboard solution created by Meggan Triplett in collaboration with Richard Rosado and Jonathan Rice](../../assets/ArrayShift.jpg)