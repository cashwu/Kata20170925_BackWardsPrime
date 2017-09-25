# [Backwards Read Primes](https://www.codewars.com/kata/backwards-read-primes/csharp)

---

Backwards Read Primes are primes that when read backwards in base 10 (from right to left) are a different prime. (This rules out primes which are palindromes.)

```
Examples:
13 17 31 37 71 73 are Backwards Read Primes
```

13 is such because it's prime and read from right to left writes 31 which is prime too. Same for the others.

## Task

Find all Backwards Read Primes between two positive given numbers (both inclusive), the second one being greater than the first one. The resulting array or the resulting string will be ordered following the natural order of the prime numbers.

## Example

```csharp
backwardsPrime(2, 100) => "13 17 31 37 71 73 79 97"
backwardsPrime(9900, 10000) => "9923 9931 9941 9967"
```

---

### 中文大意

找出一個區間所有的 prime，而且這個 prime 正反的數字都要是 prime 並且不可以是回文
