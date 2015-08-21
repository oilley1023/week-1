# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 

 Name: Patsamon Boonchai 570611023

## Revision, put your commit number here
* Sort from larger to smaller:
* Without flag:

## Questions
1. How this code can sort number from smaller to larger
 
Answer: the bubble sort works by comparing adjacent pairs of objects in the array.  
If the objects are not in the correct ordered, they are swapped so that the largest of the two moves up. 
This process continues until the largest of the objects, eventually "bubbles" up to the highest position in the array. 
After this occurs, the search for the  next largest object begins. 
The swapping continues until the whole array is in the correct order.

2. What if two numbers equal, what will happen? 

Answer: It will stay at the same place and no swapping. they will be on the same position.

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: 27 times.

4. Why we need flag variable ? 

Answer: Flag variable check for the answer that if the result is return "true" is in fuction,if the result is return "false" is not in the funtion from "While" condtions

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: The program will run faster, without while loop
but we will get the wrong answer.