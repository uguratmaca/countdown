# Countdown Solver
Created for **benchmarking .netframework 4.8 vs .net5 vs .net6**

Please firstly watch this video below.  

[![Extraordinary Example](https://github.com/uguratmaca/countdown/blob/main/countdown-video-preview.JPG?raw=true)](https://www.youtube.com/watch?v=pfa3MHLLSWI "Extraordinary Example")

**Target**: **952**   
**Numbers to use**: 25 50 75 100 3 6  

Competitor Solution:  
100 + 6 = 106  
106 * 3 = 318  
318 * 75 = 23850  
23850 / 25 = 952

## Problem
Des chiffres et des lettres, bir kelime bir işlem yarışmasındaki bir işlemi çözen program, breadth first search
https://en.wikipedia.org/wiki/Des_chiffres_et_des_lettres (Numbers round section)

## Problem Solving Algorithm
Breadth First Search  

![Breadth First Search](https://github.com/uguratmaca/countdown/blob/main/breadth-first-search.png?raw=true)


Find the results with minimum calculation count.
(attention it uses too much ram)

## Performance Result
| Framework | 10 Iterations AVG Time to Calculate (ms) | 
|----------|:-------------:|
| .net framework 4.8 | 42229 | 
| .net5 (core) | 22691 |  
| .net6 (core) | 17670 |
