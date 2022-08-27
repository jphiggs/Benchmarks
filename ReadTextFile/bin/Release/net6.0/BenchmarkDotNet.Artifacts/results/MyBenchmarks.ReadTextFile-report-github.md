``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.1889/21H2/November2021Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.301
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT AVX2


```
|          Method |     Mean |    Error |   StdDev |
|---------------- |---------:|---------:|---------:|
| SynchronousRead | 927.0 ms | 12.17 ms | 10.79 ms |
