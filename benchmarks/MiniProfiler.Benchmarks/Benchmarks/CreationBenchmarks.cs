﻿using BenchmarkDotNet.Attributes;
using StackExchange.Profiling.Internal;

namespace Benchmarks.Benchmarks
{
    [Config(typeof(Configs.MemoryFast))]
    public class CreationBenchmarks
    {
        private static readonly MiniProfilerBaseOptions BaseOptions = new MiniProfilerBenchmarkOptions()
        {
            Storage = null
        };

        [Benchmark(Description = "Start and Stop MiniProfiler")]
        public void StartStopProfiler()
        {
            var profiler = BaseOptions.StartProfiler("My Pofiler");
            profiler.Stop(true);
        }
    }
}