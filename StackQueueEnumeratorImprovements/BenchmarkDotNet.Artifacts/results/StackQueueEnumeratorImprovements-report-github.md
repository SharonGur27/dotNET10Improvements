```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.7093)
Intel Core i7-10850H CPU 2.70GHz (Max: 2.71GHz), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
  Job-HFWDAV : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
  Job-NFJGQR : .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2


```
| Method                | Runtime   | Count | Mean         | Ratio | Code Size | Allocated | Alloc Ratio |
|---------------------- |---------- |------ |-------------:|------:|----------:|----------:|------------:|
| **StackDirect**           | **.NET 10.0** | **10**    |     **8.142 ns** |  **0.23** |      **60 B** |         **-** |          **NA** |
| QueueDirect           | .NET 10.0 | 10    |    12.597 ns |  0.35 |      90 B |         - |          NA |
| ConcurrentQueueDirect | .NET 10.0 | 10    |    35.572 ns |  1.00 |     100 B |         - |          NA |
| StackDirect           | .NET 9.0  | 10    |    35.651 ns |  1.00 |     339 B |         - |          NA |
| QueueDirect           | .NET 9.0  | 10    |    36.009 ns |  1.01 |     261 B |         - |          NA |
| ConcurrentQueueDirect | .NET 9.0  | 10    |   141.776 ns |  3.99 |     310 B |      56 B |          NA |
|                       |           |       |              |       |           |           |             |
| **StackDirect**           | **.NET 10.0** | **1000**  |   **690.104 ns** |  **0.22** |      **60 B** |         **-** |          **NA** |
| QueueDirect           | .NET 10.0 | 1000  |   984.471 ns |  0.32 |      99 B |         - |          NA |
| ConcurrentQueueDirect | .NET 10.0 | 1000  | 1,270.460 ns |  0.41 |     101 B |         - |          NA |
| StackDirect           | .NET 9.0  | 1000  | 3,083.491 ns |  1.00 |     339 B |         - |          NA |
| QueueDirect           | .NET 9.0  | 1000  | 3,267.809 ns |  1.06 |     261 B |         - |          NA |
| ConcurrentQueueDirect | .NET 9.0  | 1000  | 7,616.832 ns |  2.47 |     313 B |      56 B |          NA |
