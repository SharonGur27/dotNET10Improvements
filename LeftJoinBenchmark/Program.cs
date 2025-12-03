// dotnet run -c Release -f net10.0 --filter "*"

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Linq;

BenchmarkSwitcher.FromAssembly(typeof(LeftJoinBenchmark).Assembly).Run(args);

[MemoryDiagnoser(displayGenColumns: false)]
[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
public partial class LeftJoinBenchmark
{
    private IEnumerable<int> Outer { get; } = Enumerable.Sequence(0, 1000, 2);
    private IEnumerable<int> Inner { get; } = Enumerable.Sequence(0, 1000, 3);

    [Benchmark]
    public void LeftJoin_Manual() =>
        ManualLeftJoin(Outer, Inner, o => o, i => i, (o, i) => o + i).Count();

    [Benchmark]
    public int LeftJoin_Linq() =>
        Outer.LeftJoin(Inner, o => o, i => i, (o, i) => o + i).Count();

    private static IEnumerable<TResult> ManualLeftJoin<TOuter, TInner, TKey, TResult>(
        IEnumerable<TOuter> outer, IEnumerable<TInner> inner,
        Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector,
        Func<TOuter, TInner?, TResult> resultSelector) =>
        outer
        .GroupJoin(inner, outerKeySelector, innerKeySelector, (o, inners) => (o, inners))
        .SelectMany(x => x.inners.DefaultIfEmpty(), (x, i) => resultSelector(x.o, i));
}