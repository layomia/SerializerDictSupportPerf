``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-CTTNXB : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |    Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 232.6 us | 2.239 us | 1.870 us | 232.0 us | 229.1 us | 235.3 us |      8.4746 |      0.9416 |           - |            36.55 KB |
| DeserializeFromUtf8Bytes | 230.5 us | 4.789 us | 4.480 us | 230.5 us | 224.6 us | 241.7 us |      5.4745 |           - |           - |            23.65 KB |
|    DeserializeFromStream | 224.9 us | 2.964 us | 2.773 us | 226.3 us | 219.1 us | 228.1 us |      5.4005 |           - |           - |            24.02 KB |
