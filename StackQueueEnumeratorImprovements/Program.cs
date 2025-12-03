// dotnet run -c Release -f net9.0 --filter "*" --runtimes net9.0 net10.0

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Concurrent;

BenchmarkSwitcher.FromAssembly(typeof(StackQueueEnumeratorImprovements).Assembly).Run(args);

[DisassemblyDiagnoser]
[MemoryDiagnoser(displayGenColumns: false)]
[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD", "y")]

public class StackQueueEnumeratorImprovements
{
    private Stack<int> _stack;
    private Queue<int> _queue;
    private ConcurrentDictionary<int, int> _concurrentDictionary;

    [Params(10, 1000)]
    public int Count { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _stack = new Stack<int>(Enumerable.Range(0, Count));
        _queue = new Queue<int>(Enumerable.Range(0, Count));
        _concurrentDictionary = new ConcurrentDictionary<int, int>(Enumerable.Range(0, Count).ToDictionary(i => i, i => i));
    }

    [Benchmark(Baseline = true)]
    public int StackDirect()
    {
        int sum = 0;
        foreach (var item in _stack)
            sum += item;

        return sum;
    }

    [Benchmark]
    public int QueueDirect()
    {
        int sum = 0;
        foreach (var item in _queue)
            sum += item;

        return sum;
    }

    [Benchmark]
    public int ConcurrentQueueDirect()
    {
        int sum = 0;
        foreach (var item in _concurrentDictionary)
            sum += item.Value;

        return sum;
    }
}