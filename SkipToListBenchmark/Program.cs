// dotnet run -c Release -f net9.0 --filter "*" --runtimes net9.0 net10.0

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkSwitcher.FromAssembly(typeof(SkipToListBenchmark).Assembly).Run(args);

[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
public partial class SkipToListBenchmark
{
    private readonly IEnumerable<string> _source = Enumerable.Range(0, 10000).Select(i => i.ToString()).ToArray();

    [Benchmark]
    public List<string> SkipTakeToList() => _source.Skip(2000).Take(2000).ToList();
}