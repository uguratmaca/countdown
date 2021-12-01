# countdown
Created for **benchmarking .netframework 4.8 vs .net5 vs .net6**

## Example Problem
Des chiffres et des lettres, bir kelime bir işlem yarışmasındaki bir işlemi çözen program, breadth first search
https://en.wikipedia.org/wiki/Des_chiffres_et_des_lettres (Numbers round section)

## Example Problem Solving Algorithm
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
