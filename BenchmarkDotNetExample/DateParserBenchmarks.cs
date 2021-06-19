using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkDotNetExample
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmarks
    {
        //Z means UTC time
        private const string dateTime = "2020-12-13T16:33:06Z";
        private static readonly DateParser dateParser = new();

        //Baseline benchmark, where it all started (after that we will be optimizing)
        [Benchmark(Baseline = true)]
        public void GetYearFromDateTime()
        {
            dateParser.GetYearFromDateTime(dateTime);
        }

        [Benchmark]
        public void GetYearFromSplit()
        {
            dateParser.GetYearFromSplit(dateTime);
        }

        [Benchmark]
        public void GetYearFromSubstring()
        {
            dateParser.GetYearFromSubstring(dateTime);
        }

        [Benchmark]
        public void GetYearFromSpan()
        {
            dateParser.GetYearFromSpan(dateTime);
        }

        [Benchmark]
        public void GetYearFromSpanWithManualConversion()
        {
            dateParser.GetYearFromSpanWithManualConversion(dateTime);
        }
    }
}
