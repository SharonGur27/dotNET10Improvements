```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.7093)
Intel Core i7-10850H CPU 2.70GHz (Max: 2.71GHz), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
  Job-HFWDAV : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
  Job-NFJGQR : .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2


```
| Method                 | Runtime   | Mean         | Ratio | Allocated | Alloc Ratio |
|----------------------- |---------- |-------------:|------:|----------:|------------:|
| AppendContains         | .NET 10.0 |     98.48 ns |  0.02 |      56 B |        0.64 |
| AppendContains         | .NET 9.0  |  4,133.59 ns |  1.00 |      88 B |        1.00 |
|                        |           |              |       |           |             |
| ConcatContains         | .NET 10.0 |    106.32 ns |  0.02 |      56 B |        0.64 |
| ConcatContains         | .NET 9.0  |  4,335.04 ns |  1.00 |      88 B |        1.00 |
|                        |           |              |       |           |             |
| DefaultIfEmptyContains | .NET 10.0 |     86.57 ns |  0.72 |         - |          NA |
| DefaultIfEmptyContains | .NET 9.0  |    121.00 ns |  1.00 |         - |          NA |
|                        |           |              |       |           |             |
| DistinctContains       | .NET 10.0 |    115.67 ns | 0.005 |      64 B |       0.001 |
| DistinctContains       | .NET 9.0  | 22,938.19 ns | 1.005 |   58656 B |       1.000 |
|                        |           |              |       |           |             |
| OrderByContains        | .NET 10.0 |     96.96 ns | 0.006 |      88 B |       0.007 |
| OrderByContains        | .NET 9.0  | 17,388.75 ns | 1.005 |   12280 B |       1.000 |
|                        |           |              |       |           |             |
| ReverseContains        | .NET 10.0 |    117.70 ns |  0.20 |      48 B |        0.01 |
| ReverseContains        | .NET 9.0  |    597.33 ns |  1.01 |    4072 B |        1.00 |
|                        |           |              |       |           |             |
| UnionContains          | .NET 10.0 |    107.19 ns | 0.004 |      72 B |       0.001 |
| UnionContains          | .NET 9.0  | 29,230.90 ns | 1.049 |   58664 B |       1.000 |
|                        |           |              |       |           |             |
| SelectManyContains     | .NET 10.0 |    133.08 ns | 0.005 |     128 B |        0.67 |
| SelectManyContains     | .NET 9.0  | 27,328.15 ns | 1.001 |     192 B |        1.00 |
|                        |           |              |       |           |             |
| WhereSelectContains    | .NET 10.0 |    380.84 ns |  0.02 |     104 B |        1.00 |
| WhereSelectContains    | .NET 9.0  | 17,770.20 ns |  1.00 |     104 B |        1.00 |
