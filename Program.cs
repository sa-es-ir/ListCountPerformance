using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Benchmark>();

[MemoryDiagnoser(false)]
public class Benchmark
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
    public int List_Count_Property() => _list.Count;
    [Benchmark]
    public int List_Count_Method() => _list.Count();

    [Benchmark]
    public int HashSet_Count_Property() => _hashset.Count;
    [Benchmark]
    public int HashSet_Count_Method() => _hashset.Count();
}