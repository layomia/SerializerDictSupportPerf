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
|    SerializeToString | 2.255 ms | 0.0179 ms | 0.0167 ms | 2.254 ms | 2.229 ms | 2.281 ms |     71.4286 |     44.6429 |     44.6429 |           370.64 KB |
| SerializeToUtf8Bytes | 2.209 ms | 0.0206 ms | 0.0193 ms | 2.214 ms | 2.182 ms | 2.239 ms |     62.5000 |      8.9286 |           - |           291.07 KB |
|    SerializeToStream | 2.246 ms | 0.0507 ms | 0.0449 ms | 2.245 ms | 2.180 ms | 2.350 ms |     44.6429 |           - |           - |           211.66 KB |
