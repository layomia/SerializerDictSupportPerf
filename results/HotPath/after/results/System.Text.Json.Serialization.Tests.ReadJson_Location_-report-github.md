``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-ZIDWVA : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |     Error |    StdDev |   Median |      Min |       Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|----------:|----------:|---------:|---------:|----------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 9.367 us | 0.1075 us | 0.1005 us | 9.368 us | 9.166 us |  9.521 us |      0.1473 |           - |           - |               704 B |
| DeserializeFromUtf8Bytes | 9.036 us | 0.0908 us | 0.0850 us | 9.012 us | 8.923 us |  9.218 us |      0.1113 |           - |           - |               472 B |
|    DeserializeFromStream | 9.783 us | 0.1341 us | 0.1189 us | 9.788 us | 9.610 us | 10.036 us |      0.1969 |           - |           - |               864 B |
