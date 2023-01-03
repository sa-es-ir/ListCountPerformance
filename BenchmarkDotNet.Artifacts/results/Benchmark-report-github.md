``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19041.264/2004/May2020Update/20H1)
Intel Core i7-4500U CPU 1.80GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                 Method | Count |      Mean |     Error |    StdDev |    Median | Allocated |
|----------------------- |------ |----------:|----------:|----------:|----------:|----------:|
|    List_Count_Property | 10000 | 0.1183 ns | 0.0513 ns | 0.1189 ns | 0.0914 ns |         - |
|      List_Count_Method | 10000 | 7.5509 ns | 0.3846 ns | 1.0911 ns | 7.2175 ns |         - |
| HashSet_Count_Property | 10000 | 0.5539 ns | 0.1259 ns | 0.3711 ns | 0.6092 ns |         - |
|   HashSet_Count_Method | 10000 | 5.1896 ns | 0.2814 ns | 0.7796 ns | 4.9093 ns |         - |
