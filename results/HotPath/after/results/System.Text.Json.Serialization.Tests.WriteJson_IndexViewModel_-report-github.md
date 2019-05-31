``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-ZIDWVA : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |    Error |   StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|---------:|---------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 338.1 us | 2.541 us | 2.377 us | 338.2 us | 334.5 us | 342.3 us |      6.6489 |           - |           - |            27.98 KB |
| SerializeToUtf8Bytes | 332.3 us | 1.488 us | 1.319 us | 332.4 us | 328.8 us | 334.4 us |      2.6596 |           - |           - |            15.15 KB |
|    SerializeToStream | 338.8 us | 3.786 us | 3.356 us | 339.1 us | 332.9 us | 343.6 us |           - |           - |           - |             2.43 KB |
