using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<ListCountBenchmark>();

public class ListCountBenchmark
{
    private List<int> _list;
    private HashSet<int> _hashset;

    [Params(10_000)]
    public int Count { get; set; }

    [GlobalSetup]
    public void GlobalSetup()
    {
        IEnumerable<int> range = Enumerable.Range(0, Count);

        _list = range.ToList();
        _hashset = new(range);
    }

    [Benchmark]
    public int HashSetCountProperty() => _hashset.Count;
    [Benchmark]
    public int HashSetCountMethod() => _hashset.Count();
	
    [Benchmark]
    public int ListCountProperty() => _list.Count;
    [Benchmark]
    public int ListCountMethod() => _list.Count();
}
