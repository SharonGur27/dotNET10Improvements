```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.7093)
Intel Core i7-10850H CPU 2.70GHz (Max: 2.71GHz), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
  DefaultJob : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2

Job=DefaultJob  

```
| Method          | Mean     | Allocated |
|---------------- |---------:|----------:|
| LeftJoin_Manual | 736.3 μs |  65.84 KB |
| LeftJoin_Linq   | 148.3 μs |  36.95 KB |
