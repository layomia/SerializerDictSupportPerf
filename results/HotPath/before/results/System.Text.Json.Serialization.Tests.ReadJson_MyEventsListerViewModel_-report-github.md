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
|    DeserializeFromString | 2.247 ms | 0.0439 ms | 0.0411 ms | 2.227 ms | 2.206 ms | 2.356 ms |     35.3982 |      8.8496 |           - |            161.9 KB |
| DeserializeFromUtf8Bytes | 2.227 ms | 0.0183 ms | 0.0163 ms | 2.228 ms | 2.204 ms | 2.263 ms |     18.0180 |           - |           - |             82.3 KB |
|    DeserializeFromStream | 2.412 ms | 0.0410 ms | 0.0342 ms | 2.403 ms | 2.355 ms | 2.489 ms |     19.2308 |           - |           - |            82.68 KB |
