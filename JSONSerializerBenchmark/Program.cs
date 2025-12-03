// dotnet run -c Release -f net9.0 --filter "*" --runtimes net9.0 net10.0

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text.Json;

BenchmarkSwitcher.FromAssembly(typeof(JSONSerializerBenchmark).Assembly).Run(args);

[MemoryDiagnoser(displayGenColumns: false)]
[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
public partial class JSONSerializerBenchmark
{
    private Data _data = new();
    private MemoryStream _stream = new();

    [Benchmark]
    public void Serialize()
    {
        _stream.Position = 0;
        JsonSerializer.Serialize(_stream, _data);
    }

    public class Data
    {
        public int Value1 { get; set; }
    }
}