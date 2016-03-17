# Max element in stack

The problem [https://www.hackerrank.com/challenges/maximum-element](https://www.hackerrank.com/challenges/maximum-element) illustrates how, for example, a recursion would work if it always chose a task from a stack with a maximum priority. Now imagine you're building a new OS / compiler that behaves as described above, that is, the first task to be done is the task with a maximum priority. What a programming language would you use to write such a compiler? You're welcome to add your solution in here.

### Leaderboard

| Programming language | Running time, ms       |
| -------------------- | ---------------------- | 
| C                    | 10                     |
| Pascal               | 20                     |
| C++                  | 100                    |
| Python               | 150                    |
| C#                   | 300                    |
| Java                 | 720                    |
| BASH                 | > 3000 (time exceeded) |
 
_The server provides a precision of 10 ms. Running time is measured by the worst test case scenario, provided by the author._

### Problem description

You have an empty sequence, and you will be given _N_ queries. Each query is one of these three types:

    1. x  -Push the element x into the stack.
    2.    -Delete the element present at the top of the stack.
    3.    -Print the maximum element in the stack.

#### Input Format

The first line of input contains an integer, _N_. The next _N_ lines each contain an above mentioned query. (It is guaranteed that each query is valid.)

#### Constraints
 
    1 ≤ N ≤ 10^5 
    1 ≤ x ≤ 10^9 
    1 ≤ type ≤ 3

#### Output Format

For each type **3** query, print the maximum element in the stack on a new line.

Sample Input

    10
    1 97
    2
    1 20
    2
    1 26
    1 20
    2
    3
    1 91
    3
    
Sample Output

    26
    91
