// dotnet run -c Release -f net9.0 --filter "*" --runtimes net9.0 net10.0

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkSwitcher.FromAssembly(typeof(ObjectStackAllocationDelegates).Assembly).Run(args);

[DisassemblyDiagnoser]
[MemoryDiagnoser(displayGenColumns: false)]
[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD", "y")]
public class ObjectStackAllocationDelegates
{
    [Benchmark]
    [Arguments(42)]
    public int Sum(int y)
    {
        Func<int, int> addY = x => x + y;
        return DoubleResult(addY, y);
    }

    private int DoubleResult(Func<int, int> func, int arg)
    {
        int result = func(arg);
        return result + result;
    }
}