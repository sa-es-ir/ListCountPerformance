# Compare List Count property and Count() method

Based on this benchamrk it's always better to use Count property over Count() method for **List** or any type which implements **ICollection<T>**.

```bash
|                 Method | Count |      Mean |     Error |    StdDev |    Median |
|----------------------- |------ |----------:|----------:|----------:|----------:|
|    List_Count_Property | 10000 | 0.1183 ns | 0.0513 ns | 0.1189 ns | 0.0914 ns |
|      List_Count_Method | 10000 | 7.5509 ns | 0.3846 ns | 1.0911 ns | 7.2175 ns |
| HashSet_Count_Property | 10000 | 0.5539 ns | 0.1259 ns | 0.3711 ns | 0.6092 ns |
|   HashSet_Count_Method | 10000 | 5.1896 ns | 0.2814 ns | 0.7796 ns | 4.9093 ns |
```
