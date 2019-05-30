``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-LPOCIP : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  

```
|                   Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |---------:|----------:|----------:|---------:|-------:|------:|------:|----------:|
|          DeserializeDict | 698.0 ns | 13.884 ns | 22.811 ns | 685.8 ns | 0.0992 |     - |     - |     416 B |
|         DeserializeIDict | 689.9 ns |  6.155 ns |  4.805 ns | 690.4 ns | 0.0992 |     - |     - |     416 B |
| DeserializeIReadOnlyDict | 689.1 ns |  6.550 ns |  5.470 ns | 689.1 ns | 0.0992 |     - |     - |     416 B |
|            SerializeDict | 824.9 ns | 18.945 ns | 18.607 ns | 821.0 ns | 0.0954 |     - |     - |     400 B |
|           SerializeIDict | 790.2 ns | 15.665 ns | 19.812 ns | 784.8 ns | 0.0954 |     - |     - |     400 B |
|   SerializeIReadOnlyDict | 826.1 ns | 19.380 ns | 28.406 ns | 820.8 ns | 0.0954 |     - |     - |     400 B |
