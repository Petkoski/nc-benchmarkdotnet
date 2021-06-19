using BenchmarkDotNet.Running;
using System;

namespace BenchmarkDotNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DateParserBenchmarks>();
        }
    }
}
