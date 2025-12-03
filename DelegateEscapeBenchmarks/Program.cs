// dotnet run -c Release -f net9.0 --filter "*" --runtimes net9.0 net10.0

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Runtime.CompilerServices;

BenchmarkSwitcher.FromAssembly(typeof(DelegateEscapeBenchmarks).Assembly).Run(args);

[DisassemblyDiagnoser]
[MemoryDiagnoser(displayGenColumns: false)]
[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD", "y")]
public class DelegateEscapeBenchmarks
{
    private Func<int, int>? _storedFunc;

    [Benchmark]
    [Arguments(42)]
    public int NonEscaping(int y)
    {
        Func<int, int> addAnswerToLifeTheUniverseAndEverything = x => x + y;
        return ApplyDeepThoughtOnce(addAnswerToLifeTheUniverseAndEverything, 13);
    }

    [Benchmark]
    [Arguments(42)]
    public int EscapingStoredFunc(int y)
    {
        Func<int, int> addAnswerToLifeTheUniverseAndEverything = x => x + y;
        _storedFunc = addAnswerToLifeTheUniverseAndEverything; // ESCAPES
        return ApplyDeepThoughtOnce(addAnswerToLifeTheUniverseAndEverything, 13);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private int ApplyDeepThoughtOnce(Func<int, int> f, int arg) => f(arg);

    [Benchmark]
    public int NonEscapingNonClosure()
    {
        Func<int, int> addAnswerToLifeTheUniverseAndEverything = x => 2 * x;
        return ApplyDeepThoughtOnce(addAnswerToLifeTheUniverseAndEverything, 13);
    }
}