``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.1889/21H2/November2021Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.301
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT AVX2


```
|           Method |         Mean |       Error |      StdDev | Ratio |
|----------------- |-------------:|------------:|------------:|------:|
|  SynchronousRead | 909,710.8 μs | 3,337.66 μs | 2,958.75 μs | 1.000 |
| AsynchronousRead |     221.2 μs |    16.85 μs |    47.24 μs | 0.000 |
