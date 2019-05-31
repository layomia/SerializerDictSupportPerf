``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-ZIDWVA : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 7.622 us | 0.0856 us | 0.0801 us | 7.625 us | 7.502 us | 7.810 us |      0.1236 |           - |           - |               608 B |
| SerializeToUtf8Bytes | 7.712 us | 0.1600 us | 0.1843 us | 7.664 us | 7.457 us | 8.120 us |      0.0903 |           - |           - |               400 B |
|    SerializeToStream | 7.688 us | 0.0395 us | 0.0350 us | 7.689 us | 7.642 us | 7.755 us |      0.0615 |           - |           - |               360 B |
