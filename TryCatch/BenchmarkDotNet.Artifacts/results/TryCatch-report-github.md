```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.7093)
Intel Core i7-10850H CPU 2.70GHz (Max: 2.71GHz), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
  Job-HFWDAV : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
  Job-NFJGQR : .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2

i=42  

```
| Method | Runtime   | Mean      | Ratio | Code Size |
|------- |---------- |----------:|------:|----------:|
| Test   | .NET 10.0 | 0.0042 ns |  0.02 |       4 B |
| Test   | .NET 9.0  | 0.1815 ns |  1.02 |      81 B |
