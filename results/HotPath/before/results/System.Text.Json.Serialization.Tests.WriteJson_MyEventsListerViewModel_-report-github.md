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
|    SerializeToString | 2.272 ms | 0.0345 ms | 0.0323 ms | 2.266 ms | 2.209 ms | 2.312 ms |     71.4286 |     44.6429 |     44.6429 |           370.61 KB |
| SerializeToUtf8Bytes | 2.235 ms | 0.0247 ms | 0.0231 ms | 2.237 ms | 2.192 ms | 2.264 ms |     62.5000 |      8.9286 |           - |              291 KB |
|    SerializeToStream | 2.269 ms | 0.0523 ms | 0.0537 ms | 2.248 ms | 2.195 ms | 2.396 ms |     44.6429 |           - |           - |           211.62 KB |
