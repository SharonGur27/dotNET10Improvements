```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.7093)
Intel Core i7-10850H CPU 2.70GHz (Max: 2.71GHz), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
  Job-HFWDAV : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
  Job-NFJGQR : .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2


```
| Method              | Runtime   | Count | Mean      | Ratio | Code Size | Allocated | Alloc Ratio |
|-------------------- |---------- |------ |----------:|------:|----------:|----------:|------------:|
| ForeachDirect       | .NET 10.0 | 15000 |  9.445 μs |  1.00 |      68 B |         - |          NA |
| ForeachDirect       | .NET 9.0  | 15000 |  9.464 μs |  1.00 |      68 B |         - |          NA |
|                     |           |       |           |       |           |           |             |
| ForeachViaInterface | .NET 10.0 | 15000 | 11.729 μs |  0.39 |     281 B |         - |        0.00 |
| ForeachViaInterface | .NET 9.0  | 15000 | 30.048 μs |  1.00 |     430 B |      40 B |        1.00 |
