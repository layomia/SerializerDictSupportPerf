``` ini

BenchmarkDotNet=v0.11.3.1003-nightly, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012121
  [Host]     : .NET Core 3.0.0-preview6-27729-05 (CoreCLR 4.700.19.27901, CoreFX 4.700.19.27903), 64bit RyuJIT
  Job-ZIDWVA : .NET Core ? (CoreCLR 4.600.19.27871, CoreFX 4.700.19.28001), 64bit RyuJIT

Runtime=Core  Toolchain=CoreRun  IterationTime=250.0000 ms  
MaxIterationCount=20  MinIterationCount=15  WarmupCount=1  

```
|                   Method |     Mean |     Error |    StdDev |   Median |      Min |      Max | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
|------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|------------:|------------:|------------:|--------------------:|
|    DeserializeFromString | 3.190 us | 0.0296 us | 0.0262 us | 3.187 us | 3.120 us | 3.232 us |      0.0634 |           - |           - |               304 B |
| DeserializeFromUtf8Bytes | 3.075 us | 0.0394 us | 0.0369 us | 3.069 us | 2.982 us | 3.132 us |      0.0365 |           - |           - |               192 B |
|    DeserializeFromStream | 3.619 us | 0.0430 us | 0.0381 us | 3.628 us | 3.555 us | 3.694 us |      0.1314 |           - |           - |               584 B |
