``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012096
  [Host]     : .NET Core 3.0.0-preview6-27727-02 (CoreCLR 3.0.19.27471, CoreFX 4.700.19.27408), 64bit RyuJIT
  Job-MPWNJU : .NET Core ? (CoreCLR 3.0.19.27171, CoreFX 4.700.19.27801), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  

```
|                   Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |---------:|----------:|----------:|---------:|-------:|------:|------:|----------:|
|          DeserializeDict | 688.9 ns | 13.233 ns | 12.997 ns | 684.2 ns | 0.0992 |     - |     - |     416 B |
|         DeserializeIDict | 690.4 ns | 13.667 ns | 20.033 ns | 692.9 ns | 0.0992 |     - |     - |     416 B |
| DeserializeIReadOnlyDict | 702.5 ns | 20.672 ns | 20.303 ns | 698.9 ns | 0.0992 |     - |     - |     416 B |
|            SerializeDict | 624.1 ns | 17.874 ns | 50.996 ns | 603.8 ns | 0.0782 |     - |     - |     328 B |
|           SerializeIDict | 577.7 ns |  7.338 ns |  6.864 ns | 577.9 ns | 0.0782 |     - |     - |     328 B |
|   SerializeIReadOnlyDict | 569.0 ns |  8.536 ns |  7.985 ns | 568.8 ns | 0.0782 |     - |     - |     328 B |
