``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1889 (21H2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.301
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                         Method | LineNumber | LineCharMultiplier |       Mean |     Error |    StdDev | Ratio | RatioSD | Code Size |    Gen 0 |   Gen 1 | Allocated |
|------------------------------- |----------- |------------------- |-----------:|----------:|----------:|------:|--------:|----------:|---------:|--------:|----------:|
| **ReadLineUsingStringReaderAsync** |         **20** |                  **1** |   **1.462 μs** | **0.0179 μs** | **0.0167 μs** |  **1.00** |    **0.00** |      **0 KB** |   **0.7553** |  **0.0076** |      **6 KB** |
|     ReadLineUsingPipelineAsync |         20 |                  1 |   2.741 μs | 0.0200 μs | 0.0167 μs |  1.87 |    0.02 |      0 KB |   0.2327 |       - |      2 KB |
| ReadLineUsingPipelineVer2Async |         20 |                  1 |   1.607 μs | 0.0125 μs | 0.0117 μs |  1.10 |    0.02 |      0 KB |   0.2346 |       - |      2 KB |
|                                |            |                    |            |           |           |       |         |           |          |         |           |
| **ReadLineUsingStringReaderAsync** |         **20** |                  **2** |   **1.620 μs** | **0.0081 μs** | **0.0075 μs** |  **1.00** |    **0.00** |      **0 KB** |   **0.7935** |  **0.0095** |      **6 KB** |
|     ReadLineUsingPipelineAsync |         20 |                  2 |   2.976 μs | 0.0244 μs | 0.0228 μs |  1.84 |    0.02 |      0 KB |   0.2708 |       - |      2 KB |
| ReadLineUsingPipelineVer2Async |         20 |                  2 |   1.632 μs | 0.0089 μs | 0.0074 μs |  1.01 |    0.01 |      0 KB |   0.2728 |       - |      2 KB |
|                                |            |                    |            |           |           |       |         |           |          |         |           |
| **ReadLineUsingStringReaderAsync** |         **20** |                  **8** |   **2.930 μs** | **0.0312 μs** | **0.0260 μs** |  **1.00** |    **0.00** |      **0 KB** |   **1.1177** |  **0.0114** |      **9 KB** |
|     ReadLineUsingPipelineAsync |         20 |                  8 |   3.323 μs | 0.0217 μs | 0.0203 μs |  1.13 |    0.01 |      0 KB |   0.5569 |       - |      5 KB |
| ReadLineUsingPipelineVer2Async |         20 |                  8 |   1.856 μs | 0.0144 μs | 0.0135 μs |  0.63 |    0.01 |      0 KB |   0.5589 |       - |      5 KB |
|                                |            |                    |            |           |           |       |         |           |          |         |           |
| **ReadLineUsingStringReaderAsync** |         **20** |               **1000** | **200.558 μs** | **1.2411 μs** | **1.1609 μs** |  **1.00** |    **0.00** |      **0 KB** | **116.2109** | **15.3809** |    **951 KB** |
|     ReadLineUsingPipelineAsync |         20 |               1000 |  72.745 μs | 0.7268 μs | 0.6798 μs |  0.36 |    0.00 |      0 KB |  48.2178 |  3.1738 |    396 KB |
| ReadLineUsingPipelineVer2Async |         20 |               1000 |  73.653 μs | 0.7827 μs | 0.7321 μs |  0.37 |    0.00 |      0 KB |  48.2178 |  0.1221 |    396 KB |
