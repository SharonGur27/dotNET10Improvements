// dotnet run -c Release -f net9.0 --filter "*" --runtimes net9.0 net10.0

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkSwitcher.FromAssembly(typeof(ListEnumerator).Assembly).Run(args);

[DisassemblyDiagnoser]
[MemoryDiagnoser(displayGenColumns: false)]
[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD", "y")]
public class ListEnumerator
{
    private List<int>? _list;
    private IEnumerable<int>? _enumerable;

    [Params(15000)]
    public int Count { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _list = Enumerable.Range(0, Count).ToList();
        _enumerable = _list; // Polymorphic usage
    }

    [Benchmark]
    public int ForeachDirect()
    {
        int sum = 0;
        foreach (int item in _list!) 
            sum += item;

        return sum;
    }

    [Benchmark]
    public int ForeachViaInterface()
    {
        int sum = 0;
        foreach (int item in _enumerable!) 
            sum += item;

        return sum;
    }
}