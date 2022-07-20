# 2. FizzBuzz
Given a number n, for each integer i in the range from 1 to n inclusive, print one value per line as follows:
If i is a multiple of both 3and 5, print FizzBuzz.
If i is a multiple of 3(but not 5), print Fizz.
If i is a multiple of 5(but not 3), print Buzz.
If i is not a multiple of 3 or 5, print the value of i.

## Function Description
Complete the function fizzBuzzin the editor below.
fizzBuzz has the following parameter(s):
int n: upper limit of values to test (inclusive)
Returns: NONE

The function must print the appropriate response for
each value /in the set {7, 2, ... n}in ascending order,
each on a separate line.

## Input Format for Custom Testing

Input from stdin will be processed as follows and
passed to the function.

The single integer n, the limit of the range to test: [1,2,...n].

## Sample Case 0

Sample Input

STDIN   Function
15    ->  n=15

Sample Output
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz

## Explanation

The numbers 3, 6, 9, and 72 are multiples of 3 (but not
5), so print Fizzon those lines.

The numbers 5and 70are multiples of 5 (but not 3),
so print Buzz on those lines.

The number 75is a multiple of both 3and 5, so print
FizzBuzz on that line.

None of the other values is a multiple of either 3or 5,
so print the value of /on those lines.