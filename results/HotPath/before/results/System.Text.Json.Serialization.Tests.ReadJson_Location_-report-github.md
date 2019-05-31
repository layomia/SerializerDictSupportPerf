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
|    DeserializeFromString | 8.986 us | 0.2033 us | 0.1902 us | 8.995 us | 8.718 us | 9.462 us |      0.1527 |           - |           - |               704 B |
| DeserializeFromUtf8Bytes | 8.693 us | 0.1040 us | 0.0922 us | 8.693 us | 8.551 us | 8.871 us |      0.1037 |           - |           - |               472 B |
|    DeserializeFromStream | 9.431 us | 0.1114 us | 0.1042 us | 9.455 us | 9.262 us | 9.637 us |      0.1847 |           - |           - |               856 B |
