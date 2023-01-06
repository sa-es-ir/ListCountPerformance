# Compare List Count property and Count() method

Based on this benchamrk it's always better to use **Count** property over **Count()** method for **List** or any type which implements **ICollection**

```bash
|                 Method | Count |      Mean |     Error |    StdDev |    Median |
|----------------------- |------ |----------:|----------:|----------:|----------:|
|      ListCountProperty | 10000 | 0.1183 ns | 0.0513 ns | 0.1189 ns | 0.0914 ns |
|        ListCountMethod | 10000 | 7.5509 ns | 0.3846 ns | 1.0911 ns | 7.2175 ns |
|   HashSetCountProperty | 10000 | 0.5539 ns | 0.1259 ns | 0.3711 ns | 0.6092 ns |
|     HashSetCountMethod | 10000 | 5.1896 ns | 0.2814 ns | 0.7796 ns | 4.9093 ns |
```

## Benchmark code

```csharp
public class ListCountBenchmark
{
    private List<int> _list;

    [Params(10_000)]
    public int Count { get; set; }

    [GlobalSetup]
    public void GlobalSetup()
    {
        IEnumerable<int> range = Enumerable.Range(0, Count);

        _list = range.ToList();
    }

    [Benchmark]
    public int ListCountProperty() => _list.Count;
    [Benchmark]
    public int ListCountMethod() => _list.Count();
}
```
