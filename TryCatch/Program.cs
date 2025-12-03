// dotnet run -c Release -f net9.0 --filter "*" --runtimes net9.0 net10.0

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkSwitcher.FromAssembly(typeof(TryCatch).Assembly).Run(args);

[DisassemblyDiagnoser]
[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD", "i")]
public class TryCatch
{
    [Benchmark]
    [Arguments(42)]
    public int Test(int i)
    {
        try
        {
            i++;
        }
        catch
        {
            Console.WriteLine("Exception caught");
        }

        return i;
    }
}