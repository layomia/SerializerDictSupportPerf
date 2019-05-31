``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-CTTNXB : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 3.117 us | 0.0579 us | 0.0568 us | 3.107 us | 3.032 us | 3.248 us |      0.0624 |           - |           - |               304 B |
| DeserializeFromUtf8Bytes | 2.960 us | 0.0483 us | 0.0452 us | 2.952 us | 2.905 us | 3.049 us |      0.0351 |           - |           - |               192 B |
|    DeserializeFromStream | 3.614 us | 0.0625 us | 0.0554 us | 3.618 us | 3.516 us | 3.687 us |      0.1298 |           - |           - |               576 B |
