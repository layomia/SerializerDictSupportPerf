``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012096
  [Host]     : .NET Core 3.0.0-preview6-27727-02 (CoreCLR 3.0.19.27471, CoreFX 4.700.19.27408), 64bit RyuJIT
  Job-HGKOAM : .NET Core ? (CoreCLR 3.0.19.27171, CoreFX 4.700.19.27801), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  

```
|                   Method |     Mean |    Error |   StdDev |   Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |---------:|---------:|---------:|---------:|-------:|------:|------:|----------:|
|          DeserializeDict | 777.3 ns | 19.03 ns | 16.87 ns | 774.3 ns | 0.0992 |     - |     - |     416 B |
|         DeserializeIDict | 797.7 ns | 16.02 ns | 33.80 ns | 785.1 ns | 0.0992 |     - |     - |     416 B |
| DeserializeIReadOnlyDict | 807.2 ns | 12.30 ns | 11.51 ns | 804.7 ns | 0.0992 |     - |     - |     416 B |
|            SerializeDict | 658.1 ns | 13.12 ns | 18.82 ns | 653.4 ns | 0.0782 |     - |     - |     328 B |
|           SerializeIDict | 670.6 ns | 12.83 ns | 14.77 ns | 668.1 ns | 0.0782 |     - |     - |     328 B |
|   SerializeIReadOnlyDict | 655.3 ns | 12.63 ns | 11.81 ns | 655.8 ns | 0.0772 |     - |     - |     328 B |
