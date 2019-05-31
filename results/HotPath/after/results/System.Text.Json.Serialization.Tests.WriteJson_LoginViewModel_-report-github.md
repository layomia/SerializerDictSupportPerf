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
|    SerializeToString | 3.012 us | 0.0321 us | 0.0300 us | 3.009 us | 2.962 us | 3.061 us |      0.0858 |           - |           - |               360 B |
| SerializeToUtf8Bytes | 3.002 us | 0.0749 us | 0.0832 us | 2.985 us | 2.897 us | 3.192 us |      0.0582 |           - |           - |               280 B |
|    SerializeToStream | 3.346 us | 0.1224 us | 0.1409 us | 3.314 us | 3.161 us | 3.581 us |      0.0763 |           - |           - |               360 B |
