``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-CTTNXB : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|               Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|--------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    SerializeToString | 337.4 us |  3.357 us |  2.803 us | 337.0 us | 332.1 us | 342.2 us |      5.6818 |           - |           - |            27.95 KB |
| SerializeToUtf8Bytes | 371.0 us | 22.396 us | 24.893 us | 364.4 us | 335.1 us | 435.9 us |      2.6596 |           - |           - |            15.12 KB |
|    SerializeToStream | 363.0 us | 29.353 us | 32.626 us | 348.4 us | 330.1 us | 446.6 us |           - |           - |           - |             2.39 KB |
