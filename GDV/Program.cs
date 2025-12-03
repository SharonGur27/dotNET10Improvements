// dotnet run -c Release -f net9.0 --filter "*" --runtimes net9.0 net10.0

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Runtime.CompilerServices;

BenchmarkSwitcher.FromAssembly(typeof(GDV).Assembly).Run(args);

[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
public partial class GDV
{
    [Benchmark]
    public bool Test() => GenericEquals("abc", "abc");

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool GenericEquals<T>(T a, T b) => EqualityComparer<T>.Default.Equals(a, b);
}