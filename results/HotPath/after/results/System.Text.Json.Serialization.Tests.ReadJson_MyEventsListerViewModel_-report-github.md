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
|    DeserializeFromString | 2.312 ms | 0.0355 ms | 0.0349 ms | 2.307 ms | 2.263 ms | 2.365 ms |     36.6972 |      9.1743 |           - |            161.9 KB |
| DeserializeFromUtf8Bytes | 2.344 ms | 0.0440 ms | 0.0412 ms | 2.346 ms | 2.263 ms | 2.407 ms |     18.5185 |           - |           - |            82.34 KB |
|    DeserializeFromStream | 2.521 ms | 0.0320 ms | 0.0299 ms | 2.509 ms | 2.484 ms | 2.583 ms |     20.2020 |           - |           - |            82.72 KB |
