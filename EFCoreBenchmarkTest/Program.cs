
using BenchmarkDotNet.Running;
using EFCoreBenchmarkTest;

class Program
{
    static async Task Main(string[] args)
    {
        BenchmarkRunner.Run<EFBenchmark>();
    }
}