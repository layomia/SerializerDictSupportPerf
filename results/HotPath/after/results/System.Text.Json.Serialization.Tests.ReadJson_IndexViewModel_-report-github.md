``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-ZIDWVA : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |    Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 234.2 us | 2.904 us | 2.717 us | 234.0 us | 229.8 us | 240.1 us |      8.3643 |      0.9294 |           - |            36.59 KB |
| DeserializeFromUtf8Bytes | 227.5 us | 2.527 us | 2.240 us | 227.6 us | 223.2 us | 230.9 us |      5.3763 |           - |           - |            23.68 KB |
|    DeserializeFromStream | 236.7 us | 2.255 us | 2.110 us | 237.2 us | 232.0 us | 239.6 us |      5.6926 |           - |           - |            24.06 KB |
