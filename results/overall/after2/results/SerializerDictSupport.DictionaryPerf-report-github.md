``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-ZPNAWF : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  

```
|                   Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
|          DeserializeDict | 731.5 ns | 14.684 ns | 21.524 ns | 0.0992 |     - |     - |     416 B |
|         DeserializeIDict | 719.8 ns | 14.314 ns | 20.066 ns | 0.0992 |     - |     - |     416 B |
| DeserializeIReadOnlyDict | 721.6 ns | 14.251 ns | 24.582 ns | 0.0992 |     - |     - |     416 B |
|            SerializeDict | 817.5 ns | 16.344 ns | 23.957 ns | 0.0954 |     - |     - |     400 B |
|           SerializeIDict | 802.7 ns |  9.360 ns |  8.755 ns | 0.0954 |     - |     - |     400 B |
|   SerializeIReadOnlyDict | 839.9 ns | 16.863 ns | 26.253 ns | 0.0954 |     - |     - |     400 B |
