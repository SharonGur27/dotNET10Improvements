```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.7093)
Intel Core i7-10850H CPU 2.70GHz (Max: 2.71GHz), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
  Job-HFWDAV : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
  Job-NFJGQR : .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2


```
| Method                | Runtime   | Mean       | Ratio | Code Size | Allocated | Alloc Ratio |
|---------------------- |---------- |-----------:|------:|----------:|----------:|------------:|
| **NonEscapingNonClosure** | **.NET 10.0** |  **0.3430 ns** |  **0.44** |     **189 B** |         **-** |          **NA** |
| NonEscapingNonClosure | .NET 9.0  |  0.7825 ns |  1.01 |     189 B |         - |          NA |
|                       |           |            |       |           |           |             |
| **EscapingStoredFunc**    | **.NET 10.0** | **20.1078 ns** |  **0.95** |     **152 B** |      **88 B** |        **1.00** |
| EscapingStoredFunc    | .NET 9.0  | 21.3086 ns |  1.01 |     152 B |      88 B |        1.00 |
|                       |           |            |       |           |           |             |
| NonEscaping           | .NET 10.0 |  4.6143 ns |  0.27 |      37 B |      24 B |        0.27 |
| NonEscaping           | .NET 9.0  | 17.1955 ns |  1.01 |     124 B |      88 B |        1.00 |
